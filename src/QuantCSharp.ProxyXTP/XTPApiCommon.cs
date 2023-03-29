using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

namespace QuantCSharp.ProxyXTP
{
    public unsafe partial class QuoteSpi : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_QuoteSpi;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0QuoteSpi@API@XTP@@QEAA@XZ")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr __instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0QuoteSpi@API@XTP@@QEAA@AEBV012@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.QuoteSpi> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.QuoteSpi>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public QuoteSpi()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.QuoteSpi.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            SetupVTables(GetType().FullName == "QuantCSharp.ProxyXTP.QuoteSpi");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.QuoteSpi __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::QuantCSharp.ProxyXTP.QuoteSpi.__Internal*)__Instance)->vfptr_QuoteSpi = new global::System.IntPtr(__OriginalVTables[0]);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>当客户端与行情后台通信连接断开时，该方法被调用。</summary>
        /// <param name="reason">错误原因，请与错误代码表对应</param>
        /// <remarks>api不会自动重连，当断线发生时，请用户自行选择后续操作。可以在此函数中调用Login重新登录。注意用户重新登录后，需要重新订阅行情</remarks>
        public virtual void OnDisconnected(int reason)
        {
        }

        /// <summary>错误应答</summary>
        /// <param name="error_info">当服务器响应发生错误时的具体的错误代码和错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>此函数只有在服务器发生错误时才会调用，一般无需用户处理</remarks>
        public virtual void OnError(global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>订阅行情应答，包括股票、指数和期权</summary>
        /// <param name="ticker">详细的合约订阅情况</param>
        /// <param name="error_info">订阅合约发生错误时的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <param name="is_last">是否此次订阅的最后一个应答，当为最后一个的时候为true，如果为false，表示还有其他后续消息响应</param>
        /// <remarks>每条订阅的合约均对应一条订阅应答，需要快速返回，否则会堵塞后续消息，当堵塞严重时，会触发断线</remarks>
        public virtual void OnSubMarketData(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct ticker, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info, bool is_last)
        {
        }

        /// <summary>退订行情应答，包括股票、指数和期权</summary>
        /// <param name="ticker">详细的合约取消订阅情况</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <param name="is_last">是否此次取消订阅的最后一个应答，当为最后一个的时候为true，如果为false，表示还有其他后续消息响应</param>
        /// <remarks>每条取消订阅的合约均对应一条取消订阅应答，需要快速返回，否则会堵塞后续消息，当堵塞严重时，会触发断线</remarks>
        public virtual void OnUnSubMarketData(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct ticker, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info, bool is_last)
        {
        }

        /// <summary>深度行情通知，包含买一卖一队列</summary>
        /// <param name="market_data">行情数据</param>
        /// <param name="bid1_qty">买一队列数据</param>
        /// <param name="bid1_count">买一队列的有效委托笔数</param>
        /// <param name="max_bid1_count">买一队列总委托笔数</param>
        /// <param name="ask1_qty">卖一队列数据</param>
        /// <param name="ask1_count">卖一队列的有效委托笔数</param>
        /// <param name="max_ask1_count">卖一队列总委托笔数</param>
        /// <remarks>需要快速返回，否则会堵塞后续消息，当堵塞严重时，会触发断线</remarks>
        public virtual void OnDepthMarketData(global::QuantCSharp.ProxyXTP.XTPMarketDataStruct market_data, long[] bid1_qty, int bid1_count, int max_bid1_count, long[] ask1_qty, int ask1_count, int max_ask1_count)
        {
        }

        /// <summary>订阅行情订单簿应答，包括股票、指数和期权</summary>
        /// <param name="ticker">详细的合约订阅情况</param>
        /// <param name="error_info">订阅合约发生错误时的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <param name="is_last">是否此次订阅的最后一个应答，当为最后一个的时候为true，如果为false，表示还有其他后续消息响应</param>
        /// <remarks>每条订阅的合约均对应一条订阅应答，需要快速返回，否则会堵塞后续消息，当堵塞严重时，会触发断线</remarks>
        public virtual void OnSubOrderBook(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct ticker, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info, bool is_last)
        {
        }

        /// <summary>退订行情订单簿应答，包括股票、指数和期权</summary>
        /// <param name="ticker">详细的合约取消订阅情况</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <param name="is_last">是否此次取消订阅的最后一个应答，当为最后一个的时候为true，如果为false，表示还有其他后续消息响应</param>
        /// <remarks>每条取消订阅的合约均对应一条取消订阅应答，需要快速返回，否则会堵塞后续消息，当堵塞严重时，会触发断线</remarks>
        public virtual void OnUnSubOrderBook(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct ticker, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info, bool is_last)
        {
        }

        /// <summary>行情订单簿通知，包括股票、指数和期权</summary>
        /// <param name="order_book">行情订单簿数据，需要快速返回，否则会堵塞后续消息，当堵塞严重时，会触发断线</param>
        public virtual void OnOrderBook(global::QuantCSharp.ProxyXTP.OrderBookStruct order_book)
        {
        }

        /// <summary>订阅逐笔行情应答，包括股票、指数和期权</summary>
        /// <param name="ticker">详细的合约订阅情况</param>
        /// <param name="error_info">订阅合约发生错误时的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <param name="is_last">是否此次订阅的最后一个应答，当为最后一个的时候为true，如果为false，表示还有其他后续消息响应</param>
        /// <remarks>每条订阅的合约均对应一条订阅应答，需要快速返回，否则会堵塞后续消息，当堵塞严重时，会触发断线</remarks>
        public virtual void OnSubTickByTick(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct ticker, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info, bool is_last)
        {
        }

        /// <summary>退订逐笔行情应答，包括股票、指数和期权</summary>
        /// <param name="ticker">详细的合约取消订阅情况</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <param name="is_last">是否此次取消订阅的最后一个应答，当为最后一个的时候为true，如果为false，表示还有其他后续消息响应</param>
        /// <remarks>每条取消订阅的合约均对应一条取消订阅应答，需要快速返回，否则会堵塞后续消息，当堵塞严重时，会触发断线</remarks>
        public virtual void OnUnSubTickByTick(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct ticker, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info, bool is_last)
        {
        }

        /// <summary>逐笔行情通知，包括股票、指数和期权</summary>
        /// <param name="tbt_data">逐笔行情数据，包括逐笔委托和逐笔成交，此为共用结构体，需要根据type来区分是逐笔委托还是逐笔成交，需要快速返回，否则会堵塞后续消息，当堵塞严重时，会触发断线</param>
        public virtual void OnTickByTick(global::QuantCSharp.ProxyXTP.XTPTickByTickStruct tbt_data)
        {
        }

        /// <summary>订阅全市场的股票行情应答</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnSubscribeAllMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>退订全市场的股票行情应答</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnUnSubscribeAllMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>订阅全市场的股票行情订单簿应答</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnSubscribeAllOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>退订全市场的股票行情订单簿应答</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnUnSubscribeAllOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>订阅全市场的股票逐笔行情应答</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnSubscribeAllTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>退订全市场的股票逐笔行情应答</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnUnSubscribeAllTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>查询合约部分静态信息的应答</summary>
        /// <param name="ticker_info">合约部分静态信息</param>
        /// <param name="error_info">查询合约部分静态信息时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <param name="is_last">是否此次查询合约部分静态信息的最后一个应答，当为最后一个的时候为true，如果为false，表示还有其他后续消息响应</param>
        public virtual void OnQueryAllTickers(global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo ticker_info, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info, bool is_last)
        {
        }

        /// <summary>查询合约的最新价格信息应答</summary>
        /// <param name="ticker_info">合约的最新价格信息</param>
        /// <param name="error_info">查询合约的最新价格信息时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <param name="is_last">是否此次查询的最后一个应答，当为最后一个的时候为true，如果为false，表示还有其他后续消息响应</param>
        public virtual void OnQueryTickersPriceInfo(global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo ticker_info, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info, bool is_last)
        {
        }

        /// <summary>订阅全市场的期权行情应答</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnSubscribeAllOptionMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>退订全市场的期权行情应答</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnUnSubscribeAllOptionMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>订阅全市场的期权行情订单簿应答</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnSubscribeAllOptionOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>退订全市场的期权行情订单簿应答</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnUnSubscribeAllOptionOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>订阅全市场的期权逐笔行情应答</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnSubscribeAllOptionTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>退订全市场的期权逐笔行情应答</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <param name="error_info">取消订阅合约时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <remarks>需要快速返回</remarks>
        public virtual void OnUnSubscribeAllOptionTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info)
        {
        }

        /// <summary>查询合约完整静态信息的应答</summary>
        /// <param name="ticker_info">合约完整静态信息</param>
        /// <param name="error_info">查询合约完整静态信息时发生错误时返回的错误信息，当error_info为空，或者error_info.error_id为0时，表明没有错误</param>
        /// <param name="is_last">是否此次查询合约完整静态信息的最后一个应答，当为最后一个的时候为true，如果为false，表示还有其他后续消息响应</param>
        public virtual void OnQueryAllTickersFullInfo(global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo ticker_info, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct error_info, bool is_last)
        {
        }

        #region Virtual table interop

        // void OnDisconnected(int reason) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_int _OnDisconnectedDelegateInstance;

        private static void _OnDisconnectedDelegateHook(global::System.IntPtr __instance, int reason)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.OnDisconnected(reason);
        }

        // void OnError(XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr _OnErrorDelegateInstance;

        private static void _OnErrorDelegateHook(global::System.IntPtr __instance, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result0;
            if (error_info == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnError(__result0);
        }

        // void OnSubMarketData(XTPST *ticker, XTPRI *error_info, bool is_last) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr_IntPtr_bool _OnSubMarketDataDelegateInstance;

        private static void _OnSubMarketDataDelegateHook(global::System.IntPtr __instance, global::System.IntPtr ticker, global::System.IntPtr error_info, bool is_last)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct __result0;
            if (ticker == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap.ContainsKey(ticker))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct)global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap[ticker];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__CreateInstance(ticker);
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnSubMarketData(__result0, __result1, is_last);
        }

        // void OnUnSubMarketData(XTPST *ticker, XTPRI *error_info, bool is_last) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr_IntPtr_bool _OnUnSubMarketDataDelegateInstance;

        private static void _OnUnSubMarketDataDelegateHook(global::System.IntPtr __instance, global::System.IntPtr ticker, global::System.IntPtr error_info, bool is_last)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct __result0;
            if (ticker == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap.ContainsKey(ticker))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct)global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap[ticker];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__CreateInstance(ticker);
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnUnSubMarketData(__result0, __result1, is_last);
        }

        // void OnDepthMarketData(XTPMD *market_data, int64_t bid1_qty[], int32_t bid1_count, int32_t max_bid1_count, int64_t ask1_qty[], int32_t ask1_count, int32_t max_ask1_count) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr_longArray_int_int_longArray_int_int _OnDepthMarketDataDelegateInstance;

        private static void _OnDepthMarketDataDelegateHook(global::System.IntPtr __instance, global::System.IntPtr market_data, long[] bid1_qty, int bid1_count, int max_bid1_count, long[] ask1_qty, int ask1_count, int max_ask1_count)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPMarketDataStruct __result0;
            if (market_data == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.NativeToManagedMap.ContainsKey(market_data))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPMarketDataStruct)global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.NativeToManagedMap[market_data];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__CreateInstance(market_data);
            __target.OnDepthMarketData(__result0, bid1_qty, bid1_count, max_bid1_count, ask1_qty, ask1_count, max_ask1_count);
        }

        // void OnSubOrderBook(XTPST *ticker, XTPRI *error_info, bool is_last) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr_IntPtr_bool _OnSubOrderBookDelegateInstance;

        private static void _OnSubOrderBookDelegateHook(global::System.IntPtr __instance, global::System.IntPtr ticker, global::System.IntPtr error_info, bool is_last)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct __result0;
            if (ticker == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap.ContainsKey(ticker))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct)global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap[ticker];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__CreateInstance(ticker);
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnSubOrderBook(__result0, __result1, is_last);
        }

        // void OnUnSubOrderBook(XTPST *ticker, XTPRI *error_info, bool is_last) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr_IntPtr_bool _OnUnSubOrderBookDelegateInstance;

        private static void _OnUnSubOrderBookDelegateHook(global::System.IntPtr __instance, global::System.IntPtr ticker, global::System.IntPtr error_info, bool is_last)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct __result0;
            if (ticker == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap.ContainsKey(ticker))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct)global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap[ticker];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__CreateInstance(ticker);
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnUnSubOrderBook(__result0, __result1, is_last);
        }

        // void OnOrderBook(XTPOB *order_book) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr _OnOrderBookDelegateInstance;

        private static void _OnOrderBookDelegateHook(global::System.IntPtr __instance, global::System.IntPtr order_book)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.OrderBookStruct __result0;
            if (order_book == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.OrderBookStruct.NativeToManagedMap.ContainsKey(order_book))
                __result0 = (global::QuantCSharp.ProxyXTP.OrderBookStruct)global::QuantCSharp.ProxyXTP.OrderBookStruct.NativeToManagedMap[order_book];
            else __result0 = global::QuantCSharp.ProxyXTP.OrderBookStruct.__CreateInstance(order_book);
            __target.OnOrderBook(__result0);
        }

        // void OnSubTickByTick(XTPST *ticker, XTPRI *error_info, bool is_last) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr_IntPtr_bool _OnSubTickByTickDelegateInstance;

        private static void _OnSubTickByTickDelegateHook(global::System.IntPtr __instance, global::System.IntPtr ticker, global::System.IntPtr error_info, bool is_last)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct __result0;
            if (ticker == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap.ContainsKey(ticker))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct)global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap[ticker];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__CreateInstance(ticker);
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnSubTickByTick(__result0, __result1, is_last);
        }

        // void OnUnSubTickByTick(XTPST *ticker, XTPRI *error_info, bool is_last) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr_IntPtr_bool _OnUnSubTickByTickDelegateInstance;

        private static void _OnUnSubTickByTickDelegateHook(global::System.IntPtr __instance, global::System.IntPtr ticker, global::System.IntPtr error_info, bool is_last)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct __result0;
            if (ticker == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap.ContainsKey(ticker))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct)global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.NativeToManagedMap[ticker];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__CreateInstance(ticker);
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnUnSubTickByTick(__result0, __result1, is_last);
        }

        // void OnTickByTick(XTPTBT *tbt_data) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr _OnTickByTickDelegateInstance;

        private static void _OnTickByTickDelegateHook(global::System.IntPtr __instance, global::System.IntPtr tbt_data)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPTickByTickStruct __result0;
            if (tbt_data == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.NativeToManagedMap.ContainsKey(tbt_data))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPTickByTickStruct)global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.NativeToManagedMap[tbt_data];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__CreateInstance(tbt_data);
            __target.OnTickByTick(__result0);
        }

        // void OnSubscribeAllMarketData(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnSubscribeAllMarketDataDelegateInstance;

        private static void _OnSubscribeAllMarketDataDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnSubscribeAllMarketData(exchange_id, __result1);
        }

        // void OnUnSubscribeAllMarketData(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnUnSubscribeAllMarketDataDelegateInstance;

        private static void _OnUnSubscribeAllMarketDataDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnUnSubscribeAllMarketData(exchange_id, __result1);
        }

        // void OnSubscribeAllOrderBook(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnSubscribeAllOrderBookDelegateInstance;

        private static void _OnSubscribeAllOrderBookDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnSubscribeAllOrderBook(exchange_id, __result1);
        }

        // void OnUnSubscribeAllOrderBook(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnUnSubscribeAllOrderBookDelegateInstance;

        private static void _OnUnSubscribeAllOrderBookDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnUnSubscribeAllOrderBook(exchange_id, __result1);
        }

        // void OnSubscribeAllTickByTick(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnSubscribeAllTickByTickDelegateInstance;

        private static void _OnSubscribeAllTickByTickDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnSubscribeAllTickByTick(exchange_id, __result1);
        }

        // void OnUnSubscribeAllTickByTick(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnUnSubscribeAllTickByTickDelegateInstance;

        private static void _OnUnSubscribeAllTickByTickDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnUnSubscribeAllTickByTick(exchange_id, __result1);
        }

        // void OnQueryAllTickers(XTPQSI* ticker_info, XTPRI *error_info, bool is_last) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr_IntPtr_bool _OnQueryAllTickersDelegateInstance;

        private static void _OnQueryAllTickersDelegateHook(global::System.IntPtr __instance, global::System.IntPtr ticker_info, global::System.IntPtr error_info, bool is_last)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo __result0;
            if (ticker_info == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.NativeToManagedMap.ContainsKey(ticker_info))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo)global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.NativeToManagedMap[ticker_info];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__CreateInstance(ticker_info);
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnQueryAllTickers(__result0, __result1, is_last);
        }

        // void OnQueryTickersPriceInfo(XTPTPI* ticker_info, XTPRI *error_info, bool is_last) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr_IntPtr_bool _OnQueryTickersPriceInfoDelegateInstance;

        private static void _OnQueryTickersPriceInfoDelegateHook(global::System.IntPtr __instance, global::System.IntPtr ticker_info, global::System.IntPtr error_info, bool is_last)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo __result0;
            if (ticker_info == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.NativeToManagedMap.ContainsKey(ticker_info))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo)global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.NativeToManagedMap[ticker_info];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__CreateInstance(ticker_info);
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnQueryTickersPriceInfo(__result0, __result1, is_last);
        }

        // void OnSubscribeAllOptionMarketData(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnSubscribeAllOptionMarketDataDelegateInstance;

        private static void _OnSubscribeAllOptionMarketDataDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnSubscribeAllOptionMarketData(exchange_id, __result1);
        }

        // void OnUnSubscribeAllOptionMarketData(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnUnSubscribeAllOptionMarketDataDelegateInstance;

        private static void _OnUnSubscribeAllOptionMarketDataDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnUnSubscribeAllOptionMarketData(exchange_id, __result1);
        }

        // void OnSubscribeAllOptionOrderBook(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnSubscribeAllOptionOrderBookDelegateInstance;

        private static void _OnSubscribeAllOptionOrderBookDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnSubscribeAllOptionOrderBook(exchange_id, __result1);
        }

        // void OnUnSubscribeAllOptionOrderBook(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnUnSubscribeAllOptionOrderBookDelegateInstance;

        private static void _OnUnSubscribeAllOptionOrderBookDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnUnSubscribeAllOptionOrderBook(exchange_id, __result1);
        }

        // void OnSubscribeAllOptionTickByTick(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnSubscribeAllOptionTickByTickDelegateInstance;

        private static void _OnSubscribeAllOptionTickByTickDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnSubscribeAllOptionTickByTick(exchange_id, __result1);
        }

        // void OnUnSubscribeAllOptionTickByTick(XTP_EXCHANGE_TYPE exchange_id, XTPRI *error_info) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_EXCHANGE_TYPE_IntPtr _OnUnSubscribeAllOptionTickByTickDelegateInstance;

        private static void _OnUnSubscribeAllOptionTickByTickDelegateHook(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id, global::System.IntPtr error_info)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnUnSubscribeAllOptionTickByTick(exchange_id, __result1);
        }

        // void OnQueryAllTickersFullInfo(XTPQFI* ticker_info, XTPRI *error_info, bool is_last) {}
        private static global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr_IntPtr_bool _OnQueryAllTickersFullInfoDelegateInstance;

        private static void _OnQueryAllTickersFullInfoDelegateHook(global::System.IntPtr __instance, global::System.IntPtr ticker_info, global::System.IntPtr error_info, bool is_last)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::QuantCSharp.ProxyXTP.QuoteSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo __result0;
            if (ticker_info == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.NativeToManagedMap.ContainsKey(ticker_info))
                __result0 = (global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo)global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.NativeToManagedMap[ticker_info];
            else __result0 = global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__CreateInstance(ticker_info);
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result1;
            if (error_info == IntPtr.Zero) __result1 = null;
            else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(error_info))
                __result1 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[error_info];
            else __result1 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(error_info);
            __target.OnQueryAllTickersFullInfo(__result0, __result1, is_last);
        }

        private static void*[] __ManagedVTables;
        private static void*[] _Thunks;

        private void SetupVTables(bool destructorOnly = false)
        {
            if (__OriginalVTables != null)
                return;
            __OriginalVTables = new void*[] { *(void**)(__Instance + 0) };

            if (destructorOnly)
                return;
            if (_Thunks == null)
            {
                _Thunks = new void*[26];
                _OnDisconnectedDelegateInstance += _OnDisconnectedDelegateHook;
                _Thunks[0] = CMarshal.GetFunctionPointerForDelegate(_OnDisconnectedDelegateInstance).ToPointer();
                _OnErrorDelegateInstance += _OnErrorDelegateHook;
                _Thunks[1] = CMarshal.GetFunctionPointerForDelegate(_OnErrorDelegateInstance).ToPointer();
                _OnSubMarketDataDelegateInstance += _OnSubMarketDataDelegateHook;
                _Thunks[2] = CMarshal.GetFunctionPointerForDelegate(_OnSubMarketDataDelegateInstance).ToPointer();
                _OnUnSubMarketDataDelegateInstance += _OnUnSubMarketDataDelegateHook;
                _Thunks[3] = CMarshal.GetFunctionPointerForDelegate(_OnUnSubMarketDataDelegateInstance).ToPointer();
                _OnDepthMarketDataDelegateInstance += _OnDepthMarketDataDelegateHook;
                _Thunks[4] = CMarshal.GetFunctionPointerForDelegate(_OnDepthMarketDataDelegateInstance).ToPointer();
                _OnSubOrderBookDelegateInstance += _OnSubOrderBookDelegateHook;
                _Thunks[5] = CMarshal.GetFunctionPointerForDelegate(_OnSubOrderBookDelegateInstance).ToPointer();
                _OnUnSubOrderBookDelegateInstance += _OnUnSubOrderBookDelegateHook;
                _Thunks[6] = CMarshal.GetFunctionPointerForDelegate(_OnUnSubOrderBookDelegateInstance).ToPointer();
                _OnOrderBookDelegateInstance += _OnOrderBookDelegateHook;
                _Thunks[7] = CMarshal.GetFunctionPointerForDelegate(_OnOrderBookDelegateInstance).ToPointer();
                _OnSubTickByTickDelegateInstance += _OnSubTickByTickDelegateHook;
                _Thunks[8] = CMarshal.GetFunctionPointerForDelegate(_OnSubTickByTickDelegateInstance).ToPointer();
                _OnUnSubTickByTickDelegateInstance += _OnUnSubTickByTickDelegateHook;
                _Thunks[9] = CMarshal.GetFunctionPointerForDelegate(_OnUnSubTickByTickDelegateInstance).ToPointer();
                _OnTickByTickDelegateInstance += _OnTickByTickDelegateHook;
                _Thunks[10] = CMarshal.GetFunctionPointerForDelegate(_OnTickByTickDelegateInstance).ToPointer();
                _OnSubscribeAllMarketDataDelegateInstance += _OnSubscribeAllMarketDataDelegateHook;
                _Thunks[11] = CMarshal.GetFunctionPointerForDelegate(_OnSubscribeAllMarketDataDelegateInstance).ToPointer();
                _OnUnSubscribeAllMarketDataDelegateInstance += _OnUnSubscribeAllMarketDataDelegateHook;
                _Thunks[12] = CMarshal.GetFunctionPointerForDelegate(_OnUnSubscribeAllMarketDataDelegateInstance).ToPointer();
                _OnSubscribeAllOrderBookDelegateInstance += _OnSubscribeAllOrderBookDelegateHook;
                _Thunks[13] = CMarshal.GetFunctionPointerForDelegate(_OnSubscribeAllOrderBookDelegateInstance).ToPointer();
                _OnUnSubscribeAllOrderBookDelegateInstance += _OnUnSubscribeAllOrderBookDelegateHook;
                _Thunks[14] = CMarshal.GetFunctionPointerForDelegate(_OnUnSubscribeAllOrderBookDelegateInstance).ToPointer();
                _OnSubscribeAllTickByTickDelegateInstance += _OnSubscribeAllTickByTickDelegateHook;
                _Thunks[15] = CMarshal.GetFunctionPointerForDelegate(_OnSubscribeAllTickByTickDelegateInstance).ToPointer();
                _OnUnSubscribeAllTickByTickDelegateInstance += _OnUnSubscribeAllTickByTickDelegateHook;
                _Thunks[16] = CMarshal.GetFunctionPointerForDelegate(_OnUnSubscribeAllTickByTickDelegateInstance).ToPointer();
                _OnQueryAllTickersDelegateInstance += _OnQueryAllTickersDelegateHook;
                _Thunks[17] = CMarshal.GetFunctionPointerForDelegate(_OnQueryAllTickersDelegateInstance).ToPointer();
                _OnQueryTickersPriceInfoDelegateInstance += _OnQueryTickersPriceInfoDelegateHook;
                _Thunks[18] = CMarshal.GetFunctionPointerForDelegate(_OnQueryTickersPriceInfoDelegateInstance).ToPointer();
                _OnSubscribeAllOptionMarketDataDelegateInstance += _OnSubscribeAllOptionMarketDataDelegateHook;
                _Thunks[19] = CMarshal.GetFunctionPointerForDelegate(_OnSubscribeAllOptionMarketDataDelegateInstance).ToPointer();
                _OnUnSubscribeAllOptionMarketDataDelegateInstance += _OnUnSubscribeAllOptionMarketDataDelegateHook;
                _Thunks[20] = CMarshal.GetFunctionPointerForDelegate(_OnUnSubscribeAllOptionMarketDataDelegateInstance).ToPointer();
                _OnSubscribeAllOptionOrderBookDelegateInstance += _OnSubscribeAllOptionOrderBookDelegateHook;
                _Thunks[21] = CMarshal.GetFunctionPointerForDelegate(_OnSubscribeAllOptionOrderBookDelegateInstance).ToPointer();
                _OnUnSubscribeAllOptionOrderBookDelegateInstance += _OnUnSubscribeAllOptionOrderBookDelegateHook;
                _Thunks[22] = CMarshal.GetFunctionPointerForDelegate(_OnUnSubscribeAllOptionOrderBookDelegateInstance).ToPointer();
                _OnSubscribeAllOptionTickByTickDelegateInstance += _OnSubscribeAllOptionTickByTickDelegateHook;
                _Thunks[23] = CMarshal.GetFunctionPointerForDelegate(_OnSubscribeAllOptionTickByTickDelegateInstance).ToPointer();
                _OnUnSubscribeAllOptionTickByTickDelegateInstance += _OnUnSubscribeAllOptionTickByTickDelegateHook;
                _Thunks[24] = CMarshal.GetFunctionPointerForDelegate(_OnUnSubscribeAllOptionTickByTickDelegateInstance).ToPointer();
                _OnQueryAllTickersFullInfoDelegateInstance += _OnQueryAllTickersFullInfoDelegateHook;
                _Thunks[25] = CMarshal.GetFunctionPointerForDelegate(_OnQueryAllTickersFullInfoDelegateInstance).ToPointer();
            }

            if (__ManagedVTables == null)
            {
                __ManagedVTables = new void*[1];
                var vfptr0 = CMarshal.AllocHGlobal(26 * 8);
                __ManagedVTables[0] = vfptr0.ToPointer();
                *(void**)(vfptr0 + 0) = _Thunks[0];
                *(void**)(vfptr0 + 8) = _Thunks[1];
                *(void**)(vfptr0 + 16) = _Thunks[2];
                *(void**)(vfptr0 + 24) = _Thunks[3];
                *(void**)(vfptr0 + 32) = _Thunks[4];
                *(void**)(vfptr0 + 40) = _Thunks[5];
                *(void**)(vfptr0 + 48) = _Thunks[6];
                *(void**)(vfptr0 + 56) = _Thunks[7];
                *(void**)(vfptr0 + 64) = _Thunks[8];
                *(void**)(vfptr0 + 72) = _Thunks[9];
                *(void**)(vfptr0 + 80) = _Thunks[10];
                *(void**)(vfptr0 + 88) = _Thunks[11];
                *(void**)(vfptr0 + 96) = _Thunks[12];
                *(void**)(vfptr0 + 104) = _Thunks[13];
                *(void**)(vfptr0 + 112) = _Thunks[14];
                *(void**)(vfptr0 + 120) = _Thunks[15];
                *(void**)(vfptr0 + 128) = _Thunks[16];
                *(void**)(vfptr0 + 136) = _Thunks[17];
                *(void**)(vfptr0 + 144) = _Thunks[18];
                *(void**)(vfptr0 + 152) = _Thunks[19];
                *(void**)(vfptr0 + 160) = _Thunks[20];
                *(void**)(vfptr0 + 168) = _Thunks[21];
                *(void**)(vfptr0 + 176) = _Thunks[22];
                *(void**)(vfptr0 + 184) = _Thunks[23];
                *(void**)(vfptr0 + 192) = _Thunks[24];
                *(void**)(vfptr0 + 200) = _Thunks[25];
            }

            *(void**)(__Instance + 0) = __ManagedVTables[0];
        }

        #endregion
    }

    public unsafe abstract partial class QuoteApi : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.QuoteApi> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.QuoteApi>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.QuoteApi __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.QuoteApiInternal(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.QuoteApi __CreateInstance(global::QuantCSharp.ProxyXTP.QuoteApi.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.QuoteApiInternal(native, skipVTables);
        }

        protected QuoteApi(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
            __OriginalVTables = new void*[] { *(void**)(__Instance + 0) };
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.QuoteApi __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::QuantCSharp.ProxyXTP.QuoteApi.__Internal*)__Instance)->vfptr_QuoteApi = new global::System.IntPtr(__OriginalVTables[0]);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>删除接口对象本身</summary>
        /// <remarks>不再使用本接口对象时,调用该函数删除接口对象</remarks>
        public abstract void Release();

        /// <summary>设置采用UDP方式连接时的接收缓冲区大小</summary>
        /// <remarks>需要在Login之前调用，默认大小和最小设置均为64MB。此缓存大小单位为MB，请输入2的次方数，例如128MB请输入128。</remarks>
        public abstract void SetUDPBufferSize(uint buff_size);

        /// <summary>注册回调接口</summary>
        /// <param name="spi">派生自回调接口类的实例，请在登录之前设定</param>
        public abstract void RegisterSpi(global::QuantCSharp.ProxyXTP.QuoteSpi spi);

        /// <summary>设置心跳检测时间间隔，单位为秒</summary>
        /// <param name="interval">心跳检测时间间隔，单位为秒</param>
        /// <remarks>此函数必须在Login之前调用</remarks>
        public abstract void SetHeartBeatInterval(uint interval);

        /// <summary>使用UDP接收行情时，设置接收行情线程绑定的cpu</summary>
        /// <param name="cpu_no">设置绑定的cpu，例如绑定cpu 0，可以设置0，绑定cpu 2，可以设置2，建议绑定后面的cpu</param>
        /// <remarks>此函数可不调用，如果调用则必须在Login之前调用，否则不会生效</remarks>
        public abstract void SetUDPRecvThreadAffinity(int cpu_no);

        /// <summary>使用UDP接收行情时，设置解析行情线程绑定的cpu</summary>
        /// <param name="cpu_no">设置绑定的cpu，例如绑定cpu 0，可以设置0，绑定cpu 2，可以设置2，建议绑定后面的cpu</param>
        /// <remarks>此函数可不调用，如果调用则必须在Login之前调用，否则不会生效</remarks>
        public abstract void SetUDPParseThreadAffinity(int cpu_no);

        /// <summary>设定UDP收行情时是否输出异步日志</summary>
        /// <param name="flag">是否输出标识，默认为true，如果不想输出“udpseq”开头的异步日志，请设置此参数为false</param>
        /// <remarks>此函数可不调用，如果调用则必须在Login之前调用，否则不会生效</remarks>
        public abstract void SetUDPSeqLogOutPutFlag(bool flag);

        /// <summary>订阅行情，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>订阅接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性订阅同一证券交易所的多个合约，无论用户因为何种问题需要重新登录行情服务器，都需要重新订阅行情</remarks>
        public abstract int SubscribeMarketData(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>退订行情，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>取消订阅接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性取消订阅同一证券交易所的多个合约，需要与订阅行情接口配套使用</remarks>
        public abstract int UnSubscribeMarketData(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>订阅行情订单簿，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情订单簿的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>订阅行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性订阅同一证券交易所的多个合约，无论用户因为何种问题需要重新登录行情服务器，都需要重新订阅行情(仅支持深交所)</remarks>
        public abstract int SubscribeOrderBook(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>退订行情订单簿，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情订单簿的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>取消订阅行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性取消订阅同一证券交易所的多个合约，需要与订阅行情订单簿接口配套使用</remarks>
        public abstract int UnSubscribeOrderBook(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>订阅逐笔行情，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情订单簿的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>订阅逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性订阅同一证券交易所的多个合约，无论用户因为何种问题需要重新登录行情服务器，都需要重新订阅行情</remarks>
        public abstract int SubscribeTickByTick(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>退订逐笔行情，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情订单簿的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>取消订阅逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性取消订阅同一证券交易所的多个合约，需要与订阅逐笔行情接口配套使用</remarks>
        public abstract int UnSubscribeTickByTick(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>订阅全市场的股票行情</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市场行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订行情接口配套使用</remarks>
        public abstract int SubscribeAllMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>退订全市场的股票行情</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场行情接口配套使用</remarks>
        public abstract int UnSubscribeAllMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>订阅全市场的股票行情订单簿</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市场行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订行情订单簿接口配套使用</remarks>
        public abstract int SubscribeAllOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>退订全市场的股票行情订单簿</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场行情订单簿接口配套使用</remarks>
        public abstract int UnSubscribeAllOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>订阅全市场的股票逐笔行情</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市场逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订逐笔行情接口配套使用</remarks>
        public abstract int SubscribeAllTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>退订全市场的股票逐笔行情</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场逐笔行情接口配套使用</remarks>
        public abstract int UnSubscribeAllTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>用户登录请求</summary>
        /// <param name="ip">服务器ip地址，类似“127.0.0.1”</param>
        /// <param name="port">服务器端口号</param>
        /// <param name="user">登陆用户名</param>
        /// <param name="password">登陆密码</param>
        /// <param name="sock_type">“1”代表TCP，“2”代表UDP</param>
        /// <param name="local_ip">本地网卡地址，类似“127.0.0.1”</param>
        /// <returns>登录是否成功，“0”表示登录成功，“-1”表示连接服务器出错，此时用户可以调用GetApiLastError()来获取错误代码，“-2”表示已存在连接，不允许重复登录，如果需要重连，请先logout，“-3”表示输入有错误</returns>
        /// <remarks>此函数为同步阻塞式，不需要异步等待登录成功，当函数返回即可进行后续操作，此api只能有一个连接</remarks>
        public abstract int Login(string ip, int port, string user, string password, global::QuantCSharp.ProxyXTP.XTP_PROTOCOL_TYPE sock_type, string local_ip);

        /// <summary>获取当前交易日合约部分静态信息</summary>
        /// <param name="exchange_id">交易所代码，必须提供 1-上海 2-深圳</param>
        /// <returns>发送查询请求是否成功，“0”表示发送查询请求成功，非“0”表示发送查询请求不成功</returns>
        public abstract int QueryAllTickers(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>获取合约的最新价格信息</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要查询的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>发送查询请求是否成功，“0”表示发送查询请求成功，非“0”表示发送查询请求不成功</returns>
        public abstract int QueryTickersPriceInfo(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>订阅全市场的期权行情</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市期权场行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订期权行情接口配套使用</remarks>
        public abstract int SubscribeAllOptionMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>退订全市场的期权行情</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场期权行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场期权行情接口配套使用</remarks>
        public abstract int UnSubscribeAllOptionMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>订阅全市场的期权行情订单簿</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市场期权行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订期权行情订单簿接口配套使用</remarks>
        public abstract int SubscribeAllOptionOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>退订全市场的期权行情订单簿</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场期权行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场期权行情订单簿接口配套使用</remarks>
        public abstract int UnSubscribeAllOptionOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>订阅全市场的期权逐笔行情</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市场期权逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订期权逐笔行情接口配套使用</remarks>
        public abstract int SubscribeAllOptionTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>退订全市场的期权逐笔行情</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场期权逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场期权逐笔行情接口配套使用</remarks>
        public abstract int UnSubscribeAllOptionTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>获取所有合约的详细静态信息，包括指数等非可交易的</summary>
        /// <param name="exchange_id">交易所代码，必须提供 1-上海 2-深圳</param>
        /// <returns>发送查询请求是否成功，“0”表示发送查询请求成功，非“0”表示发送查询请求不成功</returns>
        public abstract int QueryAllTickersFullInfo(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id);

        /// <summary>创建QuoteApi</summary>
        /// <param name="client_id">（必须输入）用于区分同一用户的不同客户端，由用户自定义</param>
        /// <param name="save_file_path">（必须输入）存贮订阅信息文件的目录，请设定一个有可写权限的真实存在的路径，如果路径不存在的话，可能会因为写冲突而造成断线</param>
        /// <param name="log_level">日志输出级别</param>
        /// <returns>创建出的UserApi</returns>
        /// <remarks>如果一个账户需要在多个客户端登录，请使用不同的client_id，系统允许一个账户同时登录多个客户端，但是对于同一账户，相同的client_id只能保持一个session连接，后面的登录在前一个session存续期间，无法连接</remarks>
        public static global::QuantCSharp.ProxyXTP.QuoteApi CreateQuoteApi(byte client_id, string save_file_path, global::QuantCSharp.ProxyXTP.XTP_LOG_LEVEL log_level)
        {
            var __ret = __Internal.CreateQuoteApi(client_id, save_file_path, log_level);
            global::QuantCSharp.ProxyXTP.QuoteApi __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::QuantCSharp.ProxyXTP.QuoteApi.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::QuantCSharp.ProxyXTP.QuoteApi)global::QuantCSharp.ProxyXTP.QuoteApi.NativeToManagedMap[__ret];
            else __result0 = global::QuantCSharp.ProxyXTP.QuoteApi.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>获取当前交易日</summary>
        /// <returns>获取到的交易日</returns>
        /// <remarks>只有登录成功后,才能得到正确的交易日</remarks>
        public abstract string TradingDay
        {
            get;
        }

        /// <summary>获取API的发行版本号</summary>
        /// <returns>返回api发行版本号</returns>
        public abstract string ApiVersion
        {
            get;
        }

        /// <summary>获取API的系统错误</summary>
        /// <returns>返回的错误信息，可以在Login、Logout、订阅、取消订阅失败时调用，获取失败的原因</returns>
        /// <remarks>可以在调用api接口失败时调用，例如login失败时</remarks>
        public abstract global::QuantCSharp.ProxyXTP.XTPRspInfoStruct ApiLastError
        {
            get;
        }

        /// <summary>登出请求</summary>
        /// <returns>登出是否成功，“0”表示登出成功，非“0”表示登出出错，此时用户可以调用GetApiLastError()来获取错误代码</returns>
        /// <remarks>此函数为同步阻塞式，不需要异步等待登出，当函数返回即可进行后续操作</remarks>
        public abstract int Logout
        {
            get;
        }

        /// <summary>获取所有合约的最新价格信息</summary>
        /// <returns>发送查询请求是否成功，“0”表示发送查询请求成功，非“0”表示发送查询请求不成功</returns>
        public abstract int QueryAllTickersPriceInfo
        {
            get;
        }
    }

    public unsafe partial class QuoteApiInternal : global::QuantCSharp.ProxyXTP.QuoteApi, IDisposable
    {
        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.QuoteApi.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.QuoteApi.__Internal));
            *(global::QuantCSharp.ProxyXTP.QuoteApi.__Internal*)ret = native;
            return ret.ToPointer();
        }

        internal QuoteApiInternal(global::QuantCSharp.ProxyXTP.QuoteApi.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        internal QuoteApiInternal(void* native, bool skipVTables = false)
            : base((void*)null)
        {
            __Instance = new global::System.IntPtr(native);
            __OriginalVTables = new void*[] { *(void**)(__Instance + 0) };
        }

        /// <summary>删除接口对象本身</summary>
        /// <remarks>不再使用本接口对象时,调用该函数删除接口对象</remarks>
        public override void Release()
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 0 * 8);
            var ___ReleaseDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr));
            ___ReleaseDelegate(__Instance);
        }

        /// <summary>设置采用UDP方式连接时的接收缓冲区大小</summary>
        /// <remarks>需要在Login之前调用，默认大小和最小设置均为64MB。此缓存大小单位为MB，请输入2的次方数，例如128MB请输入128。</remarks>
        public override void SetUDPBufferSize(uint buff_size)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 4 * 8);
            var ___SetUDPBufferSizeDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_uint)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_uint));
            ___SetUDPBufferSizeDelegate(__Instance, buff_size);
        }

        /// <summary>注册回调接口</summary>
        /// <param name="spi">派生自回调接口类的实例，请在登录之前设定</param>
        public override void RegisterSpi(global::QuantCSharp.ProxyXTP.QuoteSpi spi)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 5 * 8);
            var ___RegisterSpiDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_IntPtr));
            var __arg0 = ReferenceEquals(spi, null) ? global::System.IntPtr.Zero : spi.__Instance;
            ___RegisterSpiDelegate(__Instance, __arg0);
        }

        /// <summary>设置心跳检测时间间隔，单位为秒</summary>
        /// <param name="interval">心跳检测时间间隔，单位为秒</param>
        /// <remarks>此函数必须在Login之前调用</remarks>
        public override void SetHeartBeatInterval(uint interval)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 6 * 8);
            var ___SetHeartBeatIntervalDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_uint)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_uint));
            ___SetHeartBeatIntervalDelegate(__Instance, interval);
        }

        /// <summary>使用UDP接收行情时，设置接收行情线程绑定的cpu</summary>
        /// <param name="cpu_no">设置绑定的cpu，例如绑定cpu 0，可以设置0，绑定cpu 2，可以设置2，建议绑定后面的cpu</param>
        /// <remarks>此函数可不调用，如果调用则必须在Login之前调用，否则不会生效</remarks>
        public override void SetUDPRecvThreadAffinity(int cpu_no)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 7 * 8);
            var ___SetUDPRecvThreadAffinityDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_int)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_int));
            ___SetUDPRecvThreadAffinityDelegate(__Instance, cpu_no);
        }

        /// <summary>使用UDP接收行情时，设置解析行情线程绑定的cpu</summary>
        /// <param name="cpu_no">设置绑定的cpu，例如绑定cpu 0，可以设置0，绑定cpu 2，可以设置2，建议绑定后面的cpu</param>
        /// <remarks>此函数可不调用，如果调用则必须在Login之前调用，否则不会生效</remarks>
        public override void SetUDPParseThreadAffinity(int cpu_no)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 8 * 8);
            var ___SetUDPParseThreadAffinityDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_int)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_int));
            ___SetUDPParseThreadAffinityDelegate(__Instance, cpu_no);
        }

        /// <summary>设定UDP收行情时是否输出异步日志</summary>
        /// <param name="flag">是否输出标识，默认为true，如果不想输出“udpseq”开头的异步日志，请设置此参数为false</param>
        /// <remarks>此函数可不调用，如果调用则必须在Login之前调用，否则不会生效</remarks>
        public override void SetUDPSeqLogOutPutFlag(bool flag)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 9 * 8);
            var ___SetUDPSeqLogOutPutFlagDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_bool)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Action_IntPtr_bool));
            ___SetUDPSeqLogOutPutFlagDelegate(__Instance, flag);
        }

        /// <summary>订阅行情，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>订阅接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性订阅同一证券交易所的多个合约，无论用户因为何种问题需要重新登录行情服务器，都需要重新订阅行情</remarks>
        public override int SubscribeMarketData(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 10 * 8);
            var ___SubscribeMarketDataDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE));
            var __ret = ___SubscribeMarketDataDelegate(__Instance, ticker, count, exchange_id);
            return __ret;
        }

        /// <summary>退订行情，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>取消订阅接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性取消订阅同一证券交易所的多个合约，需要与订阅行情接口配套使用</remarks>
        public override int UnSubscribeMarketData(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 11 * 8);
            var ___UnSubscribeMarketDataDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE));
            var __ret = ___UnSubscribeMarketDataDelegate(__Instance, ticker, count, exchange_id);
            return __ret;
        }

        /// <summary>订阅行情订单簿，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情订单簿的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>订阅行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性订阅同一证券交易所的多个合约，无论用户因为何种问题需要重新登录行情服务器，都需要重新订阅行情(仅支持深交所)</remarks>
        public override int SubscribeOrderBook(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 12 * 8);
            var ___SubscribeOrderBookDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE));
            var __ret = ___SubscribeOrderBookDelegate(__Instance, ticker, count, exchange_id);
            return __ret;
        }

        /// <summary>退订行情订单簿，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情订单簿的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>取消订阅行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性取消订阅同一证券交易所的多个合约，需要与订阅行情订单簿接口配套使用</remarks>
        public override int UnSubscribeOrderBook(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 13 * 8);
            var ___UnSubscribeOrderBookDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE));
            var __ret = ___UnSubscribeOrderBookDelegate(__Instance, ticker, count, exchange_id);
            return __ret;
        }

        /// <summary>订阅逐笔行情，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情订单簿的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>订阅逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性订阅同一证券交易所的多个合约，无论用户因为何种问题需要重新登录行情服务器，都需要重新订阅行情</remarks>
        public override int SubscribeTickByTick(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 14 * 8);
            var ___SubscribeTickByTickDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE));
            var __ret = ___SubscribeTickByTickDelegate(__Instance, ticker, count, exchange_id);
            return __ret;
        }

        /// <summary>退订逐笔行情，包括股票、指数和期权。</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要订阅/退订行情订单簿的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>取消订阅逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>可以一次性取消订阅同一证券交易所的多个合约，需要与订阅逐笔行情接口配套使用</remarks>
        public override int UnSubscribeTickByTick(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 15 * 8);
            var ___UnSubscribeTickByTickDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE));
            var __ret = ___UnSubscribeTickByTickDelegate(__Instance, ticker, count, exchange_id);
            return __ret;
        }

        /// <summary>订阅全市场的股票行情</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市场行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订行情接口配套使用</remarks>
        public override int SubscribeAllMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 16 * 8);
            var ___SubscribeAllMarketDataDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___SubscribeAllMarketDataDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>退订全市场的股票行情</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场行情接口配套使用</remarks>
        public override int UnSubscribeAllMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 17 * 8);
            var ___UnSubscribeAllMarketDataDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___UnSubscribeAllMarketDataDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>订阅全市场的股票行情订单簿</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市场行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订行情订单簿接口配套使用</remarks>
        public override int SubscribeAllOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 18 * 8);
            var ___SubscribeAllOrderBookDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___SubscribeAllOrderBookDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>退订全市场的股票行情订单簿</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场行情订单簿接口配套使用</remarks>
        public override int UnSubscribeAllOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 19 * 8);
            var ___UnSubscribeAllOrderBookDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___UnSubscribeAllOrderBookDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>订阅全市场的股票逐笔行情</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市场逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订逐笔行情接口配套使用</remarks>
        public override int SubscribeAllTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 20 * 8);
            var ___SubscribeAllTickByTickDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___SubscribeAllTickByTickDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>退订全市场的股票逐笔行情</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场逐笔行情接口配套使用</remarks>
        public override int UnSubscribeAllTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 21 * 8);
            var ___UnSubscribeAllTickByTickDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___UnSubscribeAllTickByTickDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>用户登录请求</summary>
        /// <param name="ip">服务器ip地址，类似“127.0.0.1”</param>
        /// <param name="port">服务器端口号</param>
        /// <param name="user">登陆用户名</param>
        /// <param name="password">登陆密码</param>
        /// <param name="sock_type">“1”代表TCP，“2”代表UDP</param>
        /// <param name="local_ip">本地网卡地址，类似“127.0.0.1”</param>
        /// <returns>登录是否成功，“0”表示登录成功，“-1”表示连接服务器出错，此时用户可以调用GetApiLastError()来获取错误代码，“-2”表示已存在连接，不允许重复登录，如果需要重连，请先logout，“-3”表示输入有错误</returns>
        /// <remarks>此函数为同步阻塞式，不需要异步等待登录成功，当函数返回即可进行后续操作，此api只能有一个连接</remarks>
        public override int Login(string ip, int port, string user, string password, global::QuantCSharp.ProxyXTP.XTP_PROTOCOL_TYPE sock_type, string local_ip)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 22 * 8);
            var ___LoginDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_string_int_string_string_Login)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_string_int_string_string_Login));
            var __ret = ___LoginDelegate(__Instance, ip, port, user, password, sock_type, local_ip);
            return __ret;
        }

        /// <summary>获取当前交易日合约部分静态信息</summary>
        /// <param name="exchange_id">交易所代码，必须提供 1-上海 2-深圳</param>
        /// <returns>发送查询请求是否成功，“0”表示发送查询请求成功，非“0”表示发送查询请求不成功</returns>
        public override int QueryAllTickers(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 24 * 8);
            var ___QueryAllTickersDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___QueryAllTickersDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>获取合约的最新价格信息</summary>
        /// <param name="ticker">合约ID数组，注意合约代码必须以'\0'结尾，不包含空格</param>
        /// <param name="count">要查询的合约个数</param>
        /// <param name="exchange_id">交易所代码</param>
        /// <returns>发送查询请求是否成功，“0”表示发送查询请求成功，非“0”表示发送查询请求不成功</returns>
        public override int QueryTickersPriceInfo(string[] ticker, int count, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 25 * 8);
            var ___QueryTickersPriceInfoDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE));
            var __ret = ___QueryTickersPriceInfoDelegate(__Instance, ticker, count, exchange_id);
            return __ret;
        }

        /// <summary>订阅全市场的期权行情</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市期权场行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订期权行情接口配套使用</remarks>
        public override int SubscribeAllOptionMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 27 * 8);
            var ___SubscribeAllOptionMarketDataDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___SubscribeAllOptionMarketDataDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>退订全市场的期权行情</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场期权行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场期权行情接口配套使用</remarks>
        public override int UnSubscribeAllOptionMarketData(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 28 * 8);
            var ___UnSubscribeAllOptionMarketDataDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___UnSubscribeAllOptionMarketDataDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>订阅全市场的期权行情订单簿</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市场期权行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订期权行情订单簿接口配套使用</remarks>
        public override int SubscribeAllOptionOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 29 * 8);
            var ___SubscribeAllOptionOrderBookDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___SubscribeAllOptionOrderBookDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>退订全市场的期权行情订单簿</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场期权行情订单簿接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场期权行情订单簿接口配套使用</remarks>
        public override int UnSubscribeAllOptionOrderBook(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 30 * 8);
            var ___UnSubscribeAllOptionOrderBookDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___UnSubscribeAllOptionOrderBookDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>订阅全市场的期权逐笔行情</summary>
        /// <param name="exchange_id">表示当前全订阅的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>订阅全市场期权逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与全市场退订期权逐笔行情接口配套使用</remarks>
        public override int SubscribeAllOptionTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 31 * 8);
            var ___SubscribeAllOptionTickByTickDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___SubscribeAllOptionTickByTickDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>退订全市场的期权逐笔行情</summary>
        /// <param name="exchange_id">表示当前退订的市场，如果为XTP_EXCHANGE_UNKNOWN，表示沪深全市场，XTP_EXCHANGE_SH表示为上海全市场，XTP_EXCHANGE_SZ表示为深圳全市场</param>
        /// <returns>退订全市场期权逐笔行情接口调用是否成功，“0”表示接口调用成功，非“0”表示接口调用出错</returns>
        /// <remarks>需要与订阅全市场期权逐笔行情接口配套使用</remarks>
        public override int UnSubscribeAllOptionTickByTick(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 32 * 8);
            var ___UnSubscribeAllOptionTickByTickDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___UnSubscribeAllOptionTickByTickDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>获取所有合约的详细静态信息，包括指数等非可交易的</summary>
        /// <param name="exchange_id">交易所代码，必须提供 1-上海 2-深圳</param>
        /// <returns>发送查询请求是否成功，“0”表示发送查询请求成功，非“0”表示发送查询请求不成功</returns>
        public override int QueryAllTickersFullInfo(global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 33 * 8);
            var ___QueryAllTickersFullInfoDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr_XTP_EXCHANGE_TYPE));
            var __ret = ___QueryAllTickersFullInfoDelegate(__Instance, exchange_id);
            return __ret;
        }

        /// <summary>获取当前交易日</summary>
        /// <returns>获取到的交易日</returns>
        /// <remarks>只有登录成功后,才能得到正确的交易日</remarks>
        public override string TradingDay
        {
            get
            {
                var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 1 * 8);
                var ___GetTradingDayDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_IntPtr_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_IntPtr_IntPtr));
                var __ret = ___GetTradingDayDelegate(__Instance);
                if (__ret == global::System.IntPtr.Zero)
                    return default(string);
                var __retPtr = (byte*)__ret;
                int __length = 0;
                while (*(__retPtr++) != 0) __length += sizeof(byte);
                return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
            }
        }

        /// <summary>获取API的发行版本号</summary>
        /// <returns>返回api发行版本号</returns>
        public override string ApiVersion
        {
            get
            {
                var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 2 * 8);
                var ___GetApiVersionDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_IntPtr_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_IntPtr_IntPtr));
                var __ret = ___GetApiVersionDelegate(__Instance);
                if (__ret == global::System.IntPtr.Zero)
                    return default(string);
                var __retPtr = (byte*)__ret;
                int __length = 0;
                while (*(__retPtr++) != 0) __length += sizeof(byte);
                return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
            }
        }

        /// <summary>获取API的系统错误</summary>
        /// <returns>返回的错误信息，可以在Login、Logout、订阅、取消订阅失败时调用，获取失败的原因</returns>
        /// <remarks>可以在调用api接口失败时调用，例如login失败时</remarks>
        public override global::QuantCSharp.ProxyXTP.XTPRspInfoStruct ApiLastError
        {
            get
            {
                var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 3 * 8);
                var ___GetApiLastErrorDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_IntPtr_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_IntPtr_IntPtr));
                var __ret = ___GetApiLastErrorDelegate(__Instance);
                global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::QuantCSharp.ProxyXTP.XTPRspInfoStruct)global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.NativeToManagedMap[__ret];
                else __result0 = global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__CreateInstance(__ret);
                return __result0;
            }
        }

        /// <summary>登出请求</summary>
        /// <returns>登出是否成功，“0”表示登出成功，非“0”表示登出出错，此时用户可以调用GetApiLastError()来获取错误代码</returns>
        /// <remarks>此函数为同步阻塞式，不需要异步等待登出，当函数返回即可进行后续操作</remarks>
        public override int Logout
        {
            get
            {
                var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 23 * 8);
                var ___LogoutDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr));
                var __ret = ___LogoutDelegate(__Instance);
                return __ret;
            }
        }

        /// <summary>获取所有合约的最新价格信息</summary>
        /// <returns>发送查询请求是否成功，“0”表示发送查询请求成功，非“0”表示发送查询请求不成功</returns>
        public override int QueryAllTickersPriceInfo
        {
            get
            {
                var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 26 * 8);
                var ___QueryAllTickersPriceInfoDelegate = (global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::QuantCSharp.ProxyXTP.Delegates.Func_int_IntPtr));
                var __ret = ___QueryAllTickersPriceInfoDelegate(__Instance);
                return __ret;
            }
        }
    }
   
}

