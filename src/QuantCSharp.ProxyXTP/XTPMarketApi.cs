using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Immutable;
using QuantCSharp.Utilities;

//-1，表示网络连接失败；
//-2，表示未处理请求超过许可数；
//-3，表示每秒发送请求数超过许可数。

namespace QuantCSharp.ProxyXTP
{
    class XTPMarketApi
    {
        private readonly XTPAccessInfo _accessInfo;
       readonly QuoteApi _cThostFtdcMdApi;
        readonly Utilities.IAsyncLog _logger = Utilities.LogManager.GetLogger(typeof(XTPMarketApi));
        System.Collections.Immutable.ImmutableHashSet<string> _subscribedSHList = ImmutableHashSet<string>.Empty;
        System.Collections.Immutable.ImmutableHashSet<string> _subscribedSZList = ImmutableHashSet<string>.Empty;

        public XTPMarketApi(XTPAccessInfo accessInfo)
        {
            _accessInfo = accessInfo;
            _cThostFtdcMdApi = QuoteApi.CreateQuoteApi(_accessInfo.ClientID,
                System.IO.Path.Combine(AppContext.BaseDirectory, $"{_accessInfo.InvestorID}_MD"), ProxyXTP.XTP_LOG_LEVEL.XTP_LOG_LEVEL_INFO);
            var version = _cThostFtdcMdApi.ApiVersion;
            _logger.Info($"XTPMarketApi version {version}");
        }

        internal void ReceiveMarketSubscribe(string quotesArray)
        {
            var arg0 = quotesArray.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var shBuilder = _subscribedSHList.ToBuilder();
            var szBuilder = _subscribedSZList.ToBuilder();
            for (int i = 0; i < arg0.Length; i++)
            {
                string realId = arg0[i][0..arg0[i].IndexOf('.')];
                if (arg0[i].LastIndexOf('H') > 0)
                {
                    if (shBuilder.Contains(realId)) { continue; }
                    shBuilder.Add(realId);
                }
                else if (arg0[i].LastIndexOf('Z') > 0)
                {
                    if (szBuilder.Contains(realId)) { continue; }
                    szBuilder.Add(realId);
                }
                else
                {
                    continue;
                }
            }

            _subscribedSHList = shBuilder.ToImmutable();
            _subscribedSZList = szBuilder.ToImmutable();
            _cThostFtdcMdApi.SubscribeMarketData(_subscribedSHList.ToArray(), _subscribedSHList.Count, ProxyXTP.XTP_EXCHANGE_TYPE.XTP_EXCHANGE_SH);
            _cThostFtdcMdApi.SubscribeMarketData(_subscribedSZList.ToArray(), _subscribedSZList.Count, ProxyXTP.XTP_EXCHANGE_TYPE.XTP_EXCHANGE_SZ);
        }

        internal int Init(XTPMarketSpi mdSpi)
        {
            _cThostFtdcMdApi.RegisterSpi(mdSpi);
            _cThostFtdcMdApi.SetHeartBeatInterval(_accessInfo.HeartInterval);
            var loginResult_quote = _cThostFtdcMdApi.Login(_accessInfo.FrontIp, _accessInfo.FrontPort,
                _accessInfo.InvestorID, _accessInfo.Password,
               ProxyXTP.XTP_PROTOCOL_TYPE.XTP_PROTOCOL_TCP, null);
            if (loginResult_quote != 0) {
                _logger.Error($"login failed with errorCode:{loginResult_quote}, detail:{GetApiLastError()}");
            }
            OnUserLoginActive(loginResult_quote == 0);
            return loginResult_quote;
        }

        internal void OnUserLoginActive(bool isActive)
        {
            _logger.Info($"OnUserLoginActive is {isActive}");
            var shcopy = _subscribedSHList;
            var szcopy = _subscribedSZList;
            if (isActive)
            {
                //登陆成功
                _logger.Info($"MarketApi LoginSuccess with {_accessInfo.InvestorID}");
            }
            else
            {
                _cThostFtdcMdApi.UnSubscribeMarketData(shcopy.ToArray(), shcopy.Count,ProxyXTP.XTP_EXCHANGE_TYPE.XTP_EXCHANGE_SH);
                _cThostFtdcMdApi.UnSubscribeMarketData(szcopy.ToArray(), szcopy.Count,ProxyXTP.XTP_EXCHANGE_TYPE.XTP_EXCHANGE_SZ);
                if (_cThostFtdcMdApi.Logout == 0)
                {
                    _logger.Info($"MarketApi Loginout with {_accessInfo.InvestorID}");
                }
                //
            }
        }

        internal string GetApiLastError() =>$"{_cThostFtdcMdApi.ApiLastError?.ErrorMsg.ToPtrString()}[{_cThostFtdcMdApi.ApiLastError?.ErrorId}]" ;
    }
}
