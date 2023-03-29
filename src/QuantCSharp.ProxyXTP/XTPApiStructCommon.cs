using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

namespace QuantCSharp.ProxyXTP
{
    /// <summary>响应信息</summary>
    /// <summary>响应信息</summary>
    public unsafe partial class XTPRspInfoStruct : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 128)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int error_id;

            [FieldOffset(4)]
            internal fixed sbyte error_msg[124];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPRspInfoStruct@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPRspInfoStruct>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPRspInfoStruct(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __CreateInstance(global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPRspInfoStruct(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPRspInfoStruct(global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPRspInfoStruct(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPRspInfoStruct()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPRspInfoStruct(global::QuantCSharp.ProxyXTP.XTPRspInfoStruct _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPRspInfoStruct __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int ErrorId
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal*)__Instance)->error_id;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal*)__Instance)->error_id = value;
            }
        }

        public sbyte[] ErrorMsg
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal*)__Instance)->error_msg != null)
                {
                    __value = new sbyte[124];
                    for (int i = 0; i < 124; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal*)__Instance)->error_msg[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 124; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPRspInfoStruct.__Internal*)__Instance)->error_msg[i] = value[i];
                }
            }
        }
    }

    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_LOG_LEVEL是日志输出级别类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    public enum XTP_LOG_LEVEL
    {
        /// <summary>严重错误级别</summary>
        XTP_LOG_LEVEL_FATAL = 0,
        /// <summary>错误级别</summary>
        XTP_LOG_LEVEL_ERROR = 1,
        /// <summary>警告级别</summary>
        XTP_LOG_LEVEL_WARNING = 2,
        /// <summary>info级别</summary>
        XTP_LOG_LEVEL_INFO = 3,
        /// <summary>debug级别</summary>
        XTP_LOG_LEVEL_DEBUG = 4,
        /// <summary>trace级别</summary>
        XTP_LOG_LEVEL_TRACE = 5
    }

    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_PROTOCOL_TYPE是通讯传输协议方式</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    public enum XTP_PROTOCOL_TYPE
    {
        /// <summary>采用TCP方式传输</summary>
        XTP_PROTOCOL_TCP = 1,
        /// <summary>采用UDP方式传输(仅行情接口支持)</summary>
        XTP_PROTOCOL_UDP = 2
    }

    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_EXCHANGE_TYPE是交易所类型，行情里使用</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    public enum XTP_EXCHANGE_TYPE
    {
        /// <summary>上证</summary>
        XTP_EXCHANGE_SH = 1,
        /// <summary>深证</summary>
        XTP_EXCHANGE_SZ = 2,
        /// <summary>不存在的交易所类型</summary>
        XTP_EXCHANGE_UNKNOWN = 3
    }

    /// <summary>///////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_MARKET_TYPE市场类型，交易里使用</para>
    /// <para>///////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    public enum XTP_MARKET_TYPE
    {
        /// <summary>初始化值或者未知</summary>
        XTP_MKT_INIT = 0,
        /// <summary>深圳A股</summary>
        XTP_MKT_SZ_A = 1,
        /// <summary>上海A股</summary>
        XTP_MKT_SH_A = 2,
        /// <summary>未知交易市场类型</summary>
        XTP_MKT_UNKNOWN = 3
    }
   
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_TE_RESUME_TYPE是公有流（订单响应、成交回报）重传方式</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    public enum XTP_TE_RESUME_TYPE
    {
        /// <summary>从本交易日开始重传</summary>
        XTP_TERT_RESTART = 0,
        /// <summary>从从上次收到的续传（暂未支持）</summary>
        XTP_TERT_RESUME = 1,
        /// <summary>只传送登录后公有流（订单响应、成交回报）的内容</summary>
        XTP_TERT_QUICK = 2
    }

    /// <summary>///////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_TICKER_TYPE证券类型</para>
    /// <para>///////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    public enum XTP_TICKER_TYPE
    {
        /// <summary>普通股票</summary>
        XTP_TICKER_TYPE_STOCK = 0,
        /// <summary>指数</summary>
        XTP_TICKER_TYPE_INDEX = 1,
        /// <summary>基金</summary>
        XTP_TICKER_TYPE_FUND = 2,
        /// <summary>债券</summary>
        XTP_TICKER_TYPE_BOND = 3,
        /// <summary>期权</summary>
        XTP_TICKER_TYPE_OPTION = 4,
        /// <summary>科创板股票（上海）</summary>
        XTP_TICKER_TYPE_TECH_STOCK = 5,
        /// <summary>未知类型</summary>
        XTP_TICKER_TYPE_UNKNOWN = 6
    }
   
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_TBT_TYPE是一个逐笔回报类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    public enum XTP_TBT_TYPE
    {
        /// <summary>逐笔委托</summary>
        XTP_TBT_ENTRUST = 1,
        /// <summary>逐笔成交</summary>
        XTP_TBT_TRADE = 2
    }
   
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_QUALIFICATION_TYPE是一个证券适当性枚举类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    public enum XTP_QUALIFICATION_TYPE
    {
        /// <summary>公众投资者，合格投资者与机构投资者均可</summary>
        XTP_QUALIFICATION_PUBLIC = 0,
        /// <summary>仅合格投资者与公众投资者</summary>
        XTP_QUALIFICATION_COMMON = 1,
        /// <summary>仅限机构投资者</summary>
        XTP_QUALIFICATION_ORGANIZATION = 2,
        /// <summary>未知，期权等可能为此种类型</summary>
        XTP_QUALIFICATION_UNKNOWN = 3
    }

    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_SECURITY_TYPE是一个证券详细分类枚举类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    public enum XTP_SECURITY_TYPE
    {
        /// <summary>主板股票</summary>
        XTP_SECURITY_MAIN_BOARD = 0,
        /// <summary>中小板股票</summary>
        XTP_SECURITY_SECOND_BOARD = 1,
        /// <summary>创业板股票</summary>
        XTP_SECURITY_STARTUP_BOARD = 2,
        /// <summary>指数</summary>
        XTP_SECURITY_INDEX = 3,
        /// <summary>科创板股票(上海)</summary>
        XTP_SECURITY_TECH_BOARD = 4,
        /// <summary>国债</summary>
        XTP_SECURITY_STATE_BOND = 5,
        /// <summary>企业债</summary>
        XTP_SECURITY_ENTERPRICE_BOND = 6,
        /// <summary>公司债</summary>
        XTP_SECURITY_COMPANEY_BOND = 7,
        /// <summary>转换债券</summary>
        XTP_SECURITY_CONVERTABLE_BOND = 8,
        /// <summary>国债逆回购</summary>
        XTP_SECURITY_NATIONAL_BOND_REVERSE_REPO = 12,
        /// <summary>本市场股票 ETF</summary>
        XTP_SECURITY_ETF_SINGLE_MARKET_STOCK = 14,
        /// <summary>跨市场股票 ETF</summary>
        XTP_SECURITY_ETF_INTER_MARKET_STOCK = 15,
        /// <summary>本市场实物债券 ETF</summary>
        XTP_SECURITY_ETF_SINGLE_MARKET_BOND = 17,
        /// <summary>黄金 ETF</summary>
        XTP_SECURITY_ETF_GOLD = 19,
        /// <summary>分级基金子基金</summary>
        XTP_SECURITY_STRUCTURED_FUND_CHILD = 24,
        /// <summary>深交所仅申赎基金</summary>
        XTP_SECURITY_SZSE_RECREATION_FUND = 26,
        /// <summary>个股期权</summary>
        XTP_SECURITY_STOCK_OPTION = 29,
        /// <summary>ETF期权</summary>
        XTP_SECURITY_ETF_OPTION = 30,
        /// <summary>配股</summary>
        XTP_SECURITY_ALLOTMENT = 100,
        /// <summary>上交所申赎型货币基金</summary>
        XTP_SECURITY_MONETARY_FUND_SHCR = 110,
        /// <summary>上交所交易型货币基金</summary>
        XTP_SECURITY_MONETARY_FUND_SHTR = 111,
        /// <summary>深交所货币基金</summary>
        XTP_SECURITY_MONETARY_FUND_SZ = 112,
        /// <summary>其他</summary>
        XTP_SECURITY_OTHERS = 255
    }

    /// <summary>版本号类型</summary>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_LOG_LEVEL是日志输出级别类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_PROTOCOL_TYPE是通讯传输协议方式</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_EXCHANGE_TYPE是交易所类型，行情里使用</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>///////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_MARKET_TYPE市场类型，交易里使用</para>
    /// <para>///////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_PRICE_TYPE是价格类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_SIDE_TYPE是买卖方向类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_POSITION_EFFECT_TYPE是开平标识类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_ORDER_ACTION_STATUS_TYPE是报单操作状态类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_ORDER_STATUS_TYPE是报单状态类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_ORDER_SUBMIT_STATUS_TYPE是报单提交状态类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_TE_RESUME_TYPE是公有流（订单响应、成交回报）重传方式</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>///////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>ETF_REPLACE_TYPE现金替代标识定义</para>
    /// <para>///////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>///////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_TICKER_TYPE证券类型</para>
    /// <para>///////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>///////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_BUSINESS_TYPE证券业务类型</para>
    /// <para>///////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>///////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_ACCOUNT_TYPE账户类型</para>
    /// <para>///////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_FUND_TRANSFER_TYPE是资金流转方向类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_FUND_OPER_STATUS柜台资金操作结果</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_DEBT_EXTEND_OPER_STATUS柜台负债展期操作状态</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_SPLIT_MERGE_STATUS是一个基金当天拆分合并状态类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_TBT_TYPE是一个逐笔回报类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_OPT_CALL_OR_PUT_TYPE是一个认沽或认购类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_OPT_EXERCISE_TYPE_TYPE是一个行权方式类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_POSITION_DIRECTION_TYPE是一个持仓方向类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_OPT_COVERED_OR_UNCOVERED是否备兑的标签</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_CRD_CASH_REPAY_STATUS是一个融资融券直接还款状态类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_OPT_POSITION_TYPE是一个期权持仓类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// <para>TXTPTradeTypeType是成交类型类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </summary>
    /// <summary>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// <para>TXTPOrderTypeType是报单类型类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </summary>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_EXPIRE_DATE_TYPE是一个期权组合策略合约到期日要求类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_UNDERLYING_TYPE是一个期权组合策略标的要求类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_AUTO_SPLIT_TYPE是一个期权组合策略自动解除枚举类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>行权价顺序类型， 从1开始，1表示行权价最高，2次之。如果行权价相同，则填写相同数字，用A表示行权价大于等于B，B大于等于C依次类推（C、D）</summary>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_QUALIFICATION_TYPE是一个证券适当性枚举类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_SECURITY_TYPE是一个证券详细分类枚举类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    /// <summary>//////////////////////////////////////////////////////////////////////</summary>
    /// <remarks>
    /// <para>XTP_MARKETDATA_TYPE是行情快照数据类型</para>
    /// <para>//////////////////////////////////////////////////////////////////////</para>
    /// </remarks>
    public enum XTP_MARKETDATA_TYPE
    {
        XTP_MARKETDATA_ACTUAL = 0,
        XTP_MARKETDATA_OPTION = 1
    }

    /// <summary>指定的合约</summary>
    /// <summary>行情</summary>
    /// <summary>股票行情静态信息</summary>
    /// <summary>定单薄</summary>
    /// <summary>逐笔数据信息</summary>
    /// <summary>供查询的最新信息</summary>
    /// <summary>股票行情全量静态信息</summary>
    /// <summary>指定的合约</summary>
    public unsafe partial class XTPSpecificTickerStruct : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 20)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id;

            [FieldOffset(4)]
            internal fixed sbyte ticker[16];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPSpecificTickerStruct@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct __CreateInstance(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPSpecificTickerStruct(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPSpecificTickerStruct(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPSpecificTickerStruct()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPSpecificTickerStruct(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE ExchangeId
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal*)__Instance)->exchange_id;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal*)__Instance)->exchange_id = value;
            }
        }

        public sbyte[] Ticker
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal*)__Instance)->ticker != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal*)__Instance)->ticker[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPSpecificTickerStruct.__Internal*)__Instance)->ticker[i] = value[i];
                }
            }
        }
    }

    /// <summary>股票、基金、债券等额外数据</summary>
    public unsafe partial class XTPMarketDataStockExData : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 224)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal long total_bid_qty;

            [FieldOffset(8)]
            internal long total_ask_qty;

            [FieldOffset(16)]
            internal double ma_bid_price;

            [FieldOffset(24)]
            internal double ma_ask_price;

            [FieldOffset(32)]
            internal double ma_bond_bid_price;

            [FieldOffset(40)]
            internal double ma_bond_ask_price;

            [FieldOffset(48)]
            internal double yield_to_maturity;

            [FieldOffset(56)]
            internal double iopv;

            [FieldOffset(64)]
            internal int etf_buy_count;

            [FieldOffset(68)]
            internal int etf_sell_count;

            [FieldOffset(72)]
            internal double etf_buy_qty;

            [FieldOffset(80)]
            internal double etf_buy_money;

            [FieldOffset(88)]
            internal double etf_sell_qty;

            [FieldOffset(96)]
            internal double etf_sell_money;

            [FieldOffset(104)]
            internal double total_warrant_exec_qty;

            [FieldOffset(112)]
            internal double warrant_lower_price;

            [FieldOffset(120)]
            internal double warrant_upper_price;

            [FieldOffset(128)]
            internal int cancel_buy_count;

            [FieldOffset(132)]
            internal int cancel_sell_count;

            [FieldOffset(136)]
            internal double cancel_buy_qty;

            [FieldOffset(144)]
            internal double cancel_sell_qty;

            [FieldOffset(152)]
            internal double cancel_buy_money;

            [FieldOffset(160)]
            internal double cancel_sell_money;

            [FieldOffset(168)]
            internal long total_buy_count;

            [FieldOffset(176)]
            internal long total_sell_count;

            [FieldOffset(184)]
            internal int duration_after_buy;

            [FieldOffset(188)]
            internal int duration_after_sell;

            [FieldOffset(192)]
            internal int num_bid_orders;

            [FieldOffset(196)]
            internal int num_ask_orders;

            [FieldOffset(200)]
            internal double pre_iopv;

            [FieldOffset(208)]
            internal long r1;

            [FieldOffset(216)]
            internal long r2;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPMarketDataStockExData@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData __CreateInstance(global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPMarketDataStockExData(global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPMarketDataStockExData(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPMarketDataStockExData()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPMarketDataStockExData(global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public long TotalBidQty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->total_bid_qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->total_bid_qty = value;
            }
        }

        public long TotalAskQty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->total_ask_qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->total_ask_qty = value;
            }
        }

        public double MaBidPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->ma_bid_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->ma_bid_price = value;
            }
        }

        public double MaAskPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->ma_ask_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->ma_ask_price = value;
            }
        }

        public double MaBondBidPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->ma_bond_bid_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->ma_bond_bid_price = value;
            }
        }

        public double MaBondAskPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->ma_bond_ask_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->ma_bond_ask_price = value;
            }
        }

        public double YieldToMaturity
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->yield_to_maturity;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->yield_to_maturity = value;
            }
        }

        public double Iopv
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->iopv;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->iopv = value;
            }
        }

        public int EtfBuyCount
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_buy_count;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_buy_count = value;
            }
        }

        public int EtfSellCount
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_sell_count;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_sell_count = value;
            }
        }

        public double EtfBuyQty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_buy_qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_buy_qty = value;
            }
        }

        public double EtfBuyMoney
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_buy_money;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_buy_money = value;
            }
        }

        public double EtfSellQty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_sell_qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_sell_qty = value;
            }
        }

        public double EtfSellMoney
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_sell_money;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->etf_sell_money = value;
            }
        }

        public double TotalWarrantExecQty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->total_warrant_exec_qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->total_warrant_exec_qty = value;
            }
        }

        public double WarrantLowerPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->warrant_lower_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->warrant_lower_price = value;
            }
        }

        public double WarrantUpperPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->warrant_upper_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->warrant_upper_price = value;
            }
        }

        public int CancelBuyCount
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_buy_count;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_buy_count = value;
            }
        }

        public int CancelSellCount
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_sell_count;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_sell_count = value;
            }
        }

        public double CancelBuyQty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_buy_qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_buy_qty = value;
            }
        }

        public double CancelSellQty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_sell_qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_sell_qty = value;
            }
        }

        public double CancelBuyMoney
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_buy_money;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_buy_money = value;
            }
        }

        public double CancelSellMoney
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_sell_money;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->cancel_sell_money = value;
            }
        }

        public long TotalBuyCount
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->total_buy_count;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->total_buy_count = value;
            }
        }

        public long TotalSellCount
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->total_sell_count;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->total_sell_count = value;
            }
        }

        public int DurationAfterBuy
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->duration_after_buy;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->duration_after_buy = value;
            }
        }

        public int DurationAfterSell
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->duration_after_sell;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->duration_after_sell = value;
            }
        }

        public int NumBidOrders
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->num_bid_orders;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->num_bid_orders = value;
            }
        }

        public int NumAskOrders
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->num_ask_orders;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->num_ask_orders = value;
            }
        }

        public double PreIopv
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->pre_iopv;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->pre_iopv = value;
            }
        }

        public long R1
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->r1;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->r1 = value;
            }
        }

        public long R2
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->r2;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)__Instance)->r2 = value;
            }
        }
    }

    /// <summary>期权额外数据</summary>
    public unsafe partial class XTPMarketDataOptionExData : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double auction_price;

            [FieldOffset(8)]
            internal long auction_qty;

            [FieldOffset(16)]
            internal long last_enquiry_time;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPMarketDataOptionExData@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData __CreateInstance(global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPMarketDataOptionExData(global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPMarketDataOptionExData(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPMarketDataOptionExData()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPMarketDataOptionExData(global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double AuctionPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal*)__Instance)->auction_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal*)__Instance)->auction_price = value;
            }
        }

        public long AuctionQty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal*)__Instance)->auction_qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal*)__Instance)->auction_qty = value;
            }
        }

        public long LastEnquiryTime
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal*)__Instance)->last_enquiry_time;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal*)__Instance)->last_enquiry_time = value;
            }
        }
    }

    /// <summary>行情</summary>
    public unsafe partial class XTPMarketDataStruct : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 736)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id;

            [FieldOffset(4)]
            internal fixed sbyte ticker[16];

            [FieldOffset(24)]
            internal double last_price;

            [FieldOffset(32)]
            internal double pre_close_price;

            [FieldOffset(40)]
            internal double open_price;

            [FieldOffset(48)]
            internal double high_price;

            [FieldOffset(56)]
            internal double low_price;

            [FieldOffset(64)]
            internal double close_price;

            [FieldOffset(72)]
            internal long pre_total_long_positon;

            [FieldOffset(80)]
            internal long total_long_positon;

            [FieldOffset(88)]
            internal double pre_settl_price;

            [FieldOffset(96)]
            internal double settl_price;

            [FieldOffset(104)]
            internal double upper_limit_price;

            [FieldOffset(112)]
            internal double lower_limit_price;

            [FieldOffset(120)]
            internal double pre_delta;

            [FieldOffset(128)]
            internal double curr_delta;

            [FieldOffset(136)]
            internal long data_time;

            [FieldOffset(144)]
            internal long qty;

            [FieldOffset(152)]
            internal double turnover;

            [FieldOffset(160)]
            internal double avg_price;

            [FieldOffset(168)]
            internal fixed double bid[10];

            [FieldOffset(248)]
            internal fixed double ask[10];

            [FieldOffset(328)]
            internal fixed long bid_qty[10];

            [FieldOffset(408)]
            internal fixed long ask_qty[10];

            [FieldOffset(488)]
            internal long trades_count;

            [FieldOffset(496)]
            internal fixed sbyte ticker_status[8];

            [FieldOffset(504)]
            internal global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal stk;

            [FieldOffset(504)]
            internal global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal opt;

            [FieldOffset(728)]
            internal global::QuantCSharp.ProxyXTP.XTP_MARKETDATA_TYPE data_type;

            [FieldOffset(732)]
            internal int r4;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPMarketDataStruct@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPMarketDataStruct> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPMarketDataStruct>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPMarketDataStruct __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPMarketDataStruct(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPMarketDataStruct __CreateInstance(global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPMarketDataStruct(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPMarketDataStruct(global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPMarketDataStruct(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPMarketDataStruct()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPMarketDataStruct(global::QuantCSharp.ProxyXTP.XTPMarketDataStruct _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPMarketDataStruct __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE ExchangeId
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->exchange_id;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->exchange_id = value;
            }
        }

        public sbyte[] Ticker
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ticker != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ticker[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ticker[i] = value[i];
                }
            }
        }

        public double LastPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->last_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->last_price = value;
            }
        }

        public double PreClosePrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->pre_close_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->pre_close_price = value;
            }
        }

        public double OpenPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->open_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->open_price = value;
            }
        }

        public double HighPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->high_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->high_price = value;
            }
        }

        public double LowPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->low_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->low_price = value;
            }
        }

        public double ClosePrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->close_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->close_price = value;
            }
        }

        public long PreTotalLongPositon
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->pre_total_long_positon;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->pre_total_long_positon = value;
            }
        }

        public long TotalLongPositon
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->total_long_positon;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->total_long_positon = value;
            }
        }

        public double PreSettlPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->pre_settl_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->pre_settl_price = value;
            }
        }

        public double SettlPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->settl_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->settl_price = value;
            }
        }

        public double UpperLimitPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->upper_limit_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->upper_limit_price = value;
            }
        }

        public double LowerLimitPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->lower_limit_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->lower_limit_price = value;
            }
        }

        public double PreDelta
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->pre_delta;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->pre_delta = value;
            }
        }

        public double CurrDelta
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->curr_delta;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->curr_delta = value;
            }
        }

        public long DataTime
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->data_time;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->data_time = value;
            }
        }

        public long Qty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->qty = value;
            }
        }

        public double Turnover
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->turnover;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->turnover = value;
            }
        }

        public double AvgPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->avg_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->avg_price = value;
            }
        }

        public double[] Bid
        {
            get
            {
                double[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->bid != null)
                {
                    __value = new double[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->bid[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->bid[i] = value[i];
                }
            }
        }

        public double[] Ask
        {
            get
            {
                double[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ask != null)
                {
                    __value = new double[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ask[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ask[i] = value[i];
                }
            }
        }

        public long[] BidQty
        {
            get
            {
                long[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->bid_qty != null)
                {
                    __value = new long[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->bid_qty[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->bid_qty[i] = value[i];
                }
            }
        }

        public long[] AskQty
        {
            get
            {
                long[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ask_qty != null)
                {
                    __value = new long[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ask_qty[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ask_qty[i] = value[i];
                }
            }
        }

        public long TradesCount
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->trades_count;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->trades_count = value;
            }
        }

        public sbyte[] TickerStatus
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ticker_status != null)
                {
                    __value = new sbyte[8];
                    for (int i = 0; i < 8; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ticker_status[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 8; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->ticker_status[i] = value[i];
                }
            }
        }

        public global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData Stk
        {
            get
            {
                return global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__CreateInstance(new global::System.IntPtr(&((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->stk));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->stk = *(global::QuantCSharp.ProxyXTP.XTPMarketDataStockExData.__Internal*)value.__Instance;
            }
        }

        public global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData Opt
        {
            get
            {
                return global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__CreateInstance(new global::System.IntPtr(&((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->opt));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->opt = *(global::QuantCSharp.ProxyXTP.XTPMarketDataOptionExData.__Internal*)value.__Instance;
            }
        }

        public global::QuantCSharp.ProxyXTP.XTP_MARKETDATA_TYPE DataType
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->data_type;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->data_type = value;
            }
        }

        public int R4
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->r4;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPMarketDataStruct.__Internal*)__Instance)->r4 = value;
            }
        }
    }

    /// <summary>股票行情静态信息</summary>
    public unsafe partial class XTPQuoteStaticInfo : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 128)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id;

            [FieldOffset(4)]
            internal fixed sbyte ticker[16];

            [FieldOffset(20)]
            internal fixed sbyte ticker_name[64];

            [FieldOffset(84)]
            internal global::QuantCSharp.ProxyXTP.XTP_TICKER_TYPE ticker_type;

            [FieldOffset(88)]
            internal double pre_close_price;

            [FieldOffset(96)]
            internal double upper_limit_price;

            [FieldOffset(104)]
            internal double lower_limit_price;

            [FieldOffset(112)]
            internal double price_tick;

            [FieldOffset(120)]
            internal int buy_qty_unit;

            [FieldOffset(124)]
            internal int sell_qty_unit;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPQuoteStaticInfo@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo __CreateInstance(global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPQuoteStaticInfo(global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPQuoteStaticInfo(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPQuoteStaticInfo()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPQuoteStaticInfo(global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE ExchangeId
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->exchange_id;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->exchange_id = value;
            }
        }

        public sbyte[] Ticker
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->ticker != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->ticker[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->ticker[i] = value[i];
                }
            }
        }

        public sbyte[] TickerName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->ticker_name != null)
                {
                    __value = new sbyte[64];
                    for (int i = 0; i < 64; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->ticker_name[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 64; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->ticker_name[i] = value[i];
                }
            }
        }

        public global::QuantCSharp.ProxyXTP.XTP_TICKER_TYPE TickerType
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->ticker_type;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->ticker_type = value;
            }
        }

        public double PreClosePrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->pre_close_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->pre_close_price = value;
            }
        }

        public double UpperLimitPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->upper_limit_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->upper_limit_price = value;
            }
        }

        public double LowerLimitPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->lower_limit_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->lower_limit_price = value;
            }
        }

        public double PriceTick
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->price_tick;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->price_tick = value;
            }
        }

        public int BuyQtyUnit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->buy_qty_unit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->buy_qty_unit = value;
            }
        }

        public int SellQtyUnit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->sell_qty_unit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteStaticInfo.__Internal*)__Instance)->sell_qty_unit = value;
            }
        }
    }

    /// <summary>定单薄</summary>
    public unsafe partial class OrderBookStruct : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 384)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id;

            [FieldOffset(4)]
            internal fixed sbyte ticker[16];

            [FieldOffset(24)]
            internal double last_price;

            [FieldOffset(32)]
            internal long qty;

            [FieldOffset(40)]
            internal double turnover;

            [FieldOffset(48)]
            internal long trades_count;

            [FieldOffset(56)]
            internal fixed double bid[10];

            [FieldOffset(136)]
            internal fixed double ask[10];

            [FieldOffset(216)]
            internal fixed long bid_qty[10];

            [FieldOffset(296)]
            internal fixed long ask_qty[10];

            [FieldOffset(376)]
            internal long data_time;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0OrderBookStruct@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.OrderBookStruct> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.OrderBookStruct>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.OrderBookStruct __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.OrderBookStruct(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.OrderBookStruct __CreateInstance(global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.OrderBookStruct(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal));
            *(global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private OrderBookStruct(global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected OrderBookStruct(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public OrderBookStruct()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public OrderBookStruct(global::QuantCSharp.ProxyXTP.OrderBookStruct _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.OrderBookStruct __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE ExchangeId
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->exchange_id;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->exchange_id = value;
            }
        }

        public sbyte[] Ticker
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->ticker != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->ticker[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->ticker[i] = value[i];
                }
            }
        }

        public double LastPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->last_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->last_price = value;
            }
        }

        public long Qty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->qty = value;
            }
        }

        public double Turnover
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->turnover;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->turnover = value;
            }
        }

        public long TradesCount
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->trades_count;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->trades_count = value;
            }
        }

        public double[] Bid
        {
            get
            {
                double[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->bid != null)
                {
                    __value = new double[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->bid[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->bid[i] = value[i];
                }
            }
        }

        public double[] Ask
        {
            get
            {
                double[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->ask != null)
                {
                    __value = new double[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->ask[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->ask[i] = value[i];
                }
            }
        }

        public long[] BidQty
        {
            get
            {
                long[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->bid_qty != null)
                {
                    __value = new long[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->bid_qty[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->bid_qty[i] = value[i];
                }
            }
        }

        public long[] AskQty
        {
            get
            {
                long[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->ask_qty != null)
                {
                    __value = new long[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->ask_qty[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->ask_qty[i] = value[i];
                }
            }
        }

        public long DataTime
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->data_time;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.OrderBookStruct.__Internal*)__Instance)->data_time = value;
            }
        }
    }

    /// <summary>逐笔委托(仅适用深交所)</summary>
    public unsafe partial class XTPTickByTickEntrust : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int channel_no;

            [FieldOffset(8)]
            internal long seq;

            [FieldOffset(16)]
            internal double price;

            [FieldOffset(24)]
            internal long qty;

            [FieldOffset(32)]
            internal sbyte side;

            [FieldOffset(33)]
            internal sbyte ord_type;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPTickByTickEntrust@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust __CreateInstance(global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPTickByTickEntrust(global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPTickByTickEntrust(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPTickByTickEntrust()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPTickByTickEntrust(global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int ChannelNo
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->channel_no;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->channel_no = value;
            }
        }

        public long Seq
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->seq;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->seq = value;
            }
        }

        public double Price
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->price = value;
            }
        }

        public long Qty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->qty = value;
            }
        }

        public sbyte Side
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->side;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->side = value;
            }
        }

        public sbyte OrdType
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->ord_type;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)__Instance)->ord_type = value;
            }
        }
    }

    /// <summary>逐笔成交</summary>
    public unsafe partial class XTPTickByTickTrade : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int channel_no;

            [FieldOffset(8)]
            internal long seq;

            [FieldOffset(16)]
            internal double price;

            [FieldOffset(24)]
            internal long qty;

            [FieldOffset(32)]
            internal double money;

            [FieldOffset(40)]
            internal long bid_no;

            [FieldOffset(48)]
            internal long ask_no;

            [FieldOffset(56)]
            internal sbyte trade_flag;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPTickByTickTrade@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPTickByTickTrade> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPTickByTickTrade>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPTickByTickTrade __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPTickByTickTrade(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPTickByTickTrade __CreateInstance(global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPTickByTickTrade(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPTickByTickTrade(global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPTickByTickTrade(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPTickByTickTrade()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPTickByTickTrade(global::QuantCSharp.ProxyXTP.XTPTickByTickTrade _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPTickByTickTrade __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int ChannelNo
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->channel_no;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->channel_no = value;
            }
        }

        public long Seq
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->seq;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->seq = value;
            }
        }

        public double Price
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->price = value;
            }
        }

        public long Qty
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->qty;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->qty = value;
            }
        }

        public double Money
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->money;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->money = value;
            }
        }

        public long BidNo
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->bid_no;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->bid_no = value;
            }
        }

        public long AskNo
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->ask_no;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->ask_no = value;
            }
        }

        public sbyte TradeFlag
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->trade_flag;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)__Instance)->trade_flag = value;
            }
        }
    }

    /// <summary>逐笔数据信息</summary>
    public unsafe partial class XTPTickByTickStruct : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 112)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id;

            [FieldOffset(4)]
            internal fixed sbyte ticker[16];

            [FieldOffset(24)]
            internal long seq;

            [FieldOffset(32)]
            internal long data_time;

            [FieldOffset(40)]
            internal global::QuantCSharp.ProxyXTP.XTP_TBT_TYPE type;

            [FieldOffset(48)]
            internal global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal entrust;

            [FieldOffset(48)]
            internal global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal trade;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPTickByTickStruct@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPTickByTickStruct> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPTickByTickStruct>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPTickByTickStruct __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPTickByTickStruct(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPTickByTickStruct __CreateInstance(global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPTickByTickStruct(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPTickByTickStruct(global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPTickByTickStruct(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPTickByTickStruct()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPTickByTickStruct(global::QuantCSharp.ProxyXTP.XTPTickByTickStruct _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPTickByTickStruct __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE ExchangeId
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->exchange_id;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->exchange_id = value;
            }
        }

        public sbyte[] Ticker
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->ticker != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->ticker[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->ticker[i] = value[i];
                }
            }
        }

        public long Seq
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->seq;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->seq = value;
            }
        }

        public long DataTime
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->data_time;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->data_time = value;
            }
        }

        public global::QuantCSharp.ProxyXTP.XTP_TBT_TYPE Type
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->type;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->type = value;
            }
        }

        public global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust Entrust
        {
            get
            {
                return global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__CreateInstance(new global::System.IntPtr(&((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->entrust));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->entrust = *(global::QuantCSharp.ProxyXTP.XTPTickByTickEntrust.__Internal*)value.__Instance;
            }
        }

        public global::QuantCSharp.ProxyXTP.XTPTickByTickTrade Trade
        {
            get
            {
                return global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__CreateInstance(new global::System.IntPtr(&((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->trade));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::QuantCSharp.ProxyXTP.XTPTickByTickStruct.__Internal*)__Instance)->trade = *(global::QuantCSharp.ProxyXTP.XTPTickByTickTrade.__Internal*)value.__Instance;
            }
        }
    }

    /// <summary>供查询的最新信息</summary>
    public unsafe partial class XTPTickerPriceInfo : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id;

            [FieldOffset(4)]
            internal fixed sbyte ticker[16];

            [FieldOffset(24)]
            internal double last_price;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPTickerPriceInfo@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo __CreateInstance(global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPTickerPriceInfo(global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPTickerPriceInfo(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPTickerPriceInfo()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPTickerPriceInfo(global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE ExchangeId
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal*)__Instance)->exchange_id;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal*)__Instance)->exchange_id = value;
            }
        }

        public sbyte[] Ticker
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal*)__Instance)->ticker != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal*)__Instance)->ticker[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal*)__Instance)->ticker[i] = value[i];
                }
            }
        }

        public double LastPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal*)__Instance)->last_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPTickerPriceInfo.__Internal*)__Instance)->last_price = value;
            }
        }
    }

    /// <summary>股票行情全量静态信息</summary>
    public unsafe partial class XTPQuoteFullInfo : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 216)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE exchange_id;

            [FieldOffset(4)]
            internal fixed sbyte ticker[16];

            [FieldOffset(20)]
            internal fixed sbyte ticker_name[64];

            [FieldOffset(84)]
            internal global::QuantCSharp.ProxyXTP.XTP_SECURITY_TYPE security_type;

            [FieldOffset(88)]
            internal global::QuantCSharp.ProxyXTP.XTP_QUALIFICATION_TYPE ticker_qualification_class;

            [FieldOffset(92)]
            internal byte is_registration;

            [FieldOffset(93)]
            internal byte is_VIE;

            [FieldOffset(94)]
            internal byte is_noprofit;

            [FieldOffset(95)]
            internal byte is_weighted_voting_rights;

            [FieldOffset(96)]
            internal byte is_have_price_limit;

            [FieldOffset(104)]
            internal double upper_limit_price;

            [FieldOffset(112)]
            internal double lower_limit_price;

            [FieldOffset(120)]
            internal double pre_close_price;

            [FieldOffset(128)]
            internal double price_tick;

            [FieldOffset(136)]
            internal int bid_qty_upper_limit;

            [FieldOffset(140)]
            internal int bid_qty_lower_limit;

            [FieldOffset(144)]
            internal int bid_qty_unit;

            [FieldOffset(148)]
            internal int ask_qty_upper_limit;

            [FieldOffset(152)]
            internal int ask_qty_lower_limit;

            [FieldOffset(156)]
            internal int ask_qty_unit;

            [FieldOffset(160)]
            internal int market_bid_qty_upper_limit;

            [FieldOffset(164)]
            internal int market_bid_qty_lower_limit;

            [FieldOffset(168)]
            internal int market_bid_qty_unit;

            [FieldOffset(172)]
            internal int market_ask_qty_upper_limit;

            [FieldOffset(176)]
            internal int market_ask_qty_lower_limit;

            [FieldOffset(180)]
            internal int market_ask_qty_unit;

            [FieldOffset(184)]
            internal fixed ulong unknown[4];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtp_quote_api", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0XTPQuoteFullInfo@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo(native.ToPointer(), skipVTables);
        }

        internal static global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo __CreateInstance(global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal native, bool skipVTables = false)
        {
            return new global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo(native, skipVTables);
        }

        private static void* __CopyValue(global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal));
            *(global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private XTPQuoteFullInfo(global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected XTPQuoteFullInfo(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public XTPQuoteFullInfo()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public XTPQuoteFullInfo(global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance) = *((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE ExchangeId
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->exchange_id;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->exchange_id = value;
            }
        }

        public sbyte[] Ticker
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ticker != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ticker[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ticker[i] = value[i];
                }
            }
        }

        public sbyte[] TickerName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ticker_name != null)
                {
                    __value = new sbyte[64];
                    for (int i = 0; i < 64; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ticker_name[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 64; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ticker_name[i] = value[i];
                }
            }
        }

        public global::QuantCSharp.ProxyXTP.XTP_SECURITY_TYPE SecurityType
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->security_type;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->security_type = value;
            }
        }

        public global::QuantCSharp.ProxyXTP.XTP_QUALIFICATION_TYPE TickerQualificationClass
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ticker_qualification_class;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ticker_qualification_class = value;
            }
        }

        public bool IsRegistration
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->is_registration != 0;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->is_registration = (byte)(value ? 1 : 0);
            }
        }

        public bool IsVIE
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->is_VIE != 0;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->is_VIE = (byte)(value ? 1 : 0);
            }
        }

        public bool IsNoprofit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->is_noprofit != 0;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->is_noprofit = (byte)(value ? 1 : 0);
            }
        }

        public bool IsWeightedVotingRights
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->is_weighted_voting_rights != 0;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->is_weighted_voting_rights = (byte)(value ? 1 : 0);
            }
        }

        public bool IsHavePriceLimit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->is_have_price_limit != 0;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->is_have_price_limit = (byte)(value ? 1 : 0);
            }
        }

        public double UpperLimitPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->upper_limit_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->upper_limit_price = value;
            }
        }

        public double LowerLimitPrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->lower_limit_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->lower_limit_price = value;
            }
        }

        public double PreClosePrice
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->pre_close_price;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->pre_close_price = value;
            }
        }

        public double PriceTick
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->price_tick;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->price_tick = value;
            }
        }

        public int BidQtyUpperLimit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->bid_qty_upper_limit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->bid_qty_upper_limit = value;
            }
        }

        public int BidQtyLowerLimit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->bid_qty_lower_limit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->bid_qty_lower_limit = value;
            }
        }

        public int BidQtyUnit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->bid_qty_unit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->bid_qty_unit = value;
            }
        }

        public int AskQtyUpperLimit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ask_qty_upper_limit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ask_qty_upper_limit = value;
            }
        }

        public int AskQtyLowerLimit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ask_qty_lower_limit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ask_qty_lower_limit = value;
            }
        }

        public int AskQtyUnit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ask_qty_unit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->ask_qty_unit = value;
            }
        }

        public int MarketBidQtyUpperLimit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_bid_qty_upper_limit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_bid_qty_upper_limit = value;
            }
        }

        public int MarketBidQtyLowerLimit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_bid_qty_lower_limit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_bid_qty_lower_limit = value;
            }
        }

        public int MarketBidQtyUnit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_bid_qty_unit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_bid_qty_unit = value;
            }
        }

        public int MarketAskQtyUpperLimit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_ask_qty_upper_limit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_ask_qty_upper_limit = value;
            }
        }

        public int MarketAskQtyLowerLimit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_ask_qty_lower_limit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_ask_qty_lower_limit = value;
            }
        }

        public int MarketAskQtyUnit
        {
            get
            {
                return ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_ask_qty_unit;
            }

            set
            {
                ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->market_ask_qty_unit = value;
            }
        }

        public ulong[] Unknown
        {
            get
            {
                ulong[] __value = null;
                if (((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->unknown != null)
                {
                    __value = new ulong[4];
                    for (int i = 0; i < 4; i++)
                        __value[i] = ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->unknown[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 4; i++)
                        ((global::QuantCSharp.ProxyXTP.XTPQuoteFullInfo.__Internal*)__Instance)->unknown[i] = value[i];
                }
            }
        }
    }

    namespace Delegates
    {
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_int(global::System.IntPtr __instance, int arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_IntPtr(global::System.IntPtr __instance, global::System.IntPtr arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_IntPtr_IntPtr_bool(global::System.IntPtr __instance, global::System.IntPtr arg1, global::System.IntPtr arg2, [MarshalAs(UnmanagedType.I1)] bool arg3);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_IntPtr_longArray_int_int_longArray_int_int(global::System.IntPtr __instance, global::System.IntPtr arg1, long[] arg2, int arg3, int arg4, long[] arg5, int arg6, int arg7);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_EXCHANGE_TYPE_IntPtr(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE arg1, global::System.IntPtr arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr(global::System.IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate global::System.IntPtr Func_IntPtr_IntPtr(global::System.IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_uint(global::System.IntPtr __instance, uint arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_bool(global::System.IntPtr __instance, [MarshalAs(UnmanagedType.I1)] bool arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int_EXCHANGE_TYPE(global::System.IntPtr __instance, [MarshalAs(UnmanagedType.LPArray)] string[] arg1, int arg2, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE arg3);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int_IntPtr_XTP_EXCHANGE_TYPE(global::System.IntPtr __instance, global::QuantCSharp.ProxyXTP.XTP_EXCHANGE_TYPE arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int_IntPtr_string_int_string_string_Login(global::System.IntPtr __instance, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, int arg2, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg3, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg4, global::QuantCSharp.ProxyXTP.XTP_PROTOCOL_TYPE arg5, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg6);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int_IntPtr(global::System.IntPtr __instance);

    }
}
