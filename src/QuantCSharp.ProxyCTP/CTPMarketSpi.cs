using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disruptor;
using QuantCSharp.ProxyCTP.Api;
using ProxyCTP;
using QuantCSharp.Utilities;

namespace QuantCSharp.ProxyCTP
{
    public class CTPMarketSpi : CThostFtdcMdSpi, IQuotesProxy
    {
        private static readonly Utilities.IAsyncLog _logger = Utilities.LogManager.GetLogger(typeof(CTPMarketSpi));
        private string TradingDay = string.Empty;
        private readonly CTPMarketApi tPMdApi;
        private readonly CTPAccessInfo accInfo;
        private readonly Disruptor.RingBuffer<CThostFtdcDepthMarketDataField> ringBuffer;

        public CTPMarketSpi(IWorkHandler<CThostFtdcDepthMarketDataField> marketHandler, string configPath) :base()
        {
            Utilities.INIHelper nIHelper = new INIHelper(configPath);
            var ctpSectionNode = nIHelper[$"UseNode:MarketNode"];
            accInfo = CTPAccessInfo.LoadAccessInfo(ctpSectionNode, configPath);
            tPMdApi = new CTPMarketApi(accInfo);

            ringBuffer = RingBuffer<CThostFtdcDepthMarketDataField>.CreateSingleProducer(() => new CThostFtdcDepthMarketDataField(), 1024, new BusySpinWaitStrategy());
            var sequenceBarrier = ringBuffer.NewBarrier();
            var _workerPool = new WorkerPool<CThostFtdcDepthMarketDataField>(ringBuffer,
                                             sequenceBarrier,
                                             new FatalExceptionHandler(),
                                             marketHandler);
            ringBuffer.AddGatingSequences(_workerPool.GetWorkerSequences());
            var _executor = new Disruptor.Dsl.BasicExecutor(TaskScheduler.Default); //TODO
            _workerPool.Start(_executor);
        }

        void IQuotesProxy.Load()
        {
            AsyncManualWaitLock.Reset();
            Action<System.Threading.Tasks.Task> ac = (tk) =>
            {
                AsyncManualWaitLock.Wait();
            };

            Action acSpi = () =>
            {
                tPMdApi.Init(this);
            };
            //返回到当前线程执行ac的wait操作
            Task.Run(acSpi).ContinueWith(ac, TaskContinuationOptions.ExecuteSynchronously).Wait();
            //返回到当前线程执行ac的wait操作
        }

        void IQuotesProxy.TraceQuotes(params string[] quoteArray)
        {
            tPMdApi.ReceiveMarketSubscribe(string.Join(";", quoteArray));
        }

        void IQuotesProxy.ShutDown()
        {
            tPMdApi.OnUserLoginActive(false);
        }


        /// <summary>当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。</summary>
        public override void OnFrontConnected()
        {
            tPMdApi.OnRspFrontConnected(true);
        }

        /// <summary>当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。</summary>
        /// <param name="nReason">
        /// <para>错误原因</para>
        /// <para>0x1001 网络读失败</para>
        /// <para>0x1002 网络写失败</para>
        /// <para>0x2001 接收心跳超时</para>
        /// <para>0x2002 发送心跳失败</para>
        /// <para>0x2003 收到错误报文</para>
        /// </param>
        public override void OnFrontDisconnected(int nReason)
        {
            tPMdApi.OnRspFrontConnected(false);
        }

        /// <summary>心跳超时警告。当长时间未收到报文时，该方法被调用。</summary>
        /// <param name="nTimeLapse">距离上次接收报文的时间</param>
        public override void OnHeartBeatWarning(int nTimeLapse)
        {

        }


        /// <summary>登录请求响应</summary>
        public override void OnRspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            CheckRspInfoField(pRspInfo);
            if (pRspUserLogin != null)
            {
                TradingDay = pRspUserLogin.TradingDay.ToPtrString();
                //_cTPMedicator.FrontId = pRspUserLogin.FrontID;
                //_cTPMedicator.SessionId = pRspUserLogin.SessionID;
            }
            if (bIsLast && (pRspInfo == null || pRspInfo.ErrorID == 0))
            {
                tPMdApi.OnUserLoginActive(true);
                AsyncManualWaitLock.Release();
            }
        }

        /// <summary>登出请求响应</summary>
        public override void OnRspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            CheckRspInfoField(pRspInfo);
            tPMdApi.OnUserLoginActive(false);
        }

        /// <summary>
        /// 此接口仅在报单被 此接口仅在报单被 此接口仅在报单被 此接口仅在报单被 CTPCTPCTP端拒绝时被调用来进行报错。 
        /// </summary>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public override void OnRspError(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //base.OnRspError(pRspInfo, nRequestID, bIsLast);
            CheckRspInfoField(pRspInfo);
        }

        public override void OnRspSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //base.OnRspSubMarketData(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
            _logger.Info($"receive submarket response {pSpecificInstrument.InstrumentID.ToPtrString()}");
            CheckRspInfoField(pRspInfo);
        }

        public override void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            //通知行情
            EventDisruptor(pDepthMarketData);
        }


        private void EventDisruptor(CThostFtdcDepthMarketDataField message)
        {

            long sequence = ringBuffer.Next();
            try
            {
                CThostFtdcDepthMarketDataField _event = ringBuffer[sequence];
                _event.InstrumentID = message.InstrumentID;
                _event.AskPrice1 = message.AskPrice1;
                _event.BidPrice1 = message.BidPrice1;
                _event.AskVolume1 = message.AskVolume1;
                _event.BidVolume1 = message.BidVolume1;
                _event.LastPrice = message.LastPrice;
            }
            finally
            {
                //发布事件 
                ringBuffer.Publish(sequence);
            }
        }

        private void CheckRspInfoField(CThostFtdcRspInfoField pRspInfo)
        {
            if (pRspInfo != null)
            {
                _logger.Info($"rspId:{pRspInfo.ErrorID},rspMsg:{pRspInfo.ErrorMsg.ToPtrString()}");
            }
        }

    }
}
