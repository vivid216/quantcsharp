using QuantCSharp.ProxyCTP;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
//using Marshal = proxyctp.CMarshal;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

namespace ProxyCTP
{
    /// <summary>信息分发</summary>
    public unsafe partial class CThostFtdcDisseminationField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal short SequenceSeries;

            [FieldOffset(4)]
            internal int SequenceNo;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcDisseminationField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcDisseminationField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcDisseminationField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcDisseminationField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcDisseminationField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcDisseminationField __CreateInstance(global::ProxyCTP.CThostFtdcDisseminationField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcDisseminationField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcDisseminationField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcDisseminationField.__Internal));
            *(global::ProxyCTP.CThostFtdcDisseminationField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcDisseminationField(global::ProxyCTP.CThostFtdcDisseminationField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcDisseminationField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcDisseminationField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcDisseminationField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcDisseminationField(global::ProxyCTP.CThostFtdcDisseminationField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcDisseminationField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcDisseminationField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcDisseminationField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcDisseminationField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public short SequenceSeries
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDisseminationField.__Internal*)__Instance)->SequenceSeries;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDisseminationField.__Internal*)__Instance)->SequenceSeries = value;
            }
        }

        public int SequenceNo
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDisseminationField.__Internal*)__Instance)->SequenceNo;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDisseminationField.__Internal*)__Instance)->SequenceNo = value;
            }
        }
    }

    /// <summary>用户登录请求</summary>
    public unsafe partial class CThostFtdcReqUserLoginField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 264)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(9)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(20)]
            internal fixed sbyte UserID[16];

            [FieldOffset(36)]
            internal fixed sbyte Password[41];

            [FieldOffset(77)]
            internal fixed sbyte UserProductInfo[11];

            [FieldOffset(88)]
            internal fixed sbyte InterfaceProductInfo[11];

            [FieldOffset(99)]
            internal fixed sbyte ProtocolInfo[11];

            [FieldOffset(110)]
            internal fixed sbyte MacAddress[21];

            [FieldOffset(131)]
            internal fixed sbyte OneTimePassword[41];

            [FieldOffset(172)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(188)]
            internal fixed sbyte LoginRemark[36];

            [FieldOffset(224)]
            internal int ClientIPPort;

            [FieldOffset(228)]
            internal fixed sbyte ClientIPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcReqUserLoginField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqUserLoginField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqUserLoginField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcReqUserLoginField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqUserLoginField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcReqUserLoginField __CreateInstance(global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqUserLoginField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal));
            *(global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcReqUserLoginField(global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcReqUserLoginField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcReqUserLoginField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcReqUserLoginField(global::ProxyCTP.CThostFtdcReqUserLoginField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcReqUserLoginField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] Password
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->Password != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->Password[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->Password[i] = value[i];
                }
            }
        }

        public sbyte[] UserProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->UserProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->UserProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->UserProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] InterfaceProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->InterfaceProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->InterfaceProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->InterfaceProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] ProtocolInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->ProtocolInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->ProtocolInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->ProtocolInfo[i] = value[i];
                }
            }
        }

        public sbyte[] MacAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->MacAddress != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->MacAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->MacAddress[i] = value[i];
                }
            }
        }

        public sbyte[] OneTimePassword
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->OneTimePassword != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->OneTimePassword[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->OneTimePassword[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] LoginRemark
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->LoginRemark != null)
                {
                    __value = new sbyte[36];
                    for (int i = 0; i < 36; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->LoginRemark[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 36; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->LoginRemark[i] = value[i];
                }
            }
        }

        public int ClientIPPort
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->ClientIPPort;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->ClientIPPort = value;
            }
        }

        public sbyte[] ClientIPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->ClientIPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->ClientIPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginField.__Internal*)__Instance)->ClientIPAddress[i] = value[i];
                }
            }
        }
    }

    /// <summary>用户登录应答</summary>
    public unsafe partial class CThostFtdcRspUserLoginField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 195)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(9)]
            internal fixed sbyte LoginTime[9];

            [FieldOffset(18)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(29)]
            internal fixed sbyte UserID[16];

            [FieldOffset(45)]
            internal fixed sbyte SystemName[41];

            [FieldOffset(88)]
            internal int FrontID;

            [FieldOffset(92)]
            internal int SessionID;

            [FieldOffset(96)]
            internal fixed sbyte MaxOrderRef[13];

            [FieldOffset(109)]
            internal fixed sbyte SHFETime[9];

            [FieldOffset(118)]
            internal fixed sbyte DCETime[9];

            [FieldOffset(127)]
            internal fixed sbyte CZCETime[9];

            [FieldOffset(136)]
            internal fixed sbyte FFEXTime[9];

            [FieldOffset(145)]
            internal fixed sbyte INETime[9];

            [FieldOffset(154)]
            internal fixed sbyte SysVersion[41];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcRspUserLoginField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspUserLoginField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspUserLoginField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcRspUserLoginField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspUserLoginField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcRspUserLoginField __CreateInstance(global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspUserLoginField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal));
            *(global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcRspUserLoginField(global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcRspUserLoginField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcRspUserLoginField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcRspUserLoginField(global::ProxyCTP.CThostFtdcRspUserLoginField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcRspUserLoginField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public sbyte[] LoginTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->LoginTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->LoginTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->LoginTime[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] SystemName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SystemName != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SystemName[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SystemName[i] = value[i];
                }
            }
        }

        public int FrontID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->FrontID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->FrontID = value;
            }
        }

        public int SessionID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SessionID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SessionID = value;
            }
        }

        public sbyte[] MaxOrderRef
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->MaxOrderRef != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->MaxOrderRef[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->MaxOrderRef[i] = value[i];
                }
            }
        }

        public sbyte[] SHFETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SHFETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SHFETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SHFETime[i] = value[i];
                }
            }
        }

        public sbyte[] DCETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->DCETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->DCETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->DCETime[i] = value[i];
                }
            }
        }

        public sbyte[] CZCETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->CZCETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->CZCETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->CZCETime[i] = value[i];
                }
            }
        }

        public sbyte[] FFEXTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->FFEXTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->FFEXTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->FFEXTime[i] = value[i];
                }
            }
        }

        public sbyte[] INETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->INETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->INETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->INETime[i] = value[i];
                }
            }
        }

        public sbyte[] SysVersion
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SysVersion != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SysVersion[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLoginField.__Internal*)__Instance)->SysVersion[i] = value[i];
                }
            }
        }

    }

    /// <summary>用户登出请求</summary>
    public unsafe partial class CThostFtdcUserLogoutField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 27)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte UserID[16];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcUserLogoutField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcUserLogoutField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcUserLogoutField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcUserLogoutField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcUserLogoutField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcUserLogoutField __CreateInstance(global::ProxyCTP.CThostFtdcUserLogoutField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcUserLogoutField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcUserLogoutField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserLogoutField.__Internal));
            *(global::ProxyCTP.CThostFtdcUserLogoutField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcUserLogoutField(global::ProxyCTP.CThostFtdcUserLogoutField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcUserLogoutField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcUserLogoutField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserLogoutField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcUserLogoutField(global::ProxyCTP.CThostFtdcUserLogoutField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserLogoutField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcUserLogoutField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcUserLogoutField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcUserLogoutField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserLogoutField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserLogoutField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcUserLogoutField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserLogoutField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserLogoutField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcUserLogoutField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }
    }

    /// <summary>强制交易员退出</summary>
    public unsafe partial class CThostFtdcForceUserLogoutField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 27)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte UserID[16];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcForceUserLogoutField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcForceUserLogoutField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcForceUserLogoutField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcForceUserLogoutField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcForceUserLogoutField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcForceUserLogoutField __CreateInstance(global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcForceUserLogoutField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal));
            *(global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcForceUserLogoutField(global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcForceUserLogoutField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcForceUserLogoutField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcForceUserLogoutField(global::ProxyCTP.CThostFtdcForceUserLogoutField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcForceUserLogoutField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcForceUserLogoutField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }
    }

    /// <summary>客户端认证请求</summary>
    public unsafe partial class CThostFtdcReqAuthenticateField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 88)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte UserID[16];

            [FieldOffset(27)]
            internal fixed sbyte UserProductInfo[11];

            [FieldOffset(38)]
            internal fixed sbyte AuthCode[17];

            [FieldOffset(55)]
            internal fixed sbyte AppID[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcReqAuthenticateField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqAuthenticateField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqAuthenticateField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcReqAuthenticateField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqAuthenticateField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcReqAuthenticateField __CreateInstance(global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqAuthenticateField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal));
            *(global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcReqAuthenticateField(global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcReqAuthenticateField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcReqAuthenticateField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcReqAuthenticateField(global::ProxyCTP.CThostFtdcReqAuthenticateField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcReqAuthenticateField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] UserProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->UserProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->UserProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->UserProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] AuthCode
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->AuthCode != null)
                {
                    __value = new sbyte[17];
                    for (int i = 0; i < 17; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->AuthCode[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 17; i++)
                        ((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->AuthCode[i] = value[i];
                }
            }
        }

        public sbyte[] AppID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->AppID != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->AppID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcReqAuthenticateField.__Internal*)__Instance)->AppID[i] = value[i];
                }
            }
        }
    }

    /// <summary>客户端认证响应</summary>
    public unsafe partial class CThostFtdcRspAuthenticateField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 72)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte UserID[16];

            [FieldOffset(27)]
            internal fixed sbyte UserProductInfo[11];

            [FieldOffset(38)]
            internal fixed sbyte AppID[33];

            [FieldOffset(71)]
            internal sbyte AppType;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcRspAuthenticateField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspAuthenticateField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspAuthenticateField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcRspAuthenticateField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspAuthenticateField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcRspAuthenticateField __CreateInstance(global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspAuthenticateField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal));
            *(global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcRspAuthenticateField(global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcRspAuthenticateField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcRspAuthenticateField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcRspAuthenticateField(global::ProxyCTP.CThostFtdcRspAuthenticateField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcRspAuthenticateField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] UserProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->UserProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->UserProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->UserProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] AppID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->AppID != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->AppID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->AppID[i] = value[i];
                }
            }
        }

        public sbyte AppType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->AppType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcRspAuthenticateField.__Internal*)__Instance)->AppType = value;
            }
        }
    }

    /// <summary>客户端认证信息</summary>
    public unsafe partial class CThostFtdcAuthenticationInfoField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 256)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte UserID[16];

            [FieldOffset(27)]
            internal fixed sbyte UserProductInfo[11];

            [FieldOffset(38)]
            internal fixed sbyte AuthInfo[129];

            [FieldOffset(168)]
            internal int IsResult;

            [FieldOffset(172)]
            internal fixed sbyte AppID[33];

            [FieldOffset(205)]
            internal sbyte AppType;

            [FieldOffset(206)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(222)]
            internal fixed sbyte ClientIPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcAuthenticationInfoField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcAuthenticationInfoField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcAuthenticationInfoField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcAuthenticationInfoField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcAuthenticationInfoField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcAuthenticationInfoField __CreateInstance(global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcAuthenticationInfoField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal));
            *(global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcAuthenticationInfoField(global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcAuthenticationInfoField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcAuthenticationInfoField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcAuthenticationInfoField(global::ProxyCTP.CThostFtdcAuthenticationInfoField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcAuthenticationInfoField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] UserProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->UserProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->UserProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->UserProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] AuthInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->AuthInfo != null)
                {
                    __value = new sbyte[129];
                    for (int i = 0; i < 129; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->AuthInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 129; i++)
                        ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->AuthInfo[i] = value[i];
                }
            }
        }

        public int IsResult
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->IsResult;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->IsResult = value;
            }
        }

        public sbyte[] AppID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->AppID != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->AppID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->AppID[i] = value[i];
                }
            }
        }

        public sbyte AppType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->AppType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->AppType = value;
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] ClientIPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->ClientIPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->ClientIPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcAuthenticationInfoField.__Internal*)__Instance)->ClientIPAddress[i] = value[i];
                }
            }
        }
    }

    /// <summary>用户登录应答2</summary>
    public unsafe partial class CThostFtdcRspUserLogin2Field : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 172)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(9)]
            internal fixed sbyte LoginTime[9];

            [FieldOffset(18)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(29)]
            internal fixed sbyte UserID[16];

            [FieldOffset(45)]
            internal fixed sbyte SystemName[41];

            [FieldOffset(88)]
            internal int FrontID;

            [FieldOffset(92)]
            internal int SessionID;

            [FieldOffset(96)]
            internal fixed sbyte MaxOrderRef[13];

            [FieldOffset(109)]
            internal fixed sbyte SHFETime[9];

            [FieldOffset(118)]
            internal fixed sbyte DCETime[9];

            [FieldOffset(127)]
            internal fixed sbyte CZCETime[9];

            [FieldOffset(136)]
            internal fixed sbyte FFEXTime[9];

            [FieldOffset(145)]
            internal fixed sbyte INETime[9];

            [FieldOffset(154)]
            internal fixed sbyte RandomString[17];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcRspUserLogin2Field@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspUserLogin2Field> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspUserLogin2Field>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcRspUserLogin2Field __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspUserLogin2Field(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcRspUserLogin2Field __CreateInstance(global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspUserLogin2Field(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal));
            *(global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcRspUserLogin2Field(global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcRspUserLogin2Field(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcRspUserLogin2Field()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcRspUserLogin2Field(global::ProxyCTP.CThostFtdcRspUserLogin2Field _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcRspUserLogin2Field __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public sbyte[] LoginTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->LoginTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->LoginTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->LoginTime[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] SystemName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->SystemName != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->SystemName[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->SystemName[i] = value[i];
                }
            }
        }

        public int FrontID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->FrontID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->FrontID = value;
            }
        }

        public int SessionID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->SessionID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->SessionID = value;
            }
        }

        public sbyte[] MaxOrderRef
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->MaxOrderRef != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->MaxOrderRef[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->MaxOrderRef[i] = value[i];
                }
            }
        }

        public sbyte[] SHFETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->SHFETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->SHFETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->SHFETime[i] = value[i];
                }
            }
        }

        public sbyte[] DCETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->DCETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->DCETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->DCETime[i] = value[i];
                }
            }
        }

        public sbyte[] CZCETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->CZCETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->CZCETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->CZCETime[i] = value[i];
                }
            }
        }

        public sbyte[] FFEXTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->FFEXTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->FFEXTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->FFEXTime[i] = value[i];
                }
            }
        }

        public sbyte[] INETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->INETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->INETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->INETime[i] = value[i];
                }
            }
        }

        public sbyte[] RandomString
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->RandomString != null)
                {
                    __value = new sbyte[17];
                    for (int i = 0; i < 17; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->RandomString[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 17; i++)
                        ((global::ProxyCTP.CThostFtdcRspUserLogin2Field.__Internal*)__Instance)->RandomString[i] = value[i];
                }
            }
        }
    }

    /// <summary>Fens用户信息</summary>
    public unsafe partial class CThostFtdcFensUserInfoField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 28)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte UserID[16];

            [FieldOffset(27)]
            internal sbyte LoginMode;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcFensUserInfoField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcFensUserInfoField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcFensUserInfoField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcFensUserInfoField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcFensUserInfoField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcFensUserInfoField __CreateInstance(global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcFensUserInfoField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal));
            *(global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcFensUserInfoField(global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcFensUserInfoField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcFensUserInfoField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcFensUserInfoField(global::ProxyCTP.CThostFtdcFensUserInfoField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcFensUserInfoField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte LoginMode
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)__Instance)->LoginMode;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcFensUserInfoField.__Internal*)__Instance)->LoginMode = value;
            }
        }
    }


    /// <summary>响应信息</summary>
    public unsafe partial class CThostFtdcRspInfoField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 88)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int ErrorID;

            [FieldOffset(4)]
            internal fixed sbyte ErrorMsg[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcRspInfoField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspInfoField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspInfoField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcRspInfoField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspInfoField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcRspInfoField __CreateInstance(global::ProxyCTP.CThostFtdcRspInfoField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspInfoField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcRspInfoField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspInfoField.__Internal));
            *(global::ProxyCTP.CThostFtdcRspInfoField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcRspInfoField(global::ProxyCTP.CThostFtdcRspInfoField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcRspInfoField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcRspInfoField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcRspInfoField(global::ProxyCTP.CThostFtdcRspInfoField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcRspInfoField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcRspInfoField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcRspInfoField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int ErrorID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcRspInfoField.__Internal*)__Instance)->ErrorID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcRspInfoField.__Internal*)__Instance)->ErrorID = value;
            }
        }

        public sbyte[] ErrorMsg
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspInfoField.__Internal*)__Instance)->ErrorMsg != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspInfoField.__Internal*)__Instance)->ErrorMsg[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcRspInfoField.__Internal*)__Instance)->ErrorMsg[i] = value[i];
                }
            }
        }
    }

    /// <summary>交易所</summary>
    public unsafe partial class CThostFtdcExchangeField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 71)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(9)]
            internal fixed sbyte ExchangeName[61];

            [FieldOffset(70)]
            internal sbyte ExchangeProperty;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcExchangeField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcExchangeField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcExchangeField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcExchangeField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcExchangeField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcExchangeField __CreateInstance(global::ProxyCTP.CThostFtdcExchangeField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcExchangeField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcExchangeField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcExchangeField.__Internal));
            *(global::ProxyCTP.CThostFtdcExchangeField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcExchangeField(global::ProxyCTP.CThostFtdcExchangeField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcExchangeField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcExchangeField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcExchangeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcExchangeField(global::ProxyCTP.CThostFtdcExchangeField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcExchangeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcExchangeField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcExchangeField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcExchangeField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcExchangeField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcExchangeField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcExchangeField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcExchangeField.__Internal*)__Instance)->ExchangeName != null)
                {
                    __value = new sbyte[61];
                    for (int i = 0; i < 61; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcExchangeField.__Internal*)__Instance)->ExchangeName[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 61; i++)
                        ((global::ProxyCTP.CThostFtdcExchangeField.__Internal*)__Instance)->ExchangeName[i] = value[i];
                }
            }
        }

        public sbyte ExchangeProperty
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcExchangeField.__Internal*)__Instance)->ExchangeProperty;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcExchangeField.__Internal*)__Instance)->ExchangeProperty = value;
            }
        }
    }

    /// <summary>产品</summary>
    public unsafe partial class CThostFtdcProductField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 312)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(31)]
            internal fixed sbyte ProductName[21];

            [FieldOffset(52)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(61)]
            internal sbyte ProductClass;

            [FieldOffset(64)]
            internal int VolumeMultiple;

            [FieldOffset(72)]
            internal double PriceTick;

            [FieldOffset(80)]
            internal int MaxMarketOrderVolume;

            [FieldOffset(84)]
            internal int MinMarketOrderVolume;

            [FieldOffset(88)]
            internal int MaxLimitOrderVolume;

            [FieldOffset(92)]
            internal int MinLimitOrderVolume;

            [FieldOffset(96)]
            internal sbyte PositionType;

            [FieldOffset(97)]
            internal sbyte PositionDateType;

            [FieldOffset(98)]
            internal sbyte CloseDealType;

            [FieldOffset(99)]
            internal fixed sbyte TradeCurrencyID[4];

            [FieldOffset(103)]
            internal sbyte MortgageFundUseRange;

            [FieldOffset(104)]
            internal fixed sbyte reserve2[31];

            [FieldOffset(136)]
            internal double UnderlyingMultiple;

            [FieldOffset(144)]
            internal fixed sbyte ProductID[81];

            [FieldOffset(225)]
            internal fixed sbyte ExchangeProductID[81];

            [FieldOffset(306)]
            internal sbyte OpenLimitControlLevel;

            [FieldOffset(307)]
            internal sbyte OrderFreqControlLevel;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcProductField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcProductField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcProductField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcProductField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcProductField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcProductField __CreateInstance(global::ProxyCTP.CThostFtdcProductField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcProductField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcProductField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcProductField.__Internal));
            *(global::ProxyCTP.CThostFtdcProductField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcProductField(global::ProxyCTP.CThostFtdcProductField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcProductField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcProductField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcProductField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcProductField(global::ProxyCTP.CThostFtdcProductField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcProductField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcProductField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcProductField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] ProductName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ProductName != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ProductName[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ProductName[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte ProductClass
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ProductClass;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ProductClass = value;
            }
        }

        public int VolumeMultiple
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->VolumeMultiple;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->VolumeMultiple = value;
            }
        }

        public double PriceTick
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->PriceTick;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->PriceTick = value;
            }
        }

        public int MaxMarketOrderVolume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->MaxMarketOrderVolume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->MaxMarketOrderVolume = value;
            }
        }

        public int MinMarketOrderVolume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->MinMarketOrderVolume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->MinMarketOrderVolume = value;
            }
        }

        public int MaxLimitOrderVolume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->MaxLimitOrderVolume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->MaxLimitOrderVolume = value;
            }
        }

        public int MinLimitOrderVolume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->MinLimitOrderVolume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->MinLimitOrderVolume = value;
            }
        }

        public sbyte PositionType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->PositionType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->PositionType = value;
            }
        }

        public sbyte PositionDateType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->PositionDateType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->PositionDateType = value;
            }
        }

        public sbyte CloseDealType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->CloseDealType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->CloseDealType = value;
            }
        }

        public sbyte[] TradeCurrencyID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->TradeCurrencyID != null)
                {
                    __value = new sbyte[4];
                    for (int i = 0; i < 4; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->TradeCurrencyID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 4; i++)
                        ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->TradeCurrencyID[i] = value[i];
                }
            }
        }

        public sbyte MortgageFundUseRange
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->MortgageFundUseRange;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->MortgageFundUseRange = value;
            }
        }

        public sbyte[] Reserve2
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->reserve2 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->reserve2[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->reserve2[i] = value[i];
                }
            }
        }

        public double UnderlyingMultiple
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->UnderlyingMultiple;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->UnderlyingMultiple = value;
            }
        }

        public sbyte[] ProductID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ProductID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ProductID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ProductID[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeProductID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ExchangeProductID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ExchangeProductID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->ExchangeProductID[i] = value[i];
                }
            }
        }

        public sbyte OpenLimitControlLevel
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->OpenLimitControlLevel;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->OpenLimitControlLevel = value;
            }
        }

        public sbyte OrderFreqControlLevel
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->OrderFreqControlLevel;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcProductField.__Internal*)__Instance)->OrderFreqControlLevel = value;
            }
        }
    }

    /// <summary>合约</summary>
    public unsafe partial class CThostFtdcInstrumentField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 616)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(31)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(40)]
            internal fixed sbyte InstrumentName[21];

            [FieldOffset(61)]
            internal fixed sbyte reserve2[31];

            [FieldOffset(92)]
            internal fixed sbyte reserve3[31];

            [FieldOffset(123)]
            internal sbyte ProductClass;

            [FieldOffset(124)]
            internal int DeliveryYear;

            [FieldOffset(128)]
            internal int DeliveryMonth;

            [FieldOffset(132)]
            internal int MaxMarketOrderVolume;

            [FieldOffset(136)]
            internal int MinMarketOrderVolume;

            [FieldOffset(140)]
            internal int MaxLimitOrderVolume;

            [FieldOffset(144)]
            internal int MinLimitOrderVolume;

            [FieldOffset(148)]
            internal int VolumeMultiple;

            [FieldOffset(152)]
            internal double PriceTick;

            [FieldOffset(160)]
            internal fixed sbyte CreateDate[9];

            [FieldOffset(169)]
            internal fixed sbyte OpenDate[9];

            [FieldOffset(178)]
            internal fixed sbyte ExpireDate[9];

            [FieldOffset(187)]
            internal fixed sbyte StartDelivDate[9];

            [FieldOffset(196)]
            internal fixed sbyte EndDelivDate[9];

            [FieldOffset(205)]
            internal sbyte InstLifePhase;

            [FieldOffset(208)]
            internal int IsTrading;

            [FieldOffset(212)]
            internal sbyte PositionType;

            [FieldOffset(213)]
            internal sbyte PositionDateType;

            [FieldOffset(216)]
            internal double LongMarginRatio;

            [FieldOffset(224)]
            internal double ShortMarginRatio;

            [FieldOffset(232)]
            internal sbyte MaxMarginSideAlgorithm;

            [FieldOffset(233)]
            internal fixed sbyte reserve4[31];

            [FieldOffset(264)]
            internal double StrikePrice;

            [FieldOffset(272)]
            internal sbyte OptionsType;

            [FieldOffset(280)]
            internal double UnderlyingMultiple;

            [FieldOffset(288)]
            internal sbyte CombinationType;

            [FieldOffset(289)]
            internal fixed sbyte InstrumentID[81];

            [FieldOffset(370)]
            internal fixed sbyte ExchangeInstID[81];

            [FieldOffset(451)]
            internal fixed sbyte ProductID[81];

            [FieldOffset(532)]
            internal fixed sbyte UnderlyingInstrID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcInstrumentField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcInstrumentField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcInstrumentField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcInstrumentField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcInstrumentField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcInstrumentField __CreateInstance(global::ProxyCTP.CThostFtdcInstrumentField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcInstrumentField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcInstrumentField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInstrumentField.__Internal));
            *(global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcInstrumentField(global::ProxyCTP.CThostFtdcInstrumentField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcInstrumentField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcInstrumentField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInstrumentField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcInstrumentField(global::ProxyCTP.CThostFtdcInstrumentField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInstrumentField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcInstrumentField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] InstrumentName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->InstrumentName != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->InstrumentName[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->InstrumentName[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve2
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve2 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve2[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve2[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve3
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve3 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve3[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve3[i] = value[i];
                }
            }
        }

        public sbyte ProductClass
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ProductClass;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ProductClass = value;
            }
        }

        public int DeliveryYear
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->DeliveryYear;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->DeliveryYear = value;
            }
        }

        public int DeliveryMonth
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->DeliveryMonth;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->DeliveryMonth = value;
            }
        }

        public int MaxMarketOrderVolume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->MaxMarketOrderVolume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->MaxMarketOrderVolume = value;
            }
        }

        public int MinMarketOrderVolume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->MinMarketOrderVolume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->MinMarketOrderVolume = value;
            }
        }

        public int MaxLimitOrderVolume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->MaxLimitOrderVolume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->MaxLimitOrderVolume = value;
            }
        }

        public int MinLimitOrderVolume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->MinLimitOrderVolume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->MinLimitOrderVolume = value;
            }
        }

        public int VolumeMultiple
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->VolumeMultiple;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->VolumeMultiple = value;
            }
        }

        public double PriceTick
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->PriceTick;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->PriceTick = value;
            }
        }

        public sbyte[] CreateDate
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->CreateDate != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->CreateDate[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->CreateDate[i] = value[i];
                }
            }
        }

        public sbyte[] OpenDate
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->OpenDate != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->OpenDate[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->OpenDate[i] = value[i];
                }
            }
        }

        public sbyte[] ExpireDate
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ExpireDate != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ExpireDate[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ExpireDate[i] = value[i];
                }
            }
        }

        public sbyte[] StartDelivDate
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->StartDelivDate != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->StartDelivDate[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->StartDelivDate[i] = value[i];
                }
            }
        }

        public sbyte[] EndDelivDate
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->EndDelivDate != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->EndDelivDate[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->EndDelivDate[i] = value[i];
                }
            }
        }

        public sbyte InstLifePhase
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->InstLifePhase;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->InstLifePhase = value;
            }
        }

        public int IsTrading
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->IsTrading;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->IsTrading = value;
            }
        }

        public sbyte PositionType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->PositionType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->PositionType = value;
            }
        }

        public sbyte PositionDateType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->PositionDateType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->PositionDateType = value;
            }
        }

        public double LongMarginRatio
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->LongMarginRatio;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->LongMarginRatio = value;
            }
        }

        public double ShortMarginRatio
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ShortMarginRatio;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ShortMarginRatio = value;
            }
        }

        public sbyte MaxMarginSideAlgorithm
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->MaxMarginSideAlgorithm;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->MaxMarginSideAlgorithm = value;
            }
        }

        public sbyte[] Reserve4
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve4 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve4[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->reserve4[i] = value[i];
                }
            }
        }

        public double StrikePrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->StrikePrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->StrikePrice = value;
            }
        }

        public sbyte OptionsType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->OptionsType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->OptionsType = value;
            }
        }

        public double UnderlyingMultiple
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->UnderlyingMultiple;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->UnderlyingMultiple = value;
            }
        }

        public sbyte CombinationType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->CombinationType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->CombinationType = value;
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeInstID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ExchangeInstID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ExchangeInstID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ExchangeInstID[i] = value[i];
                }
            }
        }

        public sbyte[] ProductID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ProductID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ProductID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->ProductID[i] = value[i];
                }
            }
        }

        public sbyte[] UnderlyingInstrID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->UnderlyingInstrID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->UnderlyingInstrID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentField.__Internal*)__Instance)->UnderlyingInstrID[i] = value[i];
                }
            }
        }
    }

    /// <summary>经纪公司</summary>
    public unsafe partial class CThostFtdcBrokerField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 108)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte BrokerAbbr[9];

            [FieldOffset(20)]
            internal fixed sbyte BrokerName[81];

            [FieldOffset(104)]
            internal int IsActive;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcBrokerField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcBrokerField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcBrokerField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcBrokerField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcBrokerField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcBrokerField __CreateInstance(global::ProxyCTP.CThostFtdcBrokerField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcBrokerField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcBrokerField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcBrokerField.__Internal));
            *(global::ProxyCTP.CThostFtdcBrokerField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcBrokerField(global::ProxyCTP.CThostFtdcBrokerField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcBrokerField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcBrokerField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcBrokerField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcBrokerField(global::ProxyCTP.CThostFtdcBrokerField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcBrokerField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcBrokerField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerAbbr
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->BrokerAbbr != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->BrokerAbbr[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->BrokerAbbr[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->BrokerName != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->BrokerName[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->BrokerName[i] = value[i];
                }
            }
        }

        public int IsActive
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->IsActive;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcBrokerField.__Internal*)__Instance)->IsActive = value;
            }
        }
    }

    /// <summary>交易所交易员</summary>
    public unsafe partial class CThostFtdcTraderField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 100)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(9)]
            internal fixed sbyte TraderID[21];

            [FieldOffset(30)]
            internal fixed sbyte ParticipantID[11];

            [FieldOffset(41)]
            internal fixed sbyte Password[41];

            [FieldOffset(84)]
            internal int InstallCount;

            [FieldOffset(88)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(99)]
            internal sbyte OrderCancelAlg;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcTraderField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcTraderField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcTraderField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcTraderField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcTraderField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcTraderField __CreateInstance(global::ProxyCTP.CThostFtdcTraderField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcTraderField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcTraderField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTraderField.__Internal));
            *(global::ProxyCTP.CThostFtdcTraderField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcTraderField(global::ProxyCTP.CThostFtdcTraderField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcTraderField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcTraderField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTraderField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcTraderField(global::ProxyCTP.CThostFtdcTraderField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTraderField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcTraderField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcTraderField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] TraderID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->TraderID != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->TraderID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->TraderID[i] = value[i];
                }
            }
        }

        public sbyte[] ParticipantID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->ParticipantID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->ParticipantID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->ParticipantID[i] = value[i];
                }
            }
        }

        public sbyte[] Password
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->Password != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->Password[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->Password[i] = value[i];
                }
            }
        }

        public int InstallCount
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->InstallCount;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->InstallCount = value;
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte OrderCancelAlg
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->OrderCancelAlg;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcTraderField.__Internal*)__Instance)->OrderCancelAlg = value;
            }
        }
    }

    /// <summary>投资者</summary>
    public unsafe partial class CThostFtdcInvestorField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 396)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte InvestorID[13];

            [FieldOffset(13)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(24)]
            internal fixed sbyte InvestorGroupID[13];

            [FieldOffset(37)]
            internal fixed sbyte InvestorName[81];

            [FieldOffset(118)]
            internal sbyte IdentifiedCardType;

            [FieldOffset(119)]
            internal fixed sbyte IdentifiedCardNo[51];

            [FieldOffset(172)]
            internal int IsActive;

            [FieldOffset(176)]
            internal fixed sbyte Telephone[41];

            [FieldOffset(217)]
            internal fixed sbyte Address[101];

            [FieldOffset(318)]
            internal fixed sbyte OpenDate[9];

            [FieldOffset(327)]
            internal fixed sbyte Mobile[41];

            [FieldOffset(368)]
            internal fixed sbyte CommModelID[13];

            [FieldOffset(381)]
            internal fixed sbyte MarginModelID[13];

            [FieldOffset(394)]
            internal sbyte IsOrderFreq;

            [FieldOffset(395)]
            internal sbyte IsOpenVolLimit;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcInvestorField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcInvestorField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcInvestorField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcInvestorField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcInvestorField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcInvestorField __CreateInstance(global::ProxyCTP.CThostFtdcInvestorField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcInvestorField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcInvestorField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInvestorField.__Internal));
            *(global::ProxyCTP.CThostFtdcInvestorField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcInvestorField(global::ProxyCTP.CThostFtdcInvestorField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcInvestorField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcInvestorField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInvestorField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcInvestorField(global::ProxyCTP.CThostFtdcInvestorField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInvestorField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcInvestorField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] InvestorID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->InvestorID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->InvestorID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->InvestorID[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] InvestorGroupID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->InvestorGroupID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->InvestorGroupID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->InvestorGroupID[i] = value[i];
                }
            }
        }

        public sbyte[] InvestorName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->InvestorName != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->InvestorName[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->InvestorName[i] = value[i];
                }
            }
        }

        public sbyte IdentifiedCardType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IdentifiedCardType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IdentifiedCardType = value;
            }
        }

        public sbyte[] IdentifiedCardNo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IdentifiedCardNo != null)
                {
                    __value = new sbyte[51];
                    for (int i = 0; i < 51; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IdentifiedCardNo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 51; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IdentifiedCardNo[i] = value[i];
                }
            }
        }

        public int IsActive
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IsActive;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IsActive = value;
            }
        }

        public sbyte[] Telephone
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->Telephone != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->Telephone[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->Telephone[i] = value[i];
                }
            }
        }

        public sbyte[] Address
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->Address != null)
                {
                    __value = new sbyte[101];
                    for (int i = 0; i < 101; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->Address[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 101; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->Address[i] = value[i];
                }
            }
        }

        public sbyte[] OpenDate
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->OpenDate != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->OpenDate[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->OpenDate[i] = value[i];
                }
            }
        }

        public sbyte[] Mobile
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->Mobile != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->Mobile[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->Mobile[i] = value[i];
                }
            }
        }

        public sbyte[] CommModelID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->CommModelID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->CommModelID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->CommModelID[i] = value[i];
                }
            }
        }

        public sbyte[] MarginModelID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->MarginModelID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->MarginModelID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->MarginModelID[i] = value[i];
                }
            }
        }

        public sbyte IsOrderFreq
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IsOrderFreq;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IsOrderFreq = value;
            }
        }

        public sbyte IsOpenVolLimit
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IsOpenVolLimit;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInvestorField.__Internal*)__Instance)->IsOpenVolLimit = value;
            }
        }
    }

    /// <summary>交易编码</summary>
    public unsafe partial class CThostFtdcTradingCodeField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 76)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte InvestorID[13];

            [FieldOffset(13)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(24)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(33)]
            internal fixed sbyte ClientID[11];

            [FieldOffset(44)]
            internal int IsActive;

            [FieldOffset(48)]
            internal sbyte ClientIDType;

            [FieldOffset(49)]
            internal fixed sbyte BranchID[9];

            [FieldOffset(58)]
            internal sbyte BizType;

            [FieldOffset(59)]
            internal fixed sbyte InvestUnitID[17];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcTradingCodeField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcTradingCodeField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcTradingCodeField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcTradingCodeField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcTradingCodeField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcTradingCodeField __CreateInstance(global::ProxyCTP.CThostFtdcTradingCodeField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcTradingCodeField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcTradingCodeField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTradingCodeField.__Internal));
            *(global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcTradingCodeField(global::ProxyCTP.CThostFtdcTradingCodeField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcTradingCodeField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcTradingCodeField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTradingCodeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcTradingCodeField(global::ProxyCTP.CThostFtdcTradingCodeField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTradingCodeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcTradingCodeField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] InvestorID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->InvestorID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->InvestorID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->InvestorID[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] ClientID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->ClientID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->ClientID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->ClientID[i] = value[i];
                }
            }
        }

        public int IsActive
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->IsActive;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->IsActive = value;
            }
        }

        public sbyte ClientIDType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->ClientIDType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->ClientIDType = value;
            }
        }

        public sbyte[] BranchID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->BranchID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->BranchID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->BranchID[i] = value[i];
                }
            }
        }

        public sbyte BizType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->BizType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->BizType = value;
            }
        }

        public sbyte[] InvestUnitID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->InvestUnitID != null)
                {
                    __value = new sbyte[17];
                    for (int i = 0; i < 17; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->InvestUnitID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 17; i++)
                        ((global::ProxyCTP.CThostFtdcTradingCodeField.__Internal*)__Instance)->InvestUnitID[i] = value[i];
                }
            }
        }
    }

  
    /// <summary>深度行情</summary>
    public unsafe partial class CThostFtdcDepthMarketDataField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 584)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(9)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(40)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(49)]
            internal fixed sbyte reserve2[31];

            [FieldOffset(80)]
            internal double LastPrice;

            [FieldOffset(88)]
            internal double PreSettlementPrice;

            [FieldOffset(96)]
            internal double PreClosePrice;

            [FieldOffset(104)]
            internal double PreOpenInterest;

            [FieldOffset(112)]
            internal double OpenPrice;

            [FieldOffset(120)]
            internal double HighestPrice;

            [FieldOffset(128)]
            internal double LowestPrice;

            [FieldOffset(136)]
            internal int Volume;

            [FieldOffset(144)]
            internal double Turnover;

            [FieldOffset(152)]
            internal double OpenInterest;

            [FieldOffset(160)]
            internal double ClosePrice;

            [FieldOffset(168)]
            internal double SettlementPrice;

            [FieldOffset(176)]
            internal double UpperLimitPrice;

            [FieldOffset(184)]
            internal double LowerLimitPrice;

            [FieldOffset(192)]
            internal double PreDelta;

            [FieldOffset(200)]
            internal double CurrDelta;

            [FieldOffset(208)]
            internal fixed sbyte UpdateTime[9];

            [FieldOffset(220)]
            internal int UpdateMillisec;

            [FieldOffset(224)]
            internal double BidPrice1;

            [FieldOffset(232)]
            internal int BidVolume1;

            [FieldOffset(240)]
            internal double AskPrice1;

            [FieldOffset(248)]
            internal int AskVolume1;

            [FieldOffset(256)]
            internal double BidPrice2;

            [FieldOffset(264)]
            internal int BidVolume2;

            [FieldOffset(272)]
            internal double AskPrice2;

            [FieldOffset(280)]
            internal int AskVolume2;

            [FieldOffset(288)]
            internal double BidPrice3;

            [FieldOffset(296)]
            internal int BidVolume3;

            [FieldOffset(304)]
            internal double AskPrice3;

            [FieldOffset(312)]
            internal int AskVolume3;

            [FieldOffset(320)]
            internal double BidPrice4;

            [FieldOffset(328)]
            internal int BidVolume4;

            [FieldOffset(336)]
            internal double AskPrice4;

            [FieldOffset(344)]
            internal int AskVolume4;

            [FieldOffset(352)]
            internal double BidPrice5;

            [FieldOffset(360)]
            internal int BidVolume5;

            [FieldOffset(368)]
            internal double AskPrice5;

            [FieldOffset(376)]
            internal int AskVolume5;

            [FieldOffset(384)]
            internal double AveragePrice;

            [FieldOffset(392)]
            internal fixed sbyte ActionDay[9];

            [FieldOffset(401)]
            internal fixed sbyte InstrumentID[81];

            [FieldOffset(482)]
            internal fixed sbyte ExchangeInstID[81];

            [FieldOffset(568)]
            internal double BandingUpperPrice;

            [FieldOffset(576)]
            internal double BandingLowerPrice;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcDepthMarketDataField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcDepthMarketDataField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcDepthMarketDataField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcDepthMarketDataField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcDepthMarketDataField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcDepthMarketDataField __CreateInstance(global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcDepthMarketDataField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal));
            *(global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcDepthMarketDataField(global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcDepthMarketDataField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcDepthMarketDataField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcDepthMarketDataField(global::ProxyCTP.CThostFtdcDepthMarketDataField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcDepthMarketDataField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve2
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->reserve2 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->reserve2[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->reserve2[i] = value[i];
                }
            }
        }

        public double LastPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->LastPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->LastPrice = value;
            }
        }

        public double PreSettlementPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->PreSettlementPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->PreSettlementPrice = value;
            }
        }

        public double PreClosePrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->PreClosePrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->PreClosePrice = value;
            }
        }

        public double PreOpenInterest
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->PreOpenInterest;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->PreOpenInterest = value;
            }
        }

        public double OpenPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->OpenPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->OpenPrice = value;
            }
        }

        public double HighestPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->HighestPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->HighestPrice = value;
            }
        }

        public double LowestPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->LowestPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->LowestPrice = value;
            }
        }

        public int Volume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->Volume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->Volume = value;
            }
        }

        public double Turnover
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->Turnover;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->Turnover = value;
            }
        }

        public double OpenInterest
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->OpenInterest;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->OpenInterest = value;
            }
        }

        public double ClosePrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ClosePrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ClosePrice = value;
            }
        }

        public double SettlementPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->SettlementPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->SettlementPrice = value;
            }
        }

        public double UpperLimitPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->UpperLimitPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->UpperLimitPrice = value;
            }
        }

        public double LowerLimitPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->LowerLimitPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->LowerLimitPrice = value;
            }
        }

        public double PreDelta
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->PreDelta;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->PreDelta = value;
            }
        }

        public double CurrDelta
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->CurrDelta;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->CurrDelta = value;
            }
        }

        public sbyte[] UpdateTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->UpdateTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->UpdateTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->UpdateTime[i] = value[i];
                }
            }
        }

        public int UpdateMillisec
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->UpdateMillisec;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->UpdateMillisec = value;
            }
        }

        public double BidPrice1
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidPrice1;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidPrice1 = value;
            }
        }

        public int BidVolume1
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidVolume1;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidVolume1 = value;
            }
        }

        public double AskPrice1
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskPrice1;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskPrice1 = value;
            }
        }

        public int AskVolume1
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskVolume1;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskVolume1 = value;
            }
        }

        public double BidPrice2
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidPrice2;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidPrice2 = value;
            }
        }

        public int BidVolume2
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidVolume2;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidVolume2 = value;
            }
        }

        public double AskPrice2
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskPrice2;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskPrice2 = value;
            }
        }

        public int AskVolume2
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskVolume2;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskVolume2 = value;
            }
        }

        public double BidPrice3
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidPrice3;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidPrice3 = value;
            }
        }

        public int BidVolume3
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidVolume3;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidVolume3 = value;
            }
        }

        public double AskPrice3
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskPrice3;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskPrice3 = value;
            }
        }

        public int AskVolume3
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskVolume3;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskVolume3 = value;
            }
        }

        public double BidPrice4
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidPrice4;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidPrice4 = value;
            }
        }

        public int BidVolume4
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidVolume4;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidVolume4 = value;
            }
        }

        public double AskPrice4
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskPrice4;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskPrice4 = value;
            }
        }

        public int AskVolume4
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskVolume4;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskVolume4 = value;
            }
        }

        public double BidPrice5
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidPrice5;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidPrice5 = value;
            }
        }

        public int BidVolume5
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidVolume5;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BidVolume5 = value;
            }
        }

        public double AskPrice5
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskPrice5;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskPrice5 = value;
            }
        }

        public int AskVolume5
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskVolume5;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AskVolume5 = value;
            }
        }

        public double AveragePrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AveragePrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->AveragePrice = value;
            }
        }

        public sbyte[] ActionDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ActionDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ActionDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ActionDay[i] = value[i];
                }
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeInstID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ExchangeInstID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ExchangeInstID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->ExchangeInstID[i] = value[i];
                }
            }
        }

        public double BandingUpperPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BandingUpperPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BandingUpperPrice = value;
            }
        }

        public double BandingLowerPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BandingLowerPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepthMarketDataField.__Internal*)__Instance)->BandingLowerPrice = value;
            }
        }
    }

    /// <summary>投资者合约交易权限</summary>
    public unsafe partial class CThostFtdcInstrumentTradingRightField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 138)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(31)]
            internal sbyte InvestorRange;

            [FieldOffset(32)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(43)]
            internal fixed sbyte InvestorID[13];

            [FieldOffset(56)]
            internal sbyte TradingRight;

            [FieldOffset(57)]
            internal fixed sbyte InstrumentID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcInstrumentTradingRightField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcInstrumentTradingRightField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcInstrumentTradingRightField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcInstrumentTradingRightField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcInstrumentTradingRightField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcInstrumentTradingRightField __CreateInstance(global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcInstrumentTradingRightField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal));
            *(global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcInstrumentTradingRightField(global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcInstrumentTradingRightField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcInstrumentTradingRightField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcInstrumentTradingRightField(global::ProxyCTP.CThostFtdcInstrumentTradingRightField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcInstrumentTradingRightField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte InvestorRange
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->InvestorRange;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->InvestorRange = value;
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] InvestorID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->InvestorID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->InvestorID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->InvestorID[i] = value[i];
                }
            }
        }

        public sbyte TradingRight
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->TradingRight;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->TradingRight = value;
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentTradingRightField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }
    }

    /// <summary>发给做市商的询价请求</summary>
    public unsafe partial class CThostFtdcForQuoteRspField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 169)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(9)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(40)]
            internal fixed sbyte ForQuoteSysID[21];

            [FieldOffset(61)]
            internal fixed sbyte ForQuoteTime[9];

            [FieldOffset(70)]
            internal fixed sbyte ActionDay[9];

            [FieldOffset(79)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(88)]
            internal fixed sbyte InstrumentID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcForQuoteRspField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcForQuoteRspField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcForQuoteRspField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcForQuoteRspField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcForQuoteRspField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcForQuoteRspField __CreateInstance(global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcForQuoteRspField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal));
            *(global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcForQuoteRspField(global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcForQuoteRspField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcForQuoteRspField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcForQuoteRspField(global::ProxyCTP.CThostFtdcForQuoteRspField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcForQuoteRspField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] ForQuoteSysID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ForQuoteSysID != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ForQuoteSysID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ForQuoteSysID[i] = value[i];
                }
            }
        }

        public sbyte[] ForQuoteTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ForQuoteTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ForQuoteTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ForQuoteTime[i] = value[i];
                }
            }
        }

        public sbyte[] ActionDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ActionDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ActionDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ActionDay[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcForQuoteRspField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }
    }


    /// <summary>当前时间</summary>
    public unsafe partial class CThostFtdcCurrentTimeField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 36)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte CurrDate[9];

            [FieldOffset(9)]
            internal fixed sbyte CurrTime[9];

            [FieldOffset(20)]
            internal int CurrMillisec;

            [FieldOffset(24)]
            internal fixed sbyte ActionDay[9];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcCurrentTimeField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcCurrentTimeField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcCurrentTimeField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcCurrentTimeField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcCurrentTimeField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcCurrentTimeField __CreateInstance(global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcCurrentTimeField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal));
            *(global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcCurrentTimeField(global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcCurrentTimeField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcCurrentTimeField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcCurrentTimeField(global::ProxyCTP.CThostFtdcCurrentTimeField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcCurrentTimeField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] CurrDate
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->CurrDate != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->CurrDate[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->CurrDate[i] = value[i];
                }
            }
        }

        public sbyte[] CurrTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->CurrTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->CurrTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->CurrTime[i] = value[i];
                }
            }
        }

        public int CurrMillisec
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->CurrMillisec;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->CurrMillisec = value;
            }
        }

        public sbyte[] ActionDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->ActionDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->ActionDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcCurrentTimeField.__Internal*)__Instance)->ActionDay[i] = value[i];
                }
            }
        }
    }

    /// <summary>通讯阶段</summary>
    public unsafe partial class CThostFtdcCommPhaseField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 34)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(10)]
            internal short CommPhaseNo;

            [FieldOffset(12)]
            internal fixed sbyte SystemID[21];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcCommPhaseField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcCommPhaseField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcCommPhaseField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcCommPhaseField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcCommPhaseField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcCommPhaseField __CreateInstance(global::ProxyCTP.CThostFtdcCommPhaseField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcCommPhaseField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcCommPhaseField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcCommPhaseField.__Internal));
            *(global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcCommPhaseField(global::ProxyCTP.CThostFtdcCommPhaseField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcCommPhaseField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcCommPhaseField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcCommPhaseField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcCommPhaseField(global::ProxyCTP.CThostFtdcCommPhaseField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcCommPhaseField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcCommPhaseField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public short CommPhaseNo
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)__Instance)->CommPhaseNo;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)__Instance)->CommPhaseNo = value;
            }
        }

        public sbyte[] SystemID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)__Instance)->SystemID != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)__Instance)->SystemID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcCommPhaseField.__Internal*)__Instance)->SystemID[i] = value[i];
                }
            }
        }
    }

    /// <summary>登录信息</summary>
    public unsafe partial class CThostFtdcLoginInfoField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 420)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int FrontID;

            [FieldOffset(4)]
            internal int SessionID;

            [FieldOffset(8)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(19)]
            internal fixed sbyte UserID[16];

            [FieldOffset(35)]
            internal fixed sbyte LoginDate[9];

            [FieldOffset(44)]
            internal fixed sbyte LoginTime[9];

            [FieldOffset(53)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(69)]
            internal fixed sbyte UserProductInfo[11];

            [FieldOffset(80)]
            internal fixed sbyte InterfaceProductInfo[11];

            [FieldOffset(91)]
            internal fixed sbyte ProtocolInfo[11];

            [FieldOffset(102)]
            internal fixed sbyte SystemName[41];

            [FieldOffset(143)]
            internal fixed sbyte PasswordDeprecated[41];

            [FieldOffset(184)]
            internal fixed sbyte MaxOrderRef[13];

            [FieldOffset(197)]
            internal fixed sbyte SHFETime[9];

            [FieldOffset(206)]
            internal fixed sbyte DCETime[9];

            [FieldOffset(215)]
            internal fixed sbyte CZCETime[9];

            [FieldOffset(224)]
            internal fixed sbyte FFEXTime[9];

            [FieldOffset(233)]
            internal fixed sbyte MacAddress[21];

            [FieldOffset(254)]
            internal fixed sbyte OneTimePassword[41];

            [FieldOffset(295)]
            internal fixed sbyte INETime[9];

            [FieldOffset(304)]
            internal int IsQryControl;

            [FieldOffset(308)]
            internal fixed sbyte LoginRemark[36];

            [FieldOffset(344)]
            internal fixed sbyte Password[41];

            [FieldOffset(385)]
            internal fixed sbyte IPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcLoginInfoField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcLoginInfoField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcLoginInfoField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcLoginInfoField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcLoginInfoField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcLoginInfoField __CreateInstance(global::ProxyCTP.CThostFtdcLoginInfoField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcLoginInfoField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcLoginInfoField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcLoginInfoField.__Internal));
            *(global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcLoginInfoField(global::ProxyCTP.CThostFtdcLoginInfoField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcLoginInfoField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcLoginInfoField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcLoginInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcLoginInfoField(global::ProxyCTP.CThostFtdcLoginInfoField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcLoginInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcLoginInfoField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int FrontID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->FrontID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->FrontID = value;
            }
        }

        public int SessionID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->SessionID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->SessionID = value;
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] LoginDate
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->LoginDate != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->LoginDate[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->LoginDate[i] = value[i];
                }
            }
        }

        public sbyte[] LoginTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->LoginTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->LoginTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->LoginTime[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] UserProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->UserProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->UserProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->UserProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] InterfaceProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->InterfaceProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->InterfaceProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->InterfaceProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] ProtocolInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->ProtocolInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->ProtocolInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->ProtocolInfo[i] = value[i];
                }
            }
        }

        public sbyte[] SystemName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->SystemName != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->SystemName[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->SystemName[i] = value[i];
                }
            }
        }

        public sbyte[] PasswordDeprecated
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->PasswordDeprecated != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->PasswordDeprecated[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->PasswordDeprecated[i] = value[i];
                }
            }
        }

        public sbyte[] MaxOrderRef
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->MaxOrderRef != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->MaxOrderRef[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->MaxOrderRef[i] = value[i];
                }
            }
        }

        public sbyte[] SHFETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->SHFETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->SHFETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->SHFETime[i] = value[i];
                }
            }
        }

        public sbyte[] DCETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->DCETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->DCETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->DCETime[i] = value[i];
                }
            }
        }

        public sbyte[] CZCETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->CZCETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->CZCETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->CZCETime[i] = value[i];
                }
            }
        }

        public sbyte[] FFEXTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->FFEXTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->FFEXTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->FFEXTime[i] = value[i];
                }
            }
        }

        public sbyte[] MacAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->MacAddress != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->MacAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->MacAddress[i] = value[i];
                }
            }
        }

        public sbyte[] OneTimePassword
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->OneTimePassword != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->OneTimePassword[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->OneTimePassword[i] = value[i];
                }
            }
        }

        public sbyte[] INETime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->INETime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->INETime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->INETime[i] = value[i];
                }
            }
        }

        public int IsQryControl
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->IsQryControl;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->IsQryControl = value;
            }
        }

        public sbyte[] LoginRemark
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->LoginRemark != null)
                {
                    __value = new sbyte[36];
                    for (int i = 0; i < 36; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->LoginRemark[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 36; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->LoginRemark[i] = value[i];
                }
            }
        }

        public sbyte[] Password
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->Password != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->Password[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->Password[i] = value[i];
                }
            }
        }

        public sbyte[] IPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->IPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->IPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcLoginInfoField.__Internal*)__Instance)->IPAddress[i] = value[i];
                }
            }
        }
    }

    /// <summary>登录信息</summary>
    public unsafe partial class CThostFtdcLogoutAllField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 52)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int FrontID;

            [FieldOffset(4)]
            internal int SessionID;

            [FieldOffset(8)]
            internal fixed sbyte SystemName[41];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcLogoutAllField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcLogoutAllField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcLogoutAllField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcLogoutAllField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcLogoutAllField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcLogoutAllField __CreateInstance(global::ProxyCTP.CThostFtdcLogoutAllField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcLogoutAllField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcLogoutAllField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcLogoutAllField.__Internal));
            *(global::ProxyCTP.CThostFtdcLogoutAllField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcLogoutAllField(global::ProxyCTP.CThostFtdcLogoutAllField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcLogoutAllField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcLogoutAllField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcLogoutAllField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcLogoutAllField(global::ProxyCTP.CThostFtdcLogoutAllField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcLogoutAllField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcLogoutAllField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcLogoutAllField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcLogoutAllField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int FrontID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcLogoutAllField.__Internal*)__Instance)->FrontID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcLogoutAllField.__Internal*)__Instance)->FrontID = value;
            }
        }

        public int SessionID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcLogoutAllField.__Internal*)__Instance)->SessionID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcLogoutAllField.__Internal*)__Instance)->SessionID = value;
            }
        }

        public sbyte[] SystemName
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLogoutAllField.__Internal*)__Instance)->SystemName != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLogoutAllField.__Internal*)__Instance)->SystemName[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcLogoutAllField.__Internal*)__Instance)->SystemName[i] = value[i];
                }
            }
        }
    }

    /// <summary>前置状态</summary>
    public unsafe partial class CThostFtdcFrontStatusField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 28)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int FrontID;

            [FieldOffset(4)]
            internal fixed sbyte LastReportDate[9];

            [FieldOffset(13)]
            internal fixed sbyte LastReportTime[9];

            [FieldOffset(24)]
            internal int IsActive;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcFrontStatusField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcFrontStatusField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcFrontStatusField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcFrontStatusField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcFrontStatusField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcFrontStatusField __CreateInstance(global::ProxyCTP.CThostFtdcFrontStatusField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcFrontStatusField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcFrontStatusField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcFrontStatusField.__Internal));
            *(global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcFrontStatusField(global::ProxyCTP.CThostFtdcFrontStatusField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcFrontStatusField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcFrontStatusField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcFrontStatusField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcFrontStatusField(global::ProxyCTP.CThostFtdcFrontStatusField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcFrontStatusField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcFrontStatusField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int FrontID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance)->FrontID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance)->FrontID = value;
            }
        }

        public sbyte[] LastReportDate
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance)->LastReportDate != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance)->LastReportDate[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance)->LastReportDate[i] = value[i];
                }
            }
        }

        public sbyte[] LastReportTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance)->LastReportTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance)->LastReportTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance)->LastReportTime[i] = value[i];
                }
            }
        }

        public int IsActive
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance)->IsActive;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcFrontStatusField.__Internal*)__Instance)->IsActive = value;
            }
        }
    }

    /// <summary>用户口令变更</summary>
    public unsafe partial class CThostFtdcUserPasswordUpdateField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 109)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte UserID[16];

            [FieldOffset(27)]
            internal fixed sbyte OldPassword[41];

            [FieldOffset(68)]
            internal fixed sbyte NewPassword[41];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcUserPasswordUpdateField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcUserPasswordUpdateField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcUserPasswordUpdateField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcUserPasswordUpdateField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcUserPasswordUpdateField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcUserPasswordUpdateField __CreateInstance(global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcUserPasswordUpdateField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal));
            *(global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcUserPasswordUpdateField(global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcUserPasswordUpdateField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcUserPasswordUpdateField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcUserPasswordUpdateField(global::ProxyCTP.CThostFtdcUserPasswordUpdateField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcUserPasswordUpdateField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] OldPassword
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->OldPassword != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->OldPassword[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->OldPassword[i] = value[i];
                }
            }
        }

        public sbyte[] NewPassword
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->NewPassword != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->NewPassword[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcUserPasswordUpdateField.__Internal*)__Instance)->NewPassword[i] = value[i];
                }
            }
        }
    }

    
    /// <summary>用户会话</summary>
    public unsafe partial class CThostFtdcUserSessionField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 192)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int FrontID;

            [FieldOffset(4)]
            internal int SessionID;

            [FieldOffset(8)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(19)]
            internal fixed sbyte UserID[16];

            [FieldOffset(35)]
            internal fixed sbyte LoginDate[9];

            [FieldOffset(44)]
            internal fixed sbyte LoginTime[9];

            [FieldOffset(53)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(69)]
            internal fixed sbyte UserProductInfo[11];

            [FieldOffset(80)]
            internal fixed sbyte InterfaceProductInfo[11];

            [FieldOffset(91)]
            internal fixed sbyte ProtocolInfo[11];

            [FieldOffset(102)]
            internal fixed sbyte MacAddress[21];

            [FieldOffset(123)]
            internal fixed sbyte LoginRemark[36];

            [FieldOffset(159)]
            internal fixed sbyte IPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcUserSessionField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcUserSessionField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcUserSessionField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcUserSessionField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcUserSessionField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcUserSessionField __CreateInstance(global::ProxyCTP.CThostFtdcUserSessionField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcUserSessionField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcUserSessionField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserSessionField.__Internal));
            *(global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcUserSessionField(global::ProxyCTP.CThostFtdcUserSessionField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcUserSessionField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcUserSessionField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserSessionField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcUserSessionField(global::ProxyCTP.CThostFtdcUserSessionField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserSessionField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcUserSessionField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int FrontID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->FrontID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->FrontID = value;
            }
        }

        public int SessionID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->SessionID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->SessionID = value;
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] LoginDate
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->LoginDate != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->LoginDate[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->LoginDate[i] = value[i];
                }
            }
        }

        public sbyte[] LoginTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->LoginTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->LoginTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->LoginTime[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] UserProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->UserProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->UserProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->UserProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] InterfaceProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->InterfaceProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->InterfaceProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->InterfaceProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] ProtocolInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->ProtocolInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->ProtocolInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->ProtocolInfo[i] = value[i];
                }
            }
        }

        public sbyte[] MacAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->MacAddress != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->MacAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->MacAddress[i] = value[i];
                }
            }
        }

        public sbyte[] LoginRemark
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->LoginRemark != null)
                {
                    __value = new sbyte[36];
                    for (int i = 0; i < 36; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->LoginRemark[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 36; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->LoginRemark[i] = value[i];
                }
            }
        }

        public sbyte[] IPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->IPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->IPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcUserSessionField.__Internal*)__Instance)->IPAddress[i] = value[i];
                }
            }
        }
    }

    
    /// <summary>禁止登录IP</summary>
    public unsafe partial class CThostFtdcLoginForbiddenIPField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 49)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(16)]
            internal fixed sbyte IPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcLoginForbiddenIPField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcLoginForbiddenIPField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcLoginForbiddenIPField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcLoginForbiddenIPField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcLoginForbiddenIPField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcLoginForbiddenIPField __CreateInstance(global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcLoginForbiddenIPField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal));
            *(global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcLoginForbiddenIPField(global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcLoginForbiddenIPField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcLoginForbiddenIPField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcLoginForbiddenIPField(global::ProxyCTP.CThostFtdcLoginForbiddenIPField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcLoginForbiddenIPField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] IPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal*)__Instance)->IPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal*)__Instance)->IPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcLoginForbiddenIPField.__Internal*)__Instance)->IPAddress[i] = value[i];
                }
            }
        }
    }

    /// <summary>IP列表</summary>
    public unsafe partial class CThostFtdcIPListField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(16)]
            internal int IsWhite;

            [FieldOffset(20)]
            internal fixed sbyte IPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcIPListField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcIPListField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcIPListField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcIPListField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcIPListField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcIPListField __CreateInstance(global::ProxyCTP.CThostFtdcIPListField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcIPListField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcIPListField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcIPListField.__Internal));
            *(global::ProxyCTP.CThostFtdcIPListField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcIPListField(global::ProxyCTP.CThostFtdcIPListField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcIPListField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcIPListField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcIPListField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcIPListField(global::ProxyCTP.CThostFtdcIPListField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcIPListField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcIPListField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcIPListField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcIPListField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcIPListField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcIPListField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcIPListField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public int IsWhite
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcIPListField.__Internal*)__Instance)->IsWhite;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcIPListField.__Internal*)__Instance)->IsWhite = value;
            }
        }

        public sbyte[] IPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcIPListField.__Internal*)__Instance)->IPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcIPListField.__Internal*)__Instance)->IPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcIPListField.__Internal*)__Instance)->IPAddress[i] = value[i];
                }
            }
        }
    }

   
    /// <summary>市场行情</summary>
    public unsafe partial class CThostFtdcMarketDataField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 400)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(9)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(40)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(49)]
            internal fixed sbyte reserve2[31];

            [FieldOffset(80)]
            internal double LastPrice;

            [FieldOffset(88)]
            internal double PreSettlementPrice;

            [FieldOffset(96)]
            internal double PreClosePrice;

            [FieldOffset(104)]
            internal double PreOpenInterest;

            [FieldOffset(112)]
            internal double OpenPrice;

            [FieldOffset(120)]
            internal double HighestPrice;

            [FieldOffset(128)]
            internal double LowestPrice;

            [FieldOffset(136)]
            internal int Volume;

            [FieldOffset(144)]
            internal double Turnover;

            [FieldOffset(152)]
            internal double OpenInterest;

            [FieldOffset(160)]
            internal double ClosePrice;

            [FieldOffset(168)]
            internal double SettlementPrice;

            [FieldOffset(176)]
            internal double UpperLimitPrice;

            [FieldOffset(184)]
            internal double LowerLimitPrice;

            [FieldOffset(192)]
            internal double PreDelta;

            [FieldOffset(200)]
            internal double CurrDelta;

            [FieldOffset(208)]
            internal fixed sbyte UpdateTime[9];

            [FieldOffset(220)]
            internal int UpdateMillisec;

            [FieldOffset(224)]
            internal fixed sbyte ActionDay[9];

            [FieldOffset(233)]
            internal fixed sbyte InstrumentID[81];

            [FieldOffset(314)]
            internal fixed sbyte ExchangeInstID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataField __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataField.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataField(global::ProxyCTP.CThostFtdcMarketDataField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataField(global::ProxyCTP.CThostFtdcMarketDataField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve2
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->reserve2 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->reserve2[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->reserve2[i] = value[i];
                }
            }
        }

        public double LastPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->LastPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->LastPrice = value;
            }
        }

        public double PreSettlementPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->PreSettlementPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->PreSettlementPrice = value;
            }
        }

        public double PreClosePrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->PreClosePrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->PreClosePrice = value;
            }
        }

        public double PreOpenInterest
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->PreOpenInterest;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->PreOpenInterest = value;
            }
        }

        public double OpenPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->OpenPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->OpenPrice = value;
            }
        }

        public double HighestPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->HighestPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->HighestPrice = value;
            }
        }

        public double LowestPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->LowestPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->LowestPrice = value;
            }
        }

        public int Volume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->Volume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->Volume = value;
            }
        }

        public double Turnover
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->Turnover;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->Turnover = value;
            }
        }

        public double OpenInterest
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->OpenInterest;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->OpenInterest = value;
            }
        }

        public double ClosePrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ClosePrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ClosePrice = value;
            }
        }

        public double SettlementPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->SettlementPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->SettlementPrice = value;
            }
        }

        public double UpperLimitPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->UpperLimitPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->UpperLimitPrice = value;
            }
        }

        public double LowerLimitPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->LowerLimitPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->LowerLimitPrice = value;
            }
        }

        public double PreDelta
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->PreDelta;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->PreDelta = value;
            }
        }

        public double CurrDelta
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->CurrDelta;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->CurrDelta = value;
            }
        }

        public sbyte[] UpdateTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->UpdateTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->UpdateTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->UpdateTime[i] = value[i];
                }
            }
        }

        public int UpdateMillisec
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->UpdateMillisec;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->UpdateMillisec = value;
            }
        }

        public sbyte[] ActionDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ActionDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ActionDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ActionDay[i] = value[i];
                }
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeInstID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ExchangeInstID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ExchangeInstID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataField.__Internal*)__Instance)->ExchangeInstID[i] = value[i];
                }
            }
        }
    }

    /// <summary>行情基础属性</summary>
    public unsafe partial class CThostFtdcMarketDataBaseField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(16)]
            internal double PreSettlementPrice;

            [FieldOffset(24)]
            internal double PreClosePrice;

            [FieldOffset(32)]
            internal double PreOpenInterest;

            [FieldOffset(40)]
            internal double PreDelta;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataBaseField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataBaseField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataBaseField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataBaseField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataBaseField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataBaseField __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataBaseField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataBaseField(global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataBaseField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataBaseField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataBaseField(global::ProxyCTP.CThostFtdcMarketDataBaseField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataBaseField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public double PreSettlementPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->PreSettlementPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->PreSettlementPrice = value;
            }
        }

        public double PreClosePrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->PreClosePrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->PreClosePrice = value;
            }
        }

        public double PreOpenInterest
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->PreOpenInterest;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->PreOpenInterest = value;
            }
        }

        public double PreDelta
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->PreDelta;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBaseField.__Internal*)__Instance)->PreDelta = value;
            }
        }
    }

    /// <summary>行情静态属性</summary>
    public unsafe partial class CThostFtdcMarketDataStaticField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double OpenPrice;

            [FieldOffset(8)]
            internal double HighestPrice;

            [FieldOffset(16)]
            internal double LowestPrice;

            [FieldOffset(24)]
            internal double ClosePrice;

            [FieldOffset(32)]
            internal double UpperLimitPrice;

            [FieldOffset(40)]
            internal double LowerLimitPrice;

            [FieldOffset(48)]
            internal double SettlementPrice;

            [FieldOffset(56)]
            internal double CurrDelta;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataStaticField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataStaticField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataStaticField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataStaticField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataStaticField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataStaticField __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataStaticField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataStaticField(global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataStaticField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataStaticField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataStaticField(global::ProxyCTP.CThostFtdcMarketDataStaticField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataStaticField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double OpenPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->OpenPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->OpenPrice = value;
            }
        }

        public double HighestPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->HighestPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->HighestPrice = value;
            }
        }

        public double LowestPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->LowestPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->LowestPrice = value;
            }
        }

        public double ClosePrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->ClosePrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->ClosePrice = value;
            }
        }

        public double UpperLimitPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->UpperLimitPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->UpperLimitPrice = value;
            }
        }

        public double LowerLimitPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->LowerLimitPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->LowerLimitPrice = value;
            }
        }

        public double SettlementPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->SettlementPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->SettlementPrice = value;
            }
        }

        public double CurrDelta
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->CurrDelta;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataStaticField.__Internal*)__Instance)->CurrDelta = value;
            }
        }
    }

    /// <summary>行情最新成交属性</summary>
    public unsafe partial class CThostFtdcMarketDataLastMatchField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double LastPrice;

            [FieldOffset(8)]
            internal int Volume;

            [FieldOffset(16)]
            internal double Turnover;

            [FieldOffset(24)]
            internal double OpenInterest;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataLastMatchField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataLastMatchField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataLastMatchField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataLastMatchField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataLastMatchField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataLastMatchField __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataLastMatchField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataLastMatchField(global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataLastMatchField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataLastMatchField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataLastMatchField(global::ProxyCTP.CThostFtdcMarketDataLastMatchField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataLastMatchField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double LastPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)__Instance)->LastPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)__Instance)->LastPrice = value;
            }
        }

        public int Volume
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)__Instance)->Volume;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)__Instance)->Volume = value;
            }
        }

        public double Turnover
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)__Instance)->Turnover;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)__Instance)->Turnover = value;
            }
        }

        public double OpenInterest
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)__Instance)->OpenInterest;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataLastMatchField.__Internal*)__Instance)->OpenInterest = value;
            }
        }
    }

    /// <summary>行情最优价属性</summary>
    public unsafe partial class CThostFtdcMarketDataBestPriceField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double BidPrice1;

            [FieldOffset(8)]
            internal int BidVolume1;

            [FieldOffset(16)]
            internal double AskPrice1;

            [FieldOffset(24)]
            internal int AskVolume1;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataBestPriceField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataBestPriceField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataBestPriceField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataBestPriceField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataBestPriceField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataBestPriceField __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataBestPriceField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataBestPriceField(global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataBestPriceField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataBestPriceField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataBestPriceField(global::ProxyCTP.CThostFtdcMarketDataBestPriceField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataBestPriceField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double BidPrice1
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)__Instance)->BidPrice1;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)__Instance)->BidPrice1 = value;
            }
        }

        public int BidVolume1
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)__Instance)->BidVolume1;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)__Instance)->BidVolume1 = value;
            }
        }

        public double AskPrice1
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)__Instance)->AskPrice1;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)__Instance)->AskPrice1 = value;
            }
        }

        public int AskVolume1
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)__Instance)->AskVolume1;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBestPriceField.__Internal*)__Instance)->AskVolume1 = value;
            }
        }
    }

    /// <summary>行情申买二、三属性</summary>
    public unsafe partial class CThostFtdcMarketDataBid23Field : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double BidPrice2;

            [FieldOffset(8)]
            internal int BidVolume2;

            [FieldOffset(16)]
            internal double BidPrice3;

            [FieldOffset(24)]
            internal int BidVolume3;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataBid23Field@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataBid23Field> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataBid23Field>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataBid23Field __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataBid23Field(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataBid23Field __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataBid23Field(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataBid23Field(global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataBid23Field(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataBid23Field()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataBid23Field(global::ProxyCTP.CThostFtdcMarketDataBid23Field _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataBid23Field __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double BidPrice2
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)__Instance)->BidPrice2;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)__Instance)->BidPrice2 = value;
            }
        }

        public int BidVolume2
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)__Instance)->BidVolume2;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)__Instance)->BidVolume2 = value;
            }
        }

        public double BidPrice3
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)__Instance)->BidPrice3;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)__Instance)->BidPrice3 = value;
            }
        }

        public int BidVolume3
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)__Instance)->BidVolume3;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBid23Field.__Internal*)__Instance)->BidVolume3 = value;
            }
        }
    }

    /// <summary>行情申卖二、三属性</summary>
    public unsafe partial class CThostFtdcMarketDataAsk23Field : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double AskPrice2;

            [FieldOffset(8)]
            internal int AskVolume2;

            [FieldOffset(16)]
            internal double AskPrice3;

            [FieldOffset(24)]
            internal int AskVolume3;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataAsk23Field@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataAsk23Field> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataAsk23Field>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataAsk23Field __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataAsk23Field(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataAsk23Field __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataAsk23Field(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataAsk23Field(global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataAsk23Field(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataAsk23Field()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataAsk23Field(global::ProxyCTP.CThostFtdcMarketDataAsk23Field _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataAsk23Field __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double AskPrice2
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)__Instance)->AskPrice2;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)__Instance)->AskPrice2 = value;
            }
        }

        public int AskVolume2
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)__Instance)->AskVolume2;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)__Instance)->AskVolume2 = value;
            }
        }

        public double AskPrice3
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)__Instance)->AskPrice3;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)__Instance)->AskPrice3 = value;
            }
        }

        public int AskVolume3
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)__Instance)->AskVolume3;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataAsk23Field.__Internal*)__Instance)->AskVolume3 = value;
            }
        }
    }

    /// <summary>行情申买四、五属性</summary>
    public unsafe partial class CThostFtdcMarketDataBid45Field : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double BidPrice4;

            [FieldOffset(8)]
            internal int BidVolume4;

            [FieldOffset(16)]
            internal double BidPrice5;

            [FieldOffset(24)]
            internal int BidVolume5;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataBid45Field@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataBid45Field> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataBid45Field>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataBid45Field __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataBid45Field(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataBid45Field __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataBid45Field(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataBid45Field(global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataBid45Field(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataBid45Field()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataBid45Field(global::ProxyCTP.CThostFtdcMarketDataBid45Field _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataBid45Field __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double BidPrice4
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)__Instance)->BidPrice4;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)__Instance)->BidPrice4 = value;
            }
        }

        public int BidVolume4
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)__Instance)->BidVolume4;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)__Instance)->BidVolume4 = value;
            }
        }

        public double BidPrice5
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)__Instance)->BidPrice5;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)__Instance)->BidPrice5 = value;
            }
        }

        public int BidVolume5
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)__Instance)->BidVolume5;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBid45Field.__Internal*)__Instance)->BidVolume5 = value;
            }
        }
    }

    /// <summary>行情申卖四、五属性</summary>
    public unsafe partial class CThostFtdcMarketDataAsk45Field : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double AskPrice4;

            [FieldOffset(8)]
            internal int AskVolume4;

            [FieldOffset(16)]
            internal double AskPrice5;

            [FieldOffset(24)]
            internal int AskVolume5;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataAsk45Field@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataAsk45Field> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataAsk45Field>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataAsk45Field __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataAsk45Field(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataAsk45Field __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataAsk45Field(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataAsk45Field(global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataAsk45Field(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataAsk45Field()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataAsk45Field(global::ProxyCTP.CThostFtdcMarketDataAsk45Field _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataAsk45Field __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double AskPrice4
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)__Instance)->AskPrice4;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)__Instance)->AskPrice4 = value;
            }
        }

        public int AskVolume4
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)__Instance)->AskVolume4;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)__Instance)->AskVolume4 = value;
            }
        }

        public double AskPrice5
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)__Instance)->AskPrice5;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)__Instance)->AskPrice5 = value;
            }
        }

        public int AskVolume5
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)__Instance)->AskVolume5;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataAsk45Field.__Internal*)__Instance)->AskVolume5 = value;
            }
        }
    }

    /// <summary>行情更新时间属性</summary>
    public unsafe partial class CThostFtdcMarketDataUpdateTimeField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 136)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(31)]
            internal fixed sbyte UpdateTime[9];

            [FieldOffset(40)]
            internal int UpdateMillisec;

            [FieldOffset(44)]
            internal fixed sbyte ActionDay[9];

            [FieldOffset(53)]
            internal fixed sbyte InstrumentID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataUpdateTimeField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataUpdateTimeField(global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataUpdateTimeField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataUpdateTimeField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataUpdateTimeField(global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] UpdateTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->UpdateTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->UpdateTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->UpdateTime[i] = value[i];
                }
            }
        }

        public int UpdateMillisec
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->UpdateMillisec;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->UpdateMillisec = value;
            }
        }

        public sbyte[] ActionDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->ActionDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->ActionDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->ActionDay[i] = value[i];
                }
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataUpdateTimeField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }
    }

    /// <summary>行情上下带价</summary>
    public unsafe partial class CThostFtdcMarketDataBandingPriceField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double BandingUpperPrice;

            [FieldOffset(8)]
            internal double BandingLowerPrice;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataBandingPriceField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataBandingPriceField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataBandingPriceField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataBandingPriceField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataBandingPriceField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataBandingPriceField __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataBandingPriceField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataBandingPriceField(global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataBandingPriceField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataBandingPriceField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataBandingPriceField(global::ProxyCTP.CThostFtdcMarketDataBandingPriceField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataBandingPriceField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double BandingUpperPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal*)__Instance)->BandingUpperPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal*)__Instance)->BandingUpperPrice = value;
            }
        }

        public double BandingLowerPrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal*)__Instance)->BandingLowerPrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMarketDataBandingPriceField.__Internal*)__Instance)->BandingLowerPrice = value;
            }
        }
    }

    /// <summary>行情交易所代码属性</summary>
    public unsafe partial class CThostFtdcMarketDataExchangeField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 9)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte ExchangeID[9];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMarketDataExchangeField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataExchangeField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMarketDataExchangeField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMarketDataExchangeField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataExchangeField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMarketDataExchangeField __CreateInstance(global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMarketDataExchangeField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal));
            *(global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMarketDataExchangeField(global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMarketDataExchangeField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMarketDataExchangeField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMarketDataExchangeField(global::ProxyCTP.CThostFtdcMarketDataExchangeField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMarketDataExchangeField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcMarketDataExchangeField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }
    }

    /// <summary>指定的合约</summary>
    public unsafe partial class CThostFtdcSpecificInstrumentField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 112)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(31)]
            internal fixed sbyte InstrumentID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcSpecificInstrumentField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcSpecificInstrumentField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcSpecificInstrumentField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcSpecificInstrumentField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcSpecificInstrumentField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcSpecificInstrumentField __CreateInstance(global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcSpecificInstrumentField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal));
            *(global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcSpecificInstrumentField(global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcSpecificInstrumentField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcSpecificInstrumentField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcSpecificInstrumentField(global::ProxyCTP.CThostFtdcSpecificInstrumentField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcSpecificInstrumentField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcSpecificInstrumentField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }
    }

    /// <summary>合约状态</summary>
    public unsafe partial class CThostFtdcInstrumentStatusField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 260)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(9)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(40)]
            internal fixed sbyte SettlementGroupID[9];

            [FieldOffset(49)]
            internal fixed sbyte reserve2[31];

            [FieldOffset(80)]
            internal sbyte InstrumentStatus;

            [FieldOffset(84)]
            internal int TradingSegmentSN;

            [FieldOffset(88)]
            internal fixed sbyte EnterTime[9];

            [FieldOffset(97)]
            internal sbyte EnterReason;

            [FieldOffset(98)]
            internal fixed sbyte ExchangeInstID[81];

            [FieldOffset(179)]
            internal fixed sbyte InstrumentID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcInstrumentStatusField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcInstrumentStatusField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcInstrumentStatusField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcInstrumentStatusField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcInstrumentStatusField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcInstrumentStatusField __CreateInstance(global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcInstrumentStatusField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal));
            *(global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcInstrumentStatusField(global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcInstrumentStatusField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcInstrumentStatusField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcInstrumentStatusField(global::ProxyCTP.CThostFtdcInstrumentStatusField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcInstrumentStatusField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] SettlementGroupID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->SettlementGroupID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->SettlementGroupID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->SettlementGroupID[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve2
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->reserve2 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->reserve2[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->reserve2[i] = value[i];
                }
            }
        }

        public sbyte InstrumentStatus
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->InstrumentStatus;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->InstrumentStatus = value;
            }
        }

        public int TradingSegmentSN
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->TradingSegmentSN;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->TradingSegmentSN = value;
            }
        }

        public sbyte[] EnterTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->EnterTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->EnterTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->EnterTime[i] = value[i];
                }
            }
        }

        public sbyte EnterReason
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->EnterReason;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->EnterReason = value;
            }
        }

        public sbyte[] ExchangeInstID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->ExchangeInstID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->ExchangeInstID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->ExchangeInstID[i] = value[i];
                }
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcInstrumentStatusField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }
    }

    /// <summary>查询合约状态</summary>
    public unsafe partial class CThostFtdcQryInstrumentStatusField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 121)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(9)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(40)]
            internal fixed sbyte ExchangeInstID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcQryInstrumentStatusField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryInstrumentStatusField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryInstrumentStatusField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcQryInstrumentStatusField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryInstrumentStatusField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcQryInstrumentStatusField __CreateInstance(global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryInstrumentStatusField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal));
            *(global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcQryInstrumentStatusField(global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcQryInstrumentStatusField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcQryInstrumentStatusField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcQryInstrumentStatusField(global::ProxyCTP.CThostFtdcQryInstrumentStatusField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcQryInstrumentStatusField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeInstID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)__Instance)->ExchangeInstID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)__Instance)->ExchangeInstID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcQryInstrumentStatusField.__Internal*)__Instance)->ExchangeInstID[i] = value[i];
                }
            }
        }
    }

    /// <summary>投资者账户</summary>
    public unsafe partial class CThostFtdcInvestorAccountField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 41)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte InvestorID[13];

            [FieldOffset(24)]
            internal fixed sbyte AccountID[13];

            [FieldOffset(37)]
            internal fixed sbyte CurrencyID[4];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcInvestorAccountField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcInvestorAccountField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcInvestorAccountField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcInvestorAccountField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcInvestorAccountField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcInvestorAccountField __CreateInstance(global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcInvestorAccountField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal));
            *(global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcInvestorAccountField(global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcInvestorAccountField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcInvestorAccountField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcInvestorAccountField(global::ProxyCTP.CThostFtdcInvestorAccountField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcInvestorAccountField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] InvestorID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->InvestorID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->InvestorID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->InvestorID[i] = value[i];
                }
            }
        }

        public sbyte[] AccountID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->AccountID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->AccountID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->AccountID[i] = value[i];
                }
            }
        }

        public sbyte[] CurrencyID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->CurrencyID != null)
                {
                    __value = new sbyte[4];
                    for (int i = 0; i < 4; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->CurrencyID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 4; i++)
                        ((global::ProxyCTP.CThostFtdcInvestorAccountField.__Internal*)__Instance)->CurrencyID[i] = value[i];
                }
            }
        }
    }

    
    /// <summary>校验投资者密码</summary>
    public unsafe partial class CThostFtdcVerifyInvestorPasswordField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 65)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte InvestorID[13];

            [FieldOffset(24)]
            internal fixed sbyte Password[41];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcVerifyInvestorPasswordField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField __CreateInstance(global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal));
            *(global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcVerifyInvestorPasswordField(global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcVerifyInvestorPasswordField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcVerifyInvestorPasswordField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcVerifyInvestorPasswordField(global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] InvestorID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)__Instance)->InvestorID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)__Instance)->InvestorID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)__Instance)->InvestorID[i] = value[i];
                }
            }
        }

        public sbyte[] Password
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)__Instance)->Password != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)__Instance)->Password[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcVerifyInvestorPasswordField.__Internal*)__Instance)->Password[i] = value[i];
                }
            }
        }
    }

    /// <summary>用户IP</summary>
    public unsafe partial class CThostFtdcUserIPField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 146)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte UserID[16];

            [FieldOffset(27)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(43)]
            internal fixed sbyte reserve2[16];

            [FieldOffset(59)]
            internal fixed sbyte MacAddress[21];

            [FieldOffset(80)]
            internal fixed sbyte IPAddress[33];

            [FieldOffset(113)]
            internal fixed sbyte IPMask[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcUserIPField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcUserIPField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcUserIPField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcUserIPField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcUserIPField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcUserIPField __CreateInstance(global::ProxyCTP.CThostFtdcUserIPField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcUserIPField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcUserIPField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserIPField.__Internal));
            *(global::ProxyCTP.CThostFtdcUserIPField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcUserIPField(global::ProxyCTP.CThostFtdcUserIPField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcUserIPField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcUserIPField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserIPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcUserIPField(global::ProxyCTP.CThostFtdcUserIPField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserIPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcUserIPField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve2
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->reserve2 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->reserve2[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->reserve2[i] = value[i];
                }
            }
        }

        public sbyte[] MacAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->MacAddress != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->MacAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->MacAddress[i] = value[i];
                }
            }
        }

        public sbyte[] IPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->IPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->IPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->IPAddress[i] = value[i];
                }
            }
        }

        public sbyte[] IPMask
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->IPMask != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->IPMask[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcUserIPField.__Internal*)__Instance)->IPMask[i] = value[i];
                }
            }
        }
    }

    /// <summary>用户事件通知信息</summary>
    public unsafe partial class CThostFtdcTradingNoticeInfoField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 560)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte InvestorID[13];

            [FieldOffset(24)]
            internal fixed sbyte SendTime[9];

            [FieldOffset(33)]
            internal fixed sbyte FieldContent[501];

            [FieldOffset(534)]
            internal short SequenceSeries;

            [FieldOffset(536)]
            internal int SequenceNo;

            [FieldOffset(540)]
            internal fixed sbyte InvestUnitID[17];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcTradingNoticeInfoField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcTradingNoticeInfoField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcTradingNoticeInfoField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcTradingNoticeInfoField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcTradingNoticeInfoField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcTradingNoticeInfoField __CreateInstance(global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcTradingNoticeInfoField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal));
            *(global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcTradingNoticeInfoField(global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcTradingNoticeInfoField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcTradingNoticeInfoField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcTradingNoticeInfoField(global::ProxyCTP.CThostFtdcTradingNoticeInfoField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcTradingNoticeInfoField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] InvestorID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->InvestorID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->InvestorID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->InvestorID[i] = value[i];
                }
            }
        }

        public sbyte[] SendTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->SendTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->SendTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->SendTime[i] = value[i];
                }
            }
        }

        public sbyte[] FieldContent
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->FieldContent != null)
                {
                    __value = new sbyte[501];
                    for (int i = 0; i < 501; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->FieldContent[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 501; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->FieldContent[i] = value[i];
                }
            }
        }

        public short SequenceSeries
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->SequenceSeries;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->SequenceSeries = value;
            }
        }

        public int SequenceNo
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->SequenceNo;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->SequenceNo = value;
            }
        }

        public sbyte[] InvestUnitID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->InvestUnitID != null)
                {
                    __value = new sbyte[17];
                    for (int i = 0; i < 17; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->InvestUnitID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 17; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeInfoField.__Internal*)__Instance)->InvestUnitID[i] = value[i];
                }
            }
        }
    }

    /// <summary>用户事件通知</summary>
    public unsafe partial class CThostFtdcTradingNoticeField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 580)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal sbyte InvestorRange;

            [FieldOffset(12)]
            internal fixed sbyte InvestorID[13];

            [FieldOffset(26)]
            internal short SequenceSeries;

            [FieldOffset(28)]
            internal fixed sbyte UserID[16];

            [FieldOffset(44)]
            internal fixed sbyte SendTime[9];

            [FieldOffset(56)]
            internal int SequenceNo;

            [FieldOffset(60)]
            internal fixed sbyte FieldContent[501];

            [FieldOffset(561)]
            internal fixed sbyte InvestUnitID[17];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcTradingNoticeField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcTradingNoticeField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcTradingNoticeField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcTradingNoticeField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcTradingNoticeField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcTradingNoticeField __CreateInstance(global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcTradingNoticeField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal));
            *(global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcTradingNoticeField(global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcTradingNoticeField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcTradingNoticeField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcTradingNoticeField(global::ProxyCTP.CThostFtdcTradingNoticeField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcTradingNoticeField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte InvestorRange
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->InvestorRange;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->InvestorRange = value;
            }
        }

        public sbyte[] InvestorID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->InvestorID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->InvestorID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->InvestorID[i] = value[i];
                }
            }
        }

        public short SequenceSeries
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->SequenceSeries;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->SequenceSeries = value;
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] SendTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->SendTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->SendTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->SendTime[i] = value[i];
                }
            }
        }

        public int SequenceNo
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->SequenceNo;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->SequenceNo = value;
            }
        }

        public sbyte[] FieldContent
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->FieldContent != null)
                {
                    __value = new sbyte[501];
                    for (int i = 0; i < 501; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->FieldContent[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 501; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->FieldContent[i] = value[i];
                }
            }
        }

        public sbyte[] InvestUnitID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->InvestUnitID != null)
                {
                    __value = new sbyte[17];
                    for (int i = 0; i < 17; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->InvestUnitID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 17; i++)
                        ((global::ProxyCTP.CThostFtdcTradingNoticeField.__Internal*)__Instance)->InvestUnitID[i] = value[i];
                }
            }
        }
    }

    /// <summary>查询交易事件通知</summary>
    public unsafe partial class CThostFtdcQryTradingNoticeField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 41)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte InvestorID[13];

            [FieldOffset(24)]
            internal fixed sbyte InvestUnitID[17];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcQryTradingNoticeField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryTradingNoticeField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryTradingNoticeField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcQryTradingNoticeField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryTradingNoticeField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcQryTradingNoticeField __CreateInstance(global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryTradingNoticeField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal));
            *(global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcQryTradingNoticeField(global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcQryTradingNoticeField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcQryTradingNoticeField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcQryTradingNoticeField(global::ProxyCTP.CThostFtdcQryTradingNoticeField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcQryTradingNoticeField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] InvestorID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)__Instance)->InvestorID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)__Instance)->InvestorID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)__Instance)->InvestorID[i] = value[i];
                }
            }
        }

        public sbyte[] InvestUnitID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)__Instance)->InvestUnitID != null)
                {
                    __value = new sbyte[17];
                    for (int i = 0; i < 17; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)__Instance)->InvestUnitID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 17; i++)
                        ((global::ProxyCTP.CThostFtdcQryTradingNoticeField.__Internal*)__Instance)->InvestUnitID[i] = value[i];
                }
            }
        }
    }

    
    /// <summary>查询交易所状态</summary>
    public unsafe partial class CThostFtdcQryExchangeSequenceField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 9)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte ExchangeID[9];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcQryExchangeSequenceField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryExchangeSequenceField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryExchangeSequenceField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcQryExchangeSequenceField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryExchangeSequenceField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcQryExchangeSequenceField __CreateInstance(global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryExchangeSequenceField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal));
            *(global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcQryExchangeSequenceField(global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcQryExchangeSequenceField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcQryExchangeSequenceField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcQryExchangeSequenceField(global::ProxyCTP.CThostFtdcQryExchangeSequenceField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcQryExchangeSequenceField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcQryExchangeSequenceField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }
    }

    /// <summary>交易所状态</summary>
    public unsafe partial class CThostFtdcExchangeSequenceField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 20)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(12)]
            internal int SequenceNo;

            [FieldOffset(16)]
            internal sbyte MarketStatus;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcExchangeSequenceField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcExchangeSequenceField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcExchangeSequenceField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcExchangeSequenceField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcExchangeSequenceField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcExchangeSequenceField __CreateInstance(global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcExchangeSequenceField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal));
            *(global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcExchangeSequenceField(global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcExchangeSequenceField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcExchangeSequenceField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcExchangeSequenceField(global::ProxyCTP.CThostFtdcExchangeSequenceField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcExchangeSequenceField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public int SequenceNo
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal*)__Instance)->SequenceNo;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal*)__Instance)->SequenceNo = value;
            }
        }

        public sbyte MarketStatus
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal*)__Instance)->MarketStatus;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcExchangeSequenceField.__Internal*)__Instance)->MarketStatus = value;
            }
        }
    }

   
    /// <summary>MulticastInstrument</summary>
    public unsafe partial class CThostFtdcMulticastInstrumentField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 152)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int TopicID;

            [FieldOffset(4)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(36)]
            internal int InstrumentNo;

            [FieldOffset(40)]
            internal double CodePrice;

            [FieldOffset(48)]
            internal int VolumeMultiple;

            [FieldOffset(56)]
            internal double PriceTick;

            [FieldOffset(64)]
            internal fixed sbyte InstrumentID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcMulticastInstrumentField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMulticastInstrumentField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMulticastInstrumentField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMulticastInstrumentField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMulticastInstrumentField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMulticastInstrumentField __CreateInstance(global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMulticastInstrumentField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal));
            *(global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcMulticastInstrumentField(global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcMulticastInstrumentField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcMulticastInstrumentField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcMulticastInstrumentField(global::ProxyCTP.CThostFtdcMulticastInstrumentField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMulticastInstrumentField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int TopicID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->TopicID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->TopicID = value;
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public int InstrumentNo
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->InstrumentNo;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->InstrumentNo = value;
            }
        }

        public double CodePrice
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->CodePrice;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->CodePrice = value;
            }
        }

        public int VolumeMultiple
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->VolumeMultiple;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->VolumeMultiple = value;
            }
        }

        public double PriceTick
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->PriceTick;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->PriceTick = value;
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcMulticastInstrumentField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }
    }

    /// <summary>QryMulticastInstrument</summary>
    public unsafe partial class CThostFtdcQryMulticastInstrumentField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 116)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int TopicID;

            [FieldOffset(4)]
            internal fixed sbyte reserve1[31];

            [FieldOffset(35)]
            internal fixed sbyte InstrumentID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcQryMulticastInstrumentField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryMulticastInstrumentField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryMulticastInstrumentField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcQryMulticastInstrumentField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryMulticastInstrumentField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcQryMulticastInstrumentField __CreateInstance(global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryMulticastInstrumentField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal));
            *(global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcQryMulticastInstrumentField(global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcQryMulticastInstrumentField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcQryMulticastInstrumentField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcQryMulticastInstrumentField(global::ProxyCTP.CThostFtdcQryMulticastInstrumentField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcQryMulticastInstrumentField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int TopicID
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)__Instance)->TopicID;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)__Instance)->TopicID = value;
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcQryMulticastInstrumentField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }
    }

    
    /// <summary>短信验证码生成的回复</summary>
    public unsafe partial class CThostFtdcRspGenUserTextField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int UserTextSeq;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcRspGenUserTextField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspGenUserTextField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspGenUserTextField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcRspGenUserTextField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspGenUserTextField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcRspGenUserTextField __CreateInstance(global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspGenUserTextField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal));
            *(global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcRspGenUserTextField(global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcRspGenUserTextField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcRspGenUserTextField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcRspGenUserTextField(global::ProxyCTP.CThostFtdcRspGenUserTextField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcRspGenUserTextField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int UserTextSeq
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal*)__Instance)->UserTextSeq;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcRspGenUserTextField.__Internal*)__Instance)->UserTextSeq = value;
            }
        }
    }

    /// <summary>用户发出带图形验证码的登录请求请求</summary>
    public unsafe partial class CThostFtdcReqUserLoginWithCaptchaField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 264)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(9)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(20)]
            internal fixed sbyte UserID[16];

            [FieldOffset(36)]
            internal fixed sbyte Password[41];

            [FieldOffset(77)]
            internal fixed sbyte UserProductInfo[11];

            [FieldOffset(88)]
            internal fixed sbyte InterfaceProductInfo[11];

            [FieldOffset(99)]
            internal fixed sbyte ProtocolInfo[11];

            [FieldOffset(110)]
            internal fixed sbyte MacAddress[21];

            [FieldOffset(131)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(147)]
            internal fixed sbyte LoginRemark[36];

            [FieldOffset(183)]
            internal fixed sbyte Captcha[41];

            [FieldOffset(224)]
            internal int ClientIPPort;

            [FieldOffset(228)]
            internal fixed sbyte ClientIPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcReqUserLoginWithCaptchaField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField __CreateInstance(global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal));
            *(global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcReqUserLoginWithCaptchaField(global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcReqUserLoginWithCaptchaField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcReqUserLoginWithCaptchaField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcReqUserLoginWithCaptchaField(global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] Password
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->Password != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->Password[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->Password[i] = value[i];
                }
            }
        }

        public sbyte[] UserProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->UserProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->UserProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->UserProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] InterfaceProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->InterfaceProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->InterfaceProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->InterfaceProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] ProtocolInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->ProtocolInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->ProtocolInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->ProtocolInfo[i] = value[i];
                }
            }
        }

        public sbyte[] MacAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->MacAddress != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->MacAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->MacAddress[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] LoginRemark
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->LoginRemark != null)
                {
                    __value = new sbyte[36];
                    for (int i = 0; i < 36; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->LoginRemark[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 36; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->LoginRemark[i] = value[i];
                }
            }
        }

        public sbyte[] Captcha
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->Captcha != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->Captcha[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->Captcha[i] = value[i];
                }
            }
        }

        public int ClientIPPort
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->ClientIPPort;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->ClientIPPort = value;
            }
        }

        public sbyte[] ClientIPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->ClientIPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->ClientIPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithCaptchaField.__Internal*)__Instance)->ClientIPAddress[i] = value[i];
                }
            }
        }
    }

    /// <summary>用户发出带短信验证码的登录请求请求</summary>
    public unsafe partial class CThostFtdcReqUserLoginWithTextField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 264)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(9)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(20)]
            internal fixed sbyte UserID[16];

            [FieldOffset(36)]
            internal fixed sbyte Password[41];

            [FieldOffset(77)]
            internal fixed sbyte UserProductInfo[11];

            [FieldOffset(88)]
            internal fixed sbyte InterfaceProductInfo[11];

            [FieldOffset(99)]
            internal fixed sbyte ProtocolInfo[11];

            [FieldOffset(110)]
            internal fixed sbyte MacAddress[21];

            [FieldOffset(131)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(147)]
            internal fixed sbyte LoginRemark[36];

            [FieldOffset(183)]
            internal fixed sbyte Text[41];

            [FieldOffset(224)]
            internal int ClientIPPort;

            [FieldOffset(228)]
            internal fixed sbyte ClientIPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcReqUserLoginWithTextField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqUserLoginWithTextField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqUserLoginWithTextField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcReqUserLoginWithTextField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqUserLoginWithTextField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcReqUserLoginWithTextField __CreateInstance(global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqUserLoginWithTextField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal));
            *(global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcReqUserLoginWithTextField(global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcReqUserLoginWithTextField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcReqUserLoginWithTextField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcReqUserLoginWithTextField(global::ProxyCTP.CThostFtdcReqUserLoginWithTextField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcReqUserLoginWithTextField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] Password
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->Password != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->Password[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->Password[i] = value[i];
                }
            }
        }

        public sbyte[] UserProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->UserProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->UserProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->UserProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] InterfaceProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->InterfaceProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->InterfaceProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->InterfaceProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] ProtocolInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->ProtocolInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->ProtocolInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->ProtocolInfo[i] = value[i];
                }
            }
        }

        public sbyte[] MacAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->MacAddress != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->MacAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->MacAddress[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] LoginRemark
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->LoginRemark != null)
                {
                    __value = new sbyte[36];
                    for (int i = 0; i < 36; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->LoginRemark[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 36; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->LoginRemark[i] = value[i];
                }
            }
        }

        public sbyte[] Text
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->Text != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->Text[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->Text[i] = value[i];
                }
            }
        }

        public int ClientIPPort
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->ClientIPPort;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->ClientIPPort = value;
            }
        }

        public sbyte[] ClientIPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->ClientIPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->ClientIPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithTextField.__Internal*)__Instance)->ClientIPAddress[i] = value[i];
                }
            }
        }
    }

    /// <summary>用户发出带动态验证码的登录请求请求</summary>
    public unsafe partial class CThostFtdcReqUserLoginWithOTPField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 264)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(9)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(20)]
            internal fixed sbyte UserID[16];

            [FieldOffset(36)]
            internal fixed sbyte Password[41];

            [FieldOffset(77)]
            internal fixed sbyte UserProductInfo[11];

            [FieldOffset(88)]
            internal fixed sbyte InterfaceProductInfo[11];

            [FieldOffset(99)]
            internal fixed sbyte ProtocolInfo[11];

            [FieldOffset(110)]
            internal fixed sbyte MacAddress[21];

            [FieldOffset(131)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(147)]
            internal fixed sbyte LoginRemark[36];

            [FieldOffset(183)]
            internal fixed sbyte OTPPassword[41];

            [FieldOffset(224)]
            internal int ClientIPPort;

            [FieldOffset(228)]
            internal fixed sbyte ClientIPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcReqUserLoginWithOTPField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField __CreateInstance(global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal));
            *(global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcReqUserLoginWithOTPField(global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcReqUserLoginWithOTPField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcReqUserLoginWithOTPField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcReqUserLoginWithOTPField(global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] Password
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->Password != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->Password[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->Password[i] = value[i];
                }
            }
        }

        public sbyte[] UserProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->UserProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->UserProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->UserProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] InterfaceProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->InterfaceProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->InterfaceProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->InterfaceProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] ProtocolInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->ProtocolInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->ProtocolInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->ProtocolInfo[i] = value[i];
                }
            }
        }

        public sbyte[] MacAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->MacAddress != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->MacAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->MacAddress[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public sbyte[] LoginRemark
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->LoginRemark != null)
                {
                    __value = new sbyte[36];
                    for (int i = 0; i < 36; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->LoginRemark[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 36; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->LoginRemark[i] = value[i];
                }
            }
        }

        public sbyte[] OTPPassword
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->OTPPassword != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->OTPPassword[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->OTPPassword[i] = value[i];
                }
            }
        }

        public int ClientIPPort
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->ClientIPPort;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->ClientIPPort = value;
            }
        }

        public sbyte[] ClientIPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->ClientIPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->ClientIPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginWithOTPField.__Internal*)__Instance)->ClientIPAddress[i] = value[i];
                }
            }
        }
    }

    /// <summary>api握手请求</summary>
    public unsafe partial class CThostFtdcReqApiHandshakeField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 31)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte CryptoKeyVersion[31];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcReqApiHandshakeField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqApiHandshakeField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqApiHandshakeField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcReqApiHandshakeField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqApiHandshakeField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcReqApiHandshakeField __CreateInstance(global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqApiHandshakeField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal));
            *(global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcReqApiHandshakeField(global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcReqApiHandshakeField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcReqApiHandshakeField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcReqApiHandshakeField(global::ProxyCTP.CThostFtdcReqApiHandshakeField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcReqApiHandshakeField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] CryptoKeyVersion
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal*)__Instance)->CryptoKeyVersion != null)
                {
                    __value = new sbyte[31];
                    for (int i = 0; i < 31; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal*)__Instance)->CryptoKeyVersion[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 31; i++)
                        ((global::ProxyCTP.CThostFtdcReqApiHandshakeField.__Internal*)__Instance)->CryptoKeyVersion[i] = value[i];
                }
            }
        }
    }

    /// <summary>front发给api的握手回复</summary>
    public unsafe partial class CThostFtdcRspApiHandshakeField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 312)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int FrontHandshakeDataLen;

            [FieldOffset(4)]
            internal fixed sbyte FrontHandshakeData[301];

            [FieldOffset(308)]
            internal int IsApiAuthEnabled;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcRspApiHandshakeField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspApiHandshakeField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcRspApiHandshakeField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcRspApiHandshakeField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspApiHandshakeField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcRspApiHandshakeField __CreateInstance(global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcRspApiHandshakeField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal));
            *(global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcRspApiHandshakeField(global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcRspApiHandshakeField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcRspApiHandshakeField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcRspApiHandshakeField(global::ProxyCTP.CThostFtdcRspApiHandshakeField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcRspApiHandshakeField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int FrontHandshakeDataLen
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal*)__Instance)->FrontHandshakeDataLen;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal*)__Instance)->FrontHandshakeDataLen = value;
            }
        }

        public sbyte[] FrontHandshakeData
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal*)__Instance)->FrontHandshakeData != null)
                {
                    __value = new sbyte[301];
                    for (int i = 0; i < 301; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal*)__Instance)->FrontHandshakeData[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 301; i++)
                        ((global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal*)__Instance)->FrontHandshakeData[i] = value[i];
                }
            }
        }

        public int IsApiAuthEnabled
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal*)__Instance)->IsApiAuthEnabled;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcRspApiHandshakeField.__Internal*)__Instance)->IsApiAuthEnabled = value;
            }
        }
    }

    /// <summary>api给front的验证key的请求</summary>
    public unsafe partial class CThostFtdcReqVerifyApiKeyField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 308)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int ApiHandshakeDataLen;

            [FieldOffset(4)]
            internal fixed sbyte ApiHandshakeData[301];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcReqVerifyApiKeyField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqVerifyApiKeyField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqVerifyApiKeyField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcReqVerifyApiKeyField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqVerifyApiKeyField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcReqVerifyApiKeyField __CreateInstance(global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqVerifyApiKeyField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal));
            *(global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcReqVerifyApiKeyField(global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcReqVerifyApiKeyField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcReqVerifyApiKeyField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcReqVerifyApiKeyField(global::ProxyCTP.CThostFtdcReqVerifyApiKeyField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcReqVerifyApiKeyField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int ApiHandshakeDataLen
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal*)__Instance)->ApiHandshakeDataLen;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal*)__Instance)->ApiHandshakeDataLen = value;
            }
        }

        public sbyte[] ApiHandshakeData
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal*)__Instance)->ApiHandshakeData != null)
                {
                    __value = new sbyte[301];
                    for (int i = 0; i < 301; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal*)__Instance)->ApiHandshakeData[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 301; i++)
                        ((global::ProxyCTP.CThostFtdcReqVerifyApiKeyField.__Internal*)__Instance)->ApiHandshakeData[i] = value[i];
                }
            }
        }
    }

    /// <summary>操作员组织架构关系</summary>
    public unsafe partial class CThostFtdcDepartmentUserField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 41)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte UserID[16];

            [FieldOffset(27)]
            internal sbyte InvestorRange;

            [FieldOffset(28)]
            internal fixed sbyte InvestorID[13];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcDepartmentUserField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcDepartmentUserField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcDepartmentUserField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcDepartmentUserField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcDepartmentUserField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcDepartmentUserField __CreateInstance(global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcDepartmentUserField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal));
            *(global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcDepartmentUserField(global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcDepartmentUserField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcDepartmentUserField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcDepartmentUserField(global::ProxyCTP.CThostFtdcDepartmentUserField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcDepartmentUserField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte InvestorRange
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->InvestorRange;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->InvestorRange = value;
            }
        }

        public sbyte[] InvestorID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->InvestorID != null)
                {
                    __value = new sbyte[13];
                    for (int i = 0; i < 13; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->InvestorID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 13; i++)
                        ((global::ProxyCTP.CThostFtdcDepartmentUserField.__Internal*)__Instance)->InvestorID[i] = value[i];
                }
            }
        }
    }

    /// <summary>查询频率，每秒查询比数</summary>
    public unsafe partial class CThostFtdcQueryFreqField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int QueryFreq;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcQueryFreqField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQueryFreqField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQueryFreqField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcQueryFreqField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQueryFreqField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcQueryFreqField __CreateInstance(global::ProxyCTP.CThostFtdcQueryFreqField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQueryFreqField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcQueryFreqField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQueryFreqField.__Internal));
            *(global::ProxyCTP.CThostFtdcQueryFreqField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcQueryFreqField(global::ProxyCTP.CThostFtdcQueryFreqField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcQueryFreqField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcQueryFreqField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQueryFreqField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcQueryFreqField(global::ProxyCTP.CThostFtdcQueryFreqField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQueryFreqField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcQueryFreqField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcQueryFreqField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcQueryFreqField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int QueryFreq
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcQueryFreqField.__Internal*)__Instance)->QueryFreq;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcQueryFreqField.__Internal*)__Instance)->QueryFreq = value;
            }
        }
    }

    /// <summary>禁止认证IP</summary>
    public unsafe partial class CThostFtdcAuthForbiddenIPField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 33)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte IPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcAuthForbiddenIPField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcAuthForbiddenIPField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcAuthForbiddenIPField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcAuthForbiddenIPField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcAuthForbiddenIPField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcAuthForbiddenIPField __CreateInstance(global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcAuthForbiddenIPField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal));
            *(global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcAuthForbiddenIPField(global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcAuthForbiddenIPField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcAuthForbiddenIPField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcAuthForbiddenIPField(global::ProxyCTP.CThostFtdcAuthForbiddenIPField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcAuthForbiddenIPField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] IPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal*)__Instance)->IPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal*)__Instance)->IPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcAuthForbiddenIPField.__Internal*)__Instance)->IPAddress[i] = value[i];
                }
            }
        }
    }

    /// <summary>查询禁止认证IP</summary>
    public unsafe partial class CThostFtdcQryAuthForbiddenIPField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 33)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte IPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcQryAuthForbiddenIPField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField __CreateInstance(global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal));
            *(global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcQryAuthForbiddenIPField(global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcQryAuthForbiddenIPField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcQryAuthForbiddenIPField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcQryAuthForbiddenIPField(global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] IPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal*)__Instance)->IPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal*)__Instance)->IPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcQryAuthForbiddenIPField.__Internal*)__Instance)->IPAddress[i] = value[i];
                }
            }
        }
    }

    /// <summary>用户系统信息</summary>
    public unsafe partial class CThostFtdcUserSystemInfoField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 556)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte UserID[16];

            [FieldOffset(28)]
            internal int ClientSystemInfoLen;

            [FieldOffset(32)]
            internal fixed sbyte ClientSystemInfo[273];

            [FieldOffset(305)]
            internal fixed sbyte reserve1[16];

            [FieldOffset(324)]
            internal int ClientIPPort;

            [FieldOffset(328)]
            internal fixed sbyte ClientLoginTime[9];

            [FieldOffset(337)]
            internal fixed sbyte ClientAppID[33];

            [FieldOffset(370)]
            internal fixed sbyte ClientPublicIP[33];

            [FieldOffset(403)]
            internal fixed sbyte ClientLoginRemark[151];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcUserSystemInfoField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcUserSystemInfoField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcUserSystemInfoField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcUserSystemInfoField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcUserSystemInfoField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcUserSystemInfoField __CreateInstance(global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcUserSystemInfoField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal));
            *(global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcUserSystemInfoField(global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcUserSystemInfoField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcUserSystemInfoField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcUserSystemInfoField(global::ProxyCTP.CThostFtdcUserSystemInfoField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcUserSystemInfoField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public int ClientSystemInfoLen
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientSystemInfoLen;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientSystemInfoLen = value;
            }
        }

        public sbyte[] ClientSystemInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientSystemInfo != null)
                {
                    __value = new sbyte[273];
                    for (int i = 0; i < 273; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientSystemInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 273; i++)
                        ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientSystemInfo[i] = value[i];
                }
            }
        }

        public sbyte[] Reserve1
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->reserve1 != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->reserve1[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->reserve1[i] = value[i];
                }
            }
        }

        public int ClientIPPort
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientIPPort;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientIPPort = value;
            }
        }

        public sbyte[] ClientLoginTime
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientLoginTime != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientLoginTime[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientLoginTime[i] = value[i];
                }
            }
        }

        public sbyte[] ClientAppID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientAppID != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientAppID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientAppID[i] = value[i];
                }
            }
        }

        public sbyte[] ClientPublicIP
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientPublicIP != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientPublicIP[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientPublicIP[i] = value[i];
                }
            }
        }

        public sbyte[] ClientLoginRemark
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientLoginRemark != null)
                {
                    __value = new sbyte[151];
                    for (int i = 0; i < 151; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientLoginRemark[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 151; i++)
                        ((global::ProxyCTP.CThostFtdcUserSystemInfoField.__Internal*)__Instance)->ClientLoginRemark[i] = value[i];
                }
            }
        }
    }

    /// <summary>终端用户绑定信息</summary>
    public unsafe partial class CThostFtdcAuthUserIDField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 61)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte AppID[33];

            [FieldOffset(44)]
            internal fixed sbyte UserID[16];

            [FieldOffset(60)]
            internal sbyte AuthType;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcAuthUserIDField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcAuthUserIDField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcAuthUserIDField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcAuthUserIDField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcAuthUserIDField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcAuthUserIDField __CreateInstance(global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcAuthUserIDField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal));
            *(global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcAuthUserIDField(global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcAuthUserIDField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcAuthUserIDField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcAuthUserIDField(global::ProxyCTP.CThostFtdcAuthUserIDField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcAuthUserIDField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] AppID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->AppID != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->AppID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->AppID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte AuthType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->AuthType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcAuthUserIDField.__Internal*)__Instance)->AuthType = value;
            }
        }
    }

    /// <summary>用户IP绑定信息</summary>
    public unsafe partial class CThostFtdcAuthIPField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 77)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(11)]
            internal fixed sbyte AppID[33];

            [FieldOffset(44)]
            internal fixed sbyte IPAddress[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcAuthIPField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcAuthIPField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcAuthIPField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcAuthIPField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcAuthIPField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcAuthIPField __CreateInstance(global::ProxyCTP.CThostFtdcAuthIPField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcAuthIPField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcAuthIPField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthIPField.__Internal));
            *(global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcAuthIPField(global::ProxyCTP.CThostFtdcAuthIPField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcAuthIPField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcAuthIPField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthIPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcAuthIPField(global::ProxyCTP.CThostFtdcAuthIPField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcAuthIPField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcAuthIPField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] AppID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)__Instance)->AppID != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)__Instance)->AppID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)__Instance)->AppID[i] = value[i];
                }
            }
        }

        public sbyte[] IPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)__Instance)->IPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)__Instance)->IPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcAuthIPField.__Internal*)__Instance)->IPAddress[i] = value[i];
                }
            }
        }
    }

    /// <summary>查询分类合约</summary>
    public unsafe partial class CThostFtdcQryClassifiedInstrumentField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 254)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte InstrumentID[81];

            [FieldOffset(81)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(90)]
            internal fixed sbyte ExchangeInstID[81];

            [FieldOffset(171)]
            internal fixed sbyte ProductID[81];

            [FieldOffset(252)]
            internal sbyte TradingType;

            [FieldOffset(253)]
            internal sbyte ClassType;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcQryClassifiedInstrumentField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField __CreateInstance(global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal));
            *(global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcQryClassifiedInstrumentField(global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcQryClassifiedInstrumentField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcQryClassifiedInstrumentField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcQryClassifiedInstrumentField(global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] ExchangeInstID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ExchangeInstID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ExchangeInstID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ExchangeInstID[i] = value[i];
                }
            }
        }

        public sbyte[] ProductID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ProductID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ProductID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ProductID[i] = value[i];
                }
            }
        }

        public sbyte TradingType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->TradingType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->TradingType = value;
            }
        }

        public sbyte ClassType
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ClassType;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcQryClassifiedInstrumentField.__Internal*)__Instance)->ClassType = value;
            }
        }
    }

    /// <summary>查询组合优惠比例</summary>
    public unsafe partial class CThostFtdcQryCombPromotionParamField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 90)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(9)]
            internal fixed sbyte InstrumentID[81];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcQryCombPromotionParamField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryCombPromotionParamField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcQryCombPromotionParamField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcQryCombPromotionParamField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryCombPromotionParamField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcQryCombPromotionParamField __CreateInstance(global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcQryCombPromotionParamField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal));
            *(global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcQryCombPromotionParamField(global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcQryCombPromotionParamField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcQryCombPromotionParamField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcQryCombPromotionParamField(global::ProxyCTP.CThostFtdcQryCombPromotionParamField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcQryCombPromotionParamField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcQryCombPromotionParamField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }
    }

    /// <summary>组合优惠比例</summary>
    public unsafe partial class CThostFtdcCombPromotionParamField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 104)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte ExchangeID[9];

            [FieldOffset(9)]
            internal fixed sbyte InstrumentID[81];

            [FieldOffset(90)]
            internal fixed sbyte CombHedgeFlag[5];

            [FieldOffset(96)]
            internal double Xparameter;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcCombPromotionParamField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcCombPromotionParamField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcCombPromotionParamField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcCombPromotionParamField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcCombPromotionParamField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcCombPromotionParamField __CreateInstance(global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcCombPromotionParamField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal));
            *(global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcCombPromotionParamField(global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcCombPromotionParamField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcCombPromotionParamField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcCombPromotionParamField(global::ProxyCTP.CThostFtdcCombPromotionParamField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcCombPromotionParamField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] ExchangeID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->ExchangeID != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->ExchangeID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->ExchangeID[i] = value[i];
                }
            }
        }

        public sbyte[] InstrumentID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->InstrumentID != null)
                {
                    __value = new sbyte[81];
                    for (int i = 0; i < 81; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->InstrumentID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 81; i++)
                        ((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->InstrumentID[i] = value[i];
                }
            }
        }

        public sbyte[] CombHedgeFlag
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->CombHedgeFlag != null)
                {
                    __value = new sbyte[5];
                    for (int i = 0; i < 5; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->CombHedgeFlag[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 5; i++)
                        ((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->CombHedgeFlag[i] = value[i];
                }
            }
        }

        public double Xparameter
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->Xparameter;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcCombPromotionParamField.__Internal*)__Instance)->Xparameter = value;
            }
        }
    }

    /// <summary>国密用户登录请求</summary>
    public unsafe partial class CThostFtdcReqUserLoginSCField : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 300)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte TradingDay[9];

            [FieldOffset(9)]
            internal fixed sbyte BrokerID[11];

            [FieldOffset(20)]
            internal fixed sbyte UserID[16];

            [FieldOffset(36)]
            internal fixed sbyte Password[41];

            [FieldOffset(77)]
            internal fixed sbyte UserProductInfo[11];

            [FieldOffset(88)]
            internal fixed sbyte InterfaceProductInfo[11];

            [FieldOffset(99)]
            internal fixed sbyte ProtocolInfo[11];

            [FieldOffset(110)]
            internal fixed sbyte MacAddress[21];

            [FieldOffset(131)]
            internal fixed sbyte OneTimePassword[41];

            [FieldOffset(172)]
            internal fixed sbyte ClientIPAddress[33];

            [FieldOffset(205)]
            internal fixed sbyte LoginRemark[36];

            [FieldOffset(244)]
            internal int ClientIPPort;

            [FieldOffset(248)]
            internal fixed sbyte AuthCode[17];

            [FieldOffset(265)]
            internal fixed sbyte AppID[33];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("src", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0CThostFtdcReqUserLoginSCField@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqUserLoginSCField> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcReqUserLoginSCField>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcReqUserLoginSCField __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqUserLoginSCField(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcReqUserLoginSCField __CreateInstance(global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcReqUserLoginSCField(native, skipVTables);
        }

        private static void* __CopyValue(global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal));
            *(global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CThostFtdcReqUserLoginSCField(global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CThostFtdcReqUserLoginSCField(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CThostFtdcReqUserLoginSCField()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CThostFtdcReqUserLoginSCField(global::ProxyCTP.CThostFtdcReqUserLoginSCField _0)
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance) = *((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcReqUserLoginSCField __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] TradingDay
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->TradingDay != null)
                {
                    __value = new sbyte[9];
                    for (int i = 0; i < 9; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->TradingDay[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 9; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->TradingDay[i] = value[i];
                }
            }
        }

        public sbyte[] BrokerID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->BrokerID != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->BrokerID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->BrokerID[i] = value[i];
                }
            }
        }

        public sbyte[] UserID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->UserID != null)
                {
                    __value = new sbyte[16];
                    for (int i = 0; i < 16; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->UserID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->UserID[i] = value[i];
                }
            }
        }

        public sbyte[] Password
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->Password != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->Password[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->Password[i] = value[i];
                }
            }
        }

        public sbyte[] UserProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->UserProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->UserProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->UserProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] InterfaceProductInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->InterfaceProductInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->InterfaceProductInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->InterfaceProductInfo[i] = value[i];
                }
            }
        }

        public sbyte[] ProtocolInfo
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->ProtocolInfo != null)
                {
                    __value = new sbyte[11];
                    for (int i = 0; i < 11; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->ProtocolInfo[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 11; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->ProtocolInfo[i] = value[i];
                }
            }
        }

        public sbyte[] MacAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->MacAddress != null)
                {
                    __value = new sbyte[21];
                    for (int i = 0; i < 21; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->MacAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 21; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->MacAddress[i] = value[i];
                }
            }
        }

        public sbyte[] OneTimePassword
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->OneTimePassword != null)
                {
                    __value = new sbyte[41];
                    for (int i = 0; i < 41; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->OneTimePassword[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 41; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->OneTimePassword[i] = value[i];
                }
            }
        }

        public sbyte[] ClientIPAddress
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->ClientIPAddress != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->ClientIPAddress[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->ClientIPAddress[i] = value[i];
                }
            }
        }

        public sbyte[] LoginRemark
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->LoginRemark != null)
                {
                    __value = new sbyte[36];
                    for (int i = 0; i < 36; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->LoginRemark[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 36; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->LoginRemark[i] = value[i];
                }
            }
        }

        public int ClientIPPort
        {
            get
            {
                return ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->ClientIPPort;
            }

            set
            {
                ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->ClientIPPort = value;
            }
        }

        public sbyte[] AuthCode
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->AuthCode != null)
                {
                    __value = new sbyte[17];
                    for (int i = 0; i < 17; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->AuthCode[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 17; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->AuthCode[i] = value[i];
                }
            }
        }

        public sbyte[] AppID
        {
            get
            {
                sbyte[] __value = null;
                if (((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->AppID != null)
                {
                    __value = new sbyte[33];
                    for (int i = 0; i < 33; i++)
                        __value[i] = ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->AppID[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 33; i++)
                        ((global::ProxyCTP.CThostFtdcReqUserLoginSCField.__Internal*)__Instance)->AppID[i] = value[i];
                }
            }
        }
    }

    public enum THOST_TE_RESUME_TYPE
    {
        THOST_TERT_RESTART = 0,
        THOST_TERT_RESUME = 1,
        THOST_TERT_QUICK = 2,
        THOST_TERT_NONE = 3
    }


    namespace Delegates
    {
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr(global::System.IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_int(global::System.IntPtr __instance, int arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_IntPtr_IntPtr_int_bool(global::System.IntPtr __instance, global::System.IntPtr arg1, global::System.IntPtr arg2, int arg3, [MarshalAs(UnmanagedType.I1)] bool arg4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_IntPtr_int_bool(global::System.IntPtr __instance, global::System.IntPtr arg1, int arg2, [MarshalAs(UnmanagedType.I1)] bool arg3);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_IntPtr(global::System.IntPtr __instance, global::System.IntPtr arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int_IntPtr(global::System.IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate global::System.IntPtr Func_IntPtr_IntPtr(global::System.IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate void Action_IntPtr_sbytePtr(global::System.IntPtr __instance, sbyte* arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int(global::System.IntPtr __instance, [MarshalAs(UnmanagedType.LPArray)] string[] arg1, int arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int_IntPtr_IntPtr_int(global::System.IntPtr __instance, global::System.IntPtr arg1, int arg2);

    }
}
