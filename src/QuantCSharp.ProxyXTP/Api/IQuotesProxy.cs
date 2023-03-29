using System;
using System.Collections.Generic;
using System.Text;

namespace QuantCSharp.ProxyXTP.Api
{
    /// <summary>
    /// 行情柜台接口
    /// </summary>
    public interface IQuotesProxy
    {
        /// <summary>
        /// 加载Proxy
        /// </summary>
        void Load();

        /// <summary>
        /// 次函数不是线程安全的
        /// </summary>
        /// <param name="quoteArray"></param>
        void TraceQuotes(params string[] quoteArray);

        void ShutDown();
    }
}
