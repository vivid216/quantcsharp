using Disruptor;
using ProxyCTP;
using QuantCSharp.ProxyCTP;
using QuantCSharp.ProxyCTP.Api;
using QuantCSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    class CtpMarketSubs : IWorkHandler<CThostFtdcDepthMarketDataField>
    {
        public CtpMarketSubs() {
            IQuotesProxy cTPMarket = new CTPMarketSpi(this,System.IO.Path.Combine(AppContext.BaseDirectory, "configs", "ctpconfig.ini"));
            cTPMarket.Load();
            cTPMarket.TraceQuotes("AP305","rb2305");
        }

        void IWorkHandler<CThostFtdcDepthMarketDataField>.OnEvent(CThostFtdcDepthMarketDataField evt)
        {
            Console.WriteLine($"instrumentId:{evt.InstrumentID.ToPtrString()},ap1:{evt.AskPrice1},av1:{evt.AskVolume1},bp1:{evt.BidPrice1},bv1:{evt.BidVolume1},lp:{evt.LastPrice}");
        }
    }
}
