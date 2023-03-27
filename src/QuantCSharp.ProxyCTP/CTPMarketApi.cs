using ProxyCTP;
using QuantCSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

//-1，表示网络连接失败；
//-2，表示未处理请求超过许可数；
//-3，表示每秒发送请求数超过许可数。

namespace QuantCSharp.ProxyCTP
{
    class CTPMarketApi
    {
        private readonly CTPAccessInfo _accessInfo;
        readonly CThostFtdcMdApi _cThostFtdcMdApi;
        readonly Utilities.IAsyncLog _logger = Utilities.LogManager.GetLogger(typeof(CTPMarketApi));
        System.Collections.Immutable.ImmutableHashSet<string> _subscribedList = System.Collections.Immutable.ImmutableHashSet<string>.Empty;

        public CTPMarketApi(CTPAccessInfo accessInfo)
        {
            _accessInfo = accessInfo;
            var version = CThostFtdcMdApi.ApiVersion;
            _logger.Info($"CThostFtdcMdApi version {version}");
            _cThostFtdcMdApi = CThostFtdcMdApi.CreateFtdcMdApi(System.IO.Path.Combine(AppContext.BaseDirectory, $"{_accessInfo.InvestorID}_MD"), false, false);
        }

        internal void ReceiveMarketSubscribe(string quotesArray)
        {
            var arg0 = quotesArray.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var slBuilder = _subscribedList.ToBuilder();
            List<string> subIds = new List<string>();
            for (int i = 0; i < arg0.Length; i++)
            {
                var id = arg0[i];
                if (slBuilder.Contains(id))
                {
                    continue;
                }
                slBuilder.Add(id);
                subIds.Add(id);
            }
            if (subIds.Count > 0)
            {
                _subscribedList = slBuilder.ToImmutable();
                _cThostFtdcMdApi.SubscribeMarketData(subIds.ToArray(), subIds.Count);
            }
        }

        internal System.Threading.Tasks.Task Init(CThostFtdcMdSpi mdSpi)
        {
            _cThostFtdcMdApi.RegisterSpi(mdSpi);
            unsafe
            {
                _cThostFtdcMdApi.RegisterFront(_accessInfo.FrontAddress.ToSbytePtr());
            }
            _cThostFtdcMdApi.Init();
            return System.Threading.Tasks.Task.Run(() => _cThostFtdcMdApi.Join());
        }

        internal void OnRspFrontConnected(bool isActive)
        {
            _logger.Info($"OnRspFrontActive is {isActive}");
            if (isActive)
            {
                CThostFtdcReqUserLoginField cfLogin = new CThostFtdcReqUserLoginField();
                cfLogin.BrokerID = _accessInfo.BrokerID.ToSbyteArray(CTPConst.BrokerID);
                cfLogin.UserID = _accessInfo.UserID.ToSbyteArray(CTPConst.UserID);
                cfLogin.Password = _accessInfo.Password.ToSbyteArray(CTPConst.Password);
                cfLogin.UserProductInfo = _accessInfo.UserProductInfo.ToSbyteArray(CTPConst.UserProductInfo);
                _cThostFtdcMdApi.ReqUserLogin(cfLogin, SafeNumIncrement.SafeInstanceCount);
                _logger.Info($"ReqUserLogin with {_accessInfo.UserID}");
            }
        }

        internal void OnUserLoginActive(bool isActive)
        {
            _logger.Info($"OnUserLoginActive is {isActive}");
            var slcopy = _subscribedList;
            if (isActive)
            {
                //登陆成功
                _logger.Info($"MarketApi LoginSuccess with {_accessInfo.InvestorID}");
                if (slcopy.Count > 0)
                    _cThostFtdcMdApi.SubscribeMarketData(slcopy.ToArray(), slcopy.Count);
            }
            else
            {
                _cThostFtdcMdApi.UnSubscribeMarketData(slcopy.ToArray(), slcopy.Count);

                CThostFtdcUserLogoutField cfLogin = new CThostFtdcUserLogoutField();
                cfLogin.BrokerID = _accessInfo.BrokerID.ToSbyteArray(CTPConst.BrokerID);
                cfLogin.UserID = _accessInfo.UserID.ToSbyteArray(CTPConst.UserID);
                _cThostFtdcMdApi.ReqUserLogout(cfLogin, SafeNumIncrement.SafeInstanceCount);
                //
            }
        }
    }
}
