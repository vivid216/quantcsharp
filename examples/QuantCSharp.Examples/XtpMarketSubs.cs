using Disruptor;
using QuantCSharp.ProxyXTP;
using QuantCSharp.ProxyXTP.Api;
using QuantCSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    class XtpMarketSubs : IWorkHandler<XTPMarketDataStruct>
    {
        public XtpMarketSubs() {
            IQuotesProxy cTPMarket = new XTPMarketSpi(this,System.IO.Path.Combine(AppContext.BaseDirectory, "configs", "xtpconfig.ini"));
            cTPMarket.Load();
            cTPMarket.TraceQuotes("000001.SZ","600000.SH");
        }

        void IWorkHandler<XTPMarketDataStruct>.OnEvent(XTPMarketDataStruct evt)
        {
            Console.WriteLine($"instrumentId:{evt.Ticker.ToPtrString()},ap1:{evt.Ask[0]},av1:{evt.AskQty[0]},bp1:{evt.Bid[0]},bv1:{evt.BidQty[0]},lp:{evt.LastPrice}");
        }
    }
}
