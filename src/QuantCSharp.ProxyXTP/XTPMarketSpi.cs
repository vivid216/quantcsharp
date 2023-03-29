using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using QuantCSharp.ProxyXTP.Api;
using QuantCSharp.Utilities;
using Disruptor;

namespace QuantCSharp.ProxyXTP
{
    public class XTPMarketSpi : QuoteSpi, IQuotesProxy
    {
        private static readonly Utilities.IAsyncLog _logger = Utilities.LogManager.GetLogger(typeof(XTPMarketSpi));
        private readonly XTPMarketApi tPMdApi;
        private readonly XTPAccessInfo accInfo;
        private readonly Disruptor.RingBuffer<XTPMarketDataStruct> ringBuffer;

        public XTPMarketSpi(IWorkHandler<XTPMarketDataStruct> marketHandler, string configPath) : base()
        {
            Utilities.INIHelper nIHelper = new INIHelper(configPath);
            var xtpSectionNode = nIHelper[$"UseNode:MarketNode"];
            accInfo = XTPAccessInfo.LoadAccessInfo(xtpSectionNode);
            tPMdApi = new XTPMarketApi(accInfo);

            ringBuffer = RingBuffer<XTPMarketDataStruct>.CreateSingleProducer(() => new XTPMarketDataStruct(), 1024, new BusySpinWaitStrategy());
            var sequenceBarrier = ringBuffer.NewBarrier();
            var _workerPool = new WorkerPool<XTPMarketDataStruct>(ringBuffer,
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
                int ret = tPMdApi.Init(this);
                if (ret == 0)
                    AsyncManualWaitLock.Release();
            };
            //返回到当前线程执行ac的wait操作
            Task.Run(acSpi).ContinueWith(ac, TaskContinuationOptions.ExecuteSynchronously).Wait();
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
        public override void OnDisconnected(int reason)
        {
            tPMdApi.OnUserLoginActive(false);
            _logger.ErrorFormat($"OnDisconnected return {reason}");
        }

        /// <summary>
        /// </summary>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public override void OnError(XTPRspInfoStruct error_info)
        {
            CheckRspInfoField(error_info);
        }

        public override void OnSubMarketData(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct ticker, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info, bool is_last)
        {
            _logger.Info($"OnSubMarketData {ticker.Ticker.ToPtrString()} {ticker.ExchangeId} isLast:{is_last}, errorCode:{error_info?.ErrorId}");
            CheckRspInfoField(error_info);
        }

        public override void OnDepthMarketData(ProxyXTP.XTPMarketDataStruct market_data, long[] bid1_qty, int bid1_count, int max_bid1_count, long[] ask1_qty, int ask1_count, int max_ask1_count)
        {
            EventDisruptor(market_data);
        }

        private void EventDisruptor(XTPMarketDataStruct market_data)
        {
            long sequence = ringBuffer.Next();
            try
            {
                XTPMarketDataStruct _event = ringBuffer[sequence];
                _event.Ticker = market_data.Ticker;
                _event.LastPrice = market_data.LastPrice;
                _event.Qty = market_data.Qty;
                _event.Turnover = market_data.Turnover;
                _event.Bid = market_data.Bid;
                _event.BidQty = market_data.BidQty;
                _event.Ask = market_data.Ask;
                _event.AskQty= market_data.AskQty;
                _event.DataTime = market_data.DataTime;
            }
            finally
            {
                ringBuffer.Publish(sequence);
            }
        }

        private void CheckRspInfoField(XTPRspInfoStruct pRspInfo)
        {
            if (pRspInfo != null && pRspInfo.ErrorId != 0)
            {
                _logger.Info($"rspId:{pRspInfo.ErrorId},rspMsg:{pRspInfo.ErrorMsg.ToPtrString()}");
            }
        }

    }
}
