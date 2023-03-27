using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using QuantCSharp.ProxyCTP;

namespace ProxyCTP
{

    public unsafe partial class CThostFtdcMdSpi : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_CThostFtdcMdSpi;

        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMdSpi> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMdSpi>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;


        public CThostFtdcMdSpi()
        {
            __Instance = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMdSpi.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            SetupVTables(GetType().FullName == "proxyctp.CThostFtdcMdSpi");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::ProxyCTP.CThostFtdcMdSpi __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::ProxyCTP.CThostFtdcMdSpi.__Internal*)__Instance)->vfptr_CThostFtdcMdSpi = new global::System.IntPtr(__OriginalVTables[0]);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。</summary>
        public virtual void OnFrontConnected()
        {
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
        public virtual void OnFrontDisconnected(int nReason)
        {
        }

        /// <summary>心跳超时警告。当长时间未收到报文时，该方法被调用。</summary>
        /// <param name="nTimeLapse">距离上次接收报文的时间</param>
        public virtual void OnHeartBeatWarning(int nTimeLapse)
        {
        }

        /// <summary>登录请求响应</summary>
        public virtual void OnRspUserLogin(global::ProxyCTP.CThostFtdcRspUserLoginField pRspUserLogin, global::ProxyCTP.CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        /// <summary>登出请求响应</summary>
        public virtual void OnRspUserLogout(global::ProxyCTP.CThostFtdcUserLogoutField pUserLogout, global::ProxyCTP.CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        /// <summary>请求查询组播合约响应</summary>
        public virtual void OnRspQryMulticastInstrument(global::ProxyCTP.CThostFtdcMulticastInstrumentField pMulticastInstrument, global::ProxyCTP.CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        /// <summary>错误应答</summary>
        public virtual void OnRspError(global::ProxyCTP.CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        /// <summary>订阅行情应答</summary>
        public virtual void OnRspSubMarketData(global::ProxyCTP.CThostFtdcSpecificInstrumentField pSpecificInstrument, global::ProxyCTP.CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        /// <summary>取消订阅行情应答</summary>
        public virtual void OnRspUnSubMarketData(global::ProxyCTP.CThostFtdcSpecificInstrumentField pSpecificInstrument, global::ProxyCTP.CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        /// <summary>订阅询价应答</summary>
        public virtual void OnRspSubForQuoteRsp(global::ProxyCTP.CThostFtdcSpecificInstrumentField pSpecificInstrument, global::ProxyCTP.CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        /// <summary>取消订阅询价应答</summary>
        public virtual void OnRspUnSubForQuoteRsp(global::ProxyCTP.CThostFtdcSpecificInstrumentField pSpecificInstrument, global::ProxyCTP.CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        /// <summary>深度行情通知</summary>
        public virtual void OnRtnDepthMarketData(global::ProxyCTP.CThostFtdcDepthMarketDataField pDepthMarketData)
        {
        }

        /// <summary>询价通知</summary>
        public virtual void OnRtnForQuoteRsp(global::ProxyCTP.CThostFtdcForQuoteRspField pForQuoteRsp)
        {
        }

        #region Virtual table interop

        // void OnFrontConnected(){}
        private static global::ProxyCTP.Delegates.Action_IntPtr _OnFrontConnectedDelegateInstance;

        private static void _OnFrontConnectedDelegateHook(global::System.IntPtr __instance)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.OnFrontConnected();
        }

        // void OnFrontDisconnected(int nReason){}
        private static global::ProxyCTP.Delegates.Action_IntPtr_int _OnFrontDisconnectedDelegateInstance;

        private static void _OnFrontDisconnectedDelegateHook(global::System.IntPtr __instance, int nReason)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.OnFrontDisconnected(nReason);
        }

        // void OnHeartBeatWarning(int nTimeLapse){}
        private static global::ProxyCTP.Delegates.Action_IntPtr_int _OnHeartBeatWarningDelegateInstance;

        private static void _OnHeartBeatWarningDelegateHook(global::System.IntPtr __instance, int nTimeLapse)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.OnHeartBeatWarning(nTimeLapse);
        }

        // void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {}
        private static global::ProxyCTP.Delegates.Action_IntPtr_IntPtr_IntPtr_int_bool _OnRspUserLoginDelegateInstance;

        private static void _OnRspUserLoginDelegateHook(global::System.IntPtr __instance, global::System.IntPtr pRspUserLogin, global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::ProxyCTP.CThostFtdcRspUserLoginField __result0;
            if (pRspUserLogin == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcRspUserLoginField.NativeToManagedMap.ContainsKey(pRspUserLogin))
                __result0 = (global::ProxyCTP.CThostFtdcRspUserLoginField)global::ProxyCTP.CThostFtdcRspUserLoginField.NativeToManagedMap[pRspUserLogin];
            else __result0 = global::ProxyCTP.CThostFtdcRspUserLoginField.__CreateInstance(pRspUserLogin);
            global::ProxyCTP.CThostFtdcRspInfoField __result1;
            if (pRspInfo == IntPtr.Zero) __result1 = null;
            else if (global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap.ContainsKey(pRspInfo))
                __result1 = (global::ProxyCTP.CThostFtdcRspInfoField)global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap[pRspInfo];
            else __result1 = global::ProxyCTP.CThostFtdcRspInfoField.__CreateInstance(pRspInfo);
            __target.OnRspUserLogin(__result0, __result1, nRequestID, bIsLast);
        }

        // void OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {}
        private static global::ProxyCTP.Delegates.Action_IntPtr_IntPtr_IntPtr_int_bool _OnRspUserLogoutDelegateInstance;

        private static void _OnRspUserLogoutDelegateHook(global::System.IntPtr __instance, global::System.IntPtr pUserLogout, global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::ProxyCTP.CThostFtdcUserLogoutField __result0;
            if (pUserLogout == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcUserLogoutField.NativeToManagedMap.ContainsKey(pUserLogout))
                __result0 = (global::ProxyCTP.CThostFtdcUserLogoutField)global::ProxyCTP.CThostFtdcUserLogoutField.NativeToManagedMap[pUserLogout];
            else __result0 = global::ProxyCTP.CThostFtdcUserLogoutField.__CreateInstance(pUserLogout);
            global::ProxyCTP.CThostFtdcRspInfoField __result1;
            if (pRspInfo == IntPtr.Zero) __result1 = null;
            else if (global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap.ContainsKey(pRspInfo))
                __result1 = (global::ProxyCTP.CThostFtdcRspInfoField)global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap[pRspInfo];
            else __result1 = global::ProxyCTP.CThostFtdcRspInfoField.__CreateInstance(pRspInfo);
            __target.OnRspUserLogout(__result0, __result1, nRequestID, bIsLast);
        }

        // void OnRspQryMulticastInstrument(CThostFtdcMulticastInstrumentField *pMulticastInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {}
        private static global::ProxyCTP.Delegates.Action_IntPtr_IntPtr_IntPtr_int_bool _OnRspQryMulticastInstrumentDelegateInstance;

        private static void _OnRspQryMulticastInstrumentDelegateHook(global::System.IntPtr __instance, global::System.IntPtr pMulticastInstrument, global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::ProxyCTP.CThostFtdcMulticastInstrumentField __result0;
            if (pMulticastInstrument == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcMulticastInstrumentField.NativeToManagedMap.ContainsKey(pMulticastInstrument))
                __result0 = (global::ProxyCTP.CThostFtdcMulticastInstrumentField)global::ProxyCTP.CThostFtdcMulticastInstrumentField.NativeToManagedMap[pMulticastInstrument];
            else __result0 = global::ProxyCTP.CThostFtdcMulticastInstrumentField.__CreateInstance(pMulticastInstrument);
            global::ProxyCTP.CThostFtdcRspInfoField __result1;
            if (pRspInfo == IntPtr.Zero) __result1 = null;
            else if (global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap.ContainsKey(pRspInfo))
                __result1 = (global::ProxyCTP.CThostFtdcRspInfoField)global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap[pRspInfo];
            else __result1 = global::ProxyCTP.CThostFtdcRspInfoField.__CreateInstance(pRspInfo);
            __target.OnRspQryMulticastInstrument(__result0, __result1, nRequestID, bIsLast);
        }

        // void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {}
        private static global::ProxyCTP.Delegates.Action_IntPtr_IntPtr_int_bool _OnRspErrorDelegateInstance;

        private static void _OnRspErrorDelegateHook(global::System.IntPtr __instance, global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::ProxyCTP.CThostFtdcRspInfoField __result0;
            if (pRspInfo == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap.ContainsKey(pRspInfo))
                __result0 = (global::ProxyCTP.CThostFtdcRspInfoField)global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap[pRspInfo];
            else __result0 = global::ProxyCTP.CThostFtdcRspInfoField.__CreateInstance(pRspInfo);
            __target.OnRspError(__result0, nRequestID, bIsLast);
        }

        // void OnRspSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {}
        private static global::ProxyCTP.Delegates.Action_IntPtr_IntPtr_IntPtr_int_bool _OnRspSubMarketDataDelegateInstance;

        private static void _OnRspSubMarketDataDelegateHook(global::System.IntPtr __instance, global::System.IntPtr pSpecificInstrument, global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::ProxyCTP.CThostFtdcSpecificInstrumentField __result0;
            if (pSpecificInstrument == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcSpecificInstrumentField.NativeToManagedMap.ContainsKey(pSpecificInstrument))
                __result0 = (global::ProxyCTP.CThostFtdcSpecificInstrumentField)global::ProxyCTP.CThostFtdcSpecificInstrumentField.NativeToManagedMap[pSpecificInstrument];
            else __result0 = global::ProxyCTP.CThostFtdcSpecificInstrumentField.__CreateInstance(pSpecificInstrument);
            global::ProxyCTP.CThostFtdcRspInfoField __result1;
            if (pRspInfo == IntPtr.Zero) __result1 = null;
            else if (global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap.ContainsKey(pRspInfo))
                __result1 = (global::ProxyCTP.CThostFtdcRspInfoField)global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap[pRspInfo];
            else __result1 = global::ProxyCTP.CThostFtdcRspInfoField.__CreateInstance(pRspInfo);
            __target.OnRspSubMarketData(__result0, __result1, nRequestID, bIsLast);
        }

        // void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {}
        private static global::ProxyCTP.Delegates.Action_IntPtr_IntPtr_IntPtr_int_bool _OnRspUnSubMarketDataDelegateInstance;

        private static void _OnRspUnSubMarketDataDelegateHook(global::System.IntPtr __instance, global::System.IntPtr pSpecificInstrument, global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::ProxyCTP.CThostFtdcSpecificInstrumentField __result0;
            if (pSpecificInstrument == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcSpecificInstrumentField.NativeToManagedMap.ContainsKey(pSpecificInstrument))
                __result0 = (global::ProxyCTP.CThostFtdcSpecificInstrumentField)global::ProxyCTP.CThostFtdcSpecificInstrumentField.NativeToManagedMap[pSpecificInstrument];
            else __result0 = global::ProxyCTP.CThostFtdcSpecificInstrumentField.__CreateInstance(pSpecificInstrument);
            global::ProxyCTP.CThostFtdcRspInfoField __result1;
            if (pRspInfo == IntPtr.Zero) __result1 = null;
            else if (global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap.ContainsKey(pRspInfo))
                __result1 = (global::ProxyCTP.CThostFtdcRspInfoField)global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap[pRspInfo];
            else __result1 = global::ProxyCTP.CThostFtdcRspInfoField.__CreateInstance(pRspInfo);
            __target.OnRspUnSubMarketData(__result0, __result1, nRequestID, bIsLast);
        }

        // void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {}
        private static global::ProxyCTP.Delegates.Action_IntPtr_IntPtr_IntPtr_int_bool _OnRspSubForQuoteRspDelegateInstance;

        private static void _OnRspSubForQuoteRspDelegateHook(global::System.IntPtr __instance, global::System.IntPtr pSpecificInstrument, global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::ProxyCTP.CThostFtdcSpecificInstrumentField __result0;
            if (pSpecificInstrument == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcSpecificInstrumentField.NativeToManagedMap.ContainsKey(pSpecificInstrument))
                __result0 = (global::ProxyCTP.CThostFtdcSpecificInstrumentField)global::ProxyCTP.CThostFtdcSpecificInstrumentField.NativeToManagedMap[pSpecificInstrument];
            else __result0 = global::ProxyCTP.CThostFtdcSpecificInstrumentField.__CreateInstance(pSpecificInstrument);
            global::ProxyCTP.CThostFtdcRspInfoField __result1;
            if (pRspInfo == IntPtr.Zero) __result1 = null;
            else if (global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap.ContainsKey(pRspInfo))
                __result1 = (global::ProxyCTP.CThostFtdcRspInfoField)global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap[pRspInfo];
            else __result1 = global::ProxyCTP.CThostFtdcRspInfoField.__CreateInstance(pRspInfo);
            __target.OnRspSubForQuoteRsp(__result0, __result1, nRequestID, bIsLast);
        }

        // void OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {}
        private static global::ProxyCTP.Delegates.Action_IntPtr_IntPtr_IntPtr_int_bool _OnRspUnSubForQuoteRspDelegateInstance;

        private static void _OnRspUnSubForQuoteRspDelegateHook(global::System.IntPtr __instance, global::System.IntPtr pSpecificInstrument, global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::ProxyCTP.CThostFtdcSpecificInstrumentField __result0;
            if (pSpecificInstrument == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcSpecificInstrumentField.NativeToManagedMap.ContainsKey(pSpecificInstrument))
                __result0 = (global::ProxyCTP.CThostFtdcSpecificInstrumentField)global::ProxyCTP.CThostFtdcSpecificInstrumentField.NativeToManagedMap[pSpecificInstrument];
            else __result0 = global::ProxyCTP.CThostFtdcSpecificInstrumentField.__CreateInstance(pSpecificInstrument);
            global::ProxyCTP.CThostFtdcRspInfoField __result1;
            if (pRspInfo == IntPtr.Zero) __result1 = null;
            else if (global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap.ContainsKey(pRspInfo))
                __result1 = (global::ProxyCTP.CThostFtdcRspInfoField)global::ProxyCTP.CThostFtdcRspInfoField.NativeToManagedMap[pRspInfo];
            else __result1 = global::ProxyCTP.CThostFtdcRspInfoField.__CreateInstance(pRspInfo);
            __target.OnRspUnSubForQuoteRsp(__result0, __result1, nRequestID, bIsLast);
        }

        // void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData) {}
        private static global::ProxyCTP.Delegates.Action_IntPtr_IntPtr _OnRtnDepthMarketDataDelegateInstance;

        private static void _OnRtnDepthMarketDataDelegateHook(global::System.IntPtr __instance, global::System.IntPtr pDepthMarketData)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::ProxyCTP.CThostFtdcDepthMarketDataField __result0;
            if (pDepthMarketData == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcDepthMarketDataField.NativeToManagedMap.ContainsKey(pDepthMarketData))
                __result0 = (global::ProxyCTP.CThostFtdcDepthMarketDataField)global::ProxyCTP.CThostFtdcDepthMarketDataField.NativeToManagedMap[pDepthMarketData];
            else __result0 = global::ProxyCTP.CThostFtdcDepthMarketDataField.__CreateInstance(pDepthMarketData);
            __target.OnRtnDepthMarketData(__result0);
        }

        // void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField *pForQuoteRsp) {}
        private static global::ProxyCTP.Delegates.Action_IntPtr_IntPtr _OnRtnForQuoteRspDelegateInstance;

        private static void _OnRtnForQuoteRspDelegateHook(global::System.IntPtr __instance, global::System.IntPtr pForQuoteRsp)
        {
            if (!NativeToManagedMap.ContainsKey(__instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::ProxyCTP.CThostFtdcMdSpi)NativeToManagedMap[__instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::ProxyCTP.CThostFtdcForQuoteRspField __result0;
            if (pForQuoteRsp == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcForQuoteRspField.NativeToManagedMap.ContainsKey(pForQuoteRsp))
                __result0 = (global::ProxyCTP.CThostFtdcForQuoteRspField)global::ProxyCTP.CThostFtdcForQuoteRspField.NativeToManagedMap[pForQuoteRsp];
            else __result0 = global::ProxyCTP.CThostFtdcForQuoteRspField.__CreateInstance(pForQuoteRsp);
            __target.OnRtnForQuoteRsp(__result0);
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
                _Thunks = new void*[13];
                _OnFrontConnectedDelegateInstance += _OnFrontConnectedDelegateHook;
                _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_OnFrontConnectedDelegateInstance).ToPointer();
                _OnFrontDisconnectedDelegateInstance += _OnFrontDisconnectedDelegateHook;
                _Thunks[1] = CMarshal.GetFunctionPointerForDelegate(_OnFrontDisconnectedDelegateInstance).ToPointer();
                _OnHeartBeatWarningDelegateInstance += _OnHeartBeatWarningDelegateHook;
                _Thunks[2] = CMarshal.GetFunctionPointerForDelegate(_OnHeartBeatWarningDelegateInstance).ToPointer();
                _OnRspUserLoginDelegateInstance += _OnRspUserLoginDelegateHook;
                _Thunks[3] = CMarshal.GetFunctionPointerForDelegate(_OnRspUserLoginDelegateInstance).ToPointer();
                _OnRspUserLogoutDelegateInstance += _OnRspUserLogoutDelegateHook;
                _Thunks[4] = CMarshal.GetFunctionPointerForDelegate(_OnRspUserLogoutDelegateInstance).ToPointer();
                _OnRspQryMulticastInstrumentDelegateInstance += _OnRspQryMulticastInstrumentDelegateHook;
                _Thunks[5] = CMarshal.GetFunctionPointerForDelegate(_OnRspQryMulticastInstrumentDelegateInstance).ToPointer();
                _OnRspErrorDelegateInstance += _OnRspErrorDelegateHook;
                _Thunks[6] = CMarshal.GetFunctionPointerForDelegate(_OnRspErrorDelegateInstance).ToPointer();
                _OnRspSubMarketDataDelegateInstance += _OnRspSubMarketDataDelegateHook;
                _Thunks[7] = CMarshal.GetFunctionPointerForDelegate(_OnRspSubMarketDataDelegateInstance).ToPointer();
                _OnRspUnSubMarketDataDelegateInstance += _OnRspUnSubMarketDataDelegateHook;
                _Thunks[8] = CMarshal.GetFunctionPointerForDelegate(_OnRspUnSubMarketDataDelegateInstance).ToPointer();
                _OnRspSubForQuoteRspDelegateInstance += _OnRspSubForQuoteRspDelegateHook;
                _Thunks[9] = CMarshal.GetFunctionPointerForDelegate(_OnRspSubForQuoteRspDelegateInstance).ToPointer();
                _OnRspUnSubForQuoteRspDelegateInstance += _OnRspUnSubForQuoteRspDelegateHook;
                _Thunks[10] = CMarshal.GetFunctionPointerForDelegate(_OnRspUnSubForQuoteRspDelegateInstance).ToPointer();
                _OnRtnDepthMarketDataDelegateInstance += _OnRtnDepthMarketDataDelegateHook;
                _Thunks[11] = CMarshal.GetFunctionPointerForDelegate(_OnRtnDepthMarketDataDelegateInstance).ToPointer();
                _OnRtnForQuoteRspDelegateInstance += _OnRtnForQuoteRspDelegateHook;
                _Thunks[12] = CMarshal.GetFunctionPointerForDelegate(_OnRtnForQuoteRspDelegateInstance).ToPointer();
            }

            if (__ManagedVTables == null)
            {
                __ManagedVTables = new void*[1];
                var vfptr0 = CMarshal.AllocHGlobal(13 * 8);
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
            }

            *(void**)(__Instance + 0) = __ManagedVTables[0];
        }

        #endregion
    }

    public unsafe abstract partial class CThostFtdcMdApi : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMdApi> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::ProxyCTP.CThostFtdcMdApi>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::ProxyCTP.CThostFtdcMdApi __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMdApiInternal(native.ToPointer(), skipVTables);
        }

        internal static global::ProxyCTP.CThostFtdcMdApi __CreateInstance(global::ProxyCTP.CThostFtdcMdApi.__Internal native, bool skipVTables = false)
        {
            return new global::ProxyCTP.CThostFtdcMdApiInternal(native, skipVTables);
        }

        protected CThostFtdcMdApi(void* native, bool skipVTables = false)
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
            global::ProxyCTP.CThostFtdcMdApi __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::ProxyCTP.CThostFtdcMdApi.__Internal*)__Instance)->vfptr_CThostFtdcMdApi = new global::System.IntPtr(__OriginalVTables[0]);
            if (__ownsNativeInstance)
                CMarshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>删除接口对象本身</summary>
        /// <remarks>不再使用本接口对象时,调用该函数删除接口对象</remarks>
        public abstract void Release();

        /// <summary>初始化</summary>
        /// <remarks>初始化运行环境,只有调用后,接口才开始工作</remarks>
        public abstract void Init();

        /// <summary>等待接口线程结束运行</summary>
        /// <returns>线程退出代码</returns>
        public abstract int Join();

        /// <summary>注册前置机网络地址</summary>
        /// <remarks>
        /// <para>网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。</para>
        /// <para>“tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。</para>
        /// </remarks>
        public abstract void RegisterFront(sbyte* pszFrontAddress);

        /// <summary>注册名字服务器网络地址</summary>
        /// <remarks>
        /// <para>网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:12001”。</para>
        /// <para>“tcp”代表传输协议，“127.0.0.1”代表服务器地址。”12001”代表服务器端口号。</para>
        /// <para>RegisterNameServer优先于RegisterFront</para>
        /// </remarks>
        public abstract void RegisterNameServer(sbyte* pszNsAddress);

        /// <summary>注册名字服务器用户信息</summary>
        public abstract void RegisterFensUserInfo(global::ProxyCTP.CThostFtdcFensUserInfoField pFensUserInfo);

        /// <summary>注册回调接口</summary>
        /// <param name="pSpi">派生自回调接口类的实例</param>
        public abstract void RegisterSpi(global::ProxyCTP.CThostFtdcMdSpi pSpi);

        /// <summary>订阅行情。</summary>
        /// <param name="ppInstrumentID">合约ID</param>
        /// <param name="nCount">要订阅/退订行情的合约个数</param>
        public abstract int SubscribeMarketData(string[] ppInstrumentID, int nCount);

        /// <summary>退订行情。</summary>
        /// <param name="ppInstrumentID">合约ID</param>
        /// <param name="nCount">要订阅/退订行情的合约个数</param>
        public abstract int UnSubscribeMarketData(string[] ppInstrumentID, int nCount);

        /// <summary>订阅询价。</summary>
        /// <param name="ppInstrumentID">合约ID</param>
        /// <param name="nCount">要订阅/退订行情的合约个数</param>
        public abstract int SubscribeForQuoteRsp(string[] ppInstrumentID, int nCount);

        /// <summary>退订询价。</summary>
        /// <param name="ppInstrumentID">合约ID</param>
        /// <param name="nCount">要订阅/退订行情的合约个数</param>
        public abstract int UnSubscribeForQuoteRsp(string[] ppInstrumentID, int nCount);

        /// <summary>用户登录请求</summary>
        public abstract int ReqUserLogin(global::ProxyCTP.CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);

        /// <summary>登出请求</summary>
        public abstract int ReqUserLogout(global::ProxyCTP.CThostFtdcUserLogoutField pUserLogout, int nRequestID);

        /// <summary>请求查询组播合约</summary>
        public abstract int ReqQryMulticastInstrument(global::ProxyCTP.CThostFtdcQryMulticastInstrumentField pQryMulticastInstrument, int nRequestID);

        /// <summary>创建MdApi</summary>
        /// <param name="pszFlowPath">存贮订阅信息文件的目录，默认为当前目录</param>
        /// <returns>
        /// <para>创建出的UserApi</para>
        /// <para>modify for udp marketdata</para>
        /// </returns>
        public static global::ProxyCTP.CThostFtdcMdApi CreateFtdcMdApi(string pszFlowPath, bool bIsUsingUdp, bool bIsMulticast)
        {
            var __ret = __Internal.CreateFtdcMdApi(pszFlowPath, bIsUsingUdp, bIsMulticast);
            global::ProxyCTP.CThostFtdcMdApi __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::ProxyCTP.CThostFtdcMdApi.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::ProxyCTP.CThostFtdcMdApi)global::ProxyCTP.CThostFtdcMdApi.NativeToManagedMap[__ret];
            else __result0 = global::ProxyCTP.CThostFtdcMdApi.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>
        /// <para>获取API的版本信息</para>
        /// <para>获取到的版本号</para>
        /// </summary>
        public static string ApiVersion
        {
            get
            {
                var __ret = __Internal.GetApiVersion();
                if (__ret == global::System.IntPtr.Zero)
                    return default(string);
                var __retPtr = (byte*)__ret;
                int __length = 0;
                while (*(__retPtr++) != 0) __length += sizeof(byte);
                return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
            }
        }

        /// <summary>
        /// <para>获取当前交易日</para>
        /// <para>获取到的交易日</para>
        /// </summary>
        /// <remarks>只有登录成功后,才能得到正确的交易日</remarks>
        public abstract string TradingDay
        {
            get;
        }
    }

    public unsafe partial class CThostFtdcMdApiInternal : global::ProxyCTP.CThostFtdcMdApi, IDisposable
    {
        private static void* __CopyValue(global::ProxyCTP.CThostFtdcMdApi.__Internal native)
        {
            var ret = CMarshal.AllocHGlobal(sizeof(global::ProxyCTP.CThostFtdcMdApi.__Internal));
            *(global::ProxyCTP.CThostFtdcMdApi.__Internal*)ret = native;
            return ret.ToPointer();
        }

        internal CThostFtdcMdApiInternal(global::ProxyCTP.CThostFtdcMdApi.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        internal CThostFtdcMdApiInternal(void* native, bool skipVTables = false)
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
            var ___ReleaseDelegate = (global::ProxyCTP.Delegates.Action_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Action_IntPtr));
            ___ReleaseDelegate(__Instance);
        }

        /// <summary>初始化</summary>
        /// <remarks>初始化运行环境,只有调用后,接口才开始工作</remarks>
        public override void Init()
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 1 * 8);
            var ___InitDelegate = (global::ProxyCTP.Delegates.Action_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Action_IntPtr));
            ___InitDelegate(__Instance);
        }

        /// <summary>等待接口线程结束运行</summary>
        /// <returns>线程退出代码</returns>
        public override int Join()
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 2 * 8);
            var ___JoinDelegate = (global::ProxyCTP.Delegates.Func_int_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Func_int_IntPtr));
            var __ret = ___JoinDelegate(__Instance);
            return __ret;
        }

        /// <summary>注册前置机网络地址</summary>
        /// <remarks>
        /// <para>网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。</para>
        /// <para>“tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。</para>
        /// </remarks>
        public override void RegisterFront(sbyte* pszFrontAddress)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 4 * 8);
            var ___RegisterFrontDelegate = (global::ProxyCTP.Delegates.Action_IntPtr_sbytePtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Action_IntPtr_sbytePtr));
            ___RegisterFrontDelegate(__Instance, pszFrontAddress);
        }

        /// <summary>注册名字服务器网络地址</summary>
        /// <remarks>
        /// <para>网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:12001”。</para>
        /// <para>“tcp”代表传输协议，“127.0.0.1”代表服务器地址。”12001”代表服务器端口号。</para>
        /// <para>RegisterNameServer优先于RegisterFront</para>
        /// </remarks>
        public override void RegisterNameServer(sbyte* pszNsAddress)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 5 * 8);
            var ___RegisterNameServerDelegate = (global::ProxyCTP.Delegates.Action_IntPtr_sbytePtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Action_IntPtr_sbytePtr));
            ___RegisterNameServerDelegate(__Instance, pszNsAddress);
        }

        /// <summary>注册名字服务器用户信息</summary>
        public override void RegisterFensUserInfo(global::ProxyCTP.CThostFtdcFensUserInfoField pFensUserInfo)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 6 * 8);
            var ___RegisterFensUserInfoDelegate = (global::ProxyCTP.Delegates.Action_IntPtr_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Action_IntPtr_IntPtr));
            var __arg0 = ReferenceEquals(pFensUserInfo, null) ? global::System.IntPtr.Zero : pFensUserInfo.__Instance;
            ___RegisterFensUserInfoDelegate(__Instance, __arg0);
        }

        /// <summary>注册回调接口</summary>
        /// <param name="pSpi">派生自回调接口类的实例</param>
        public override void RegisterSpi(global::ProxyCTP.CThostFtdcMdSpi pSpi)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 7 * 8);
            var ___RegisterSpiDelegate = (global::ProxyCTP.Delegates.Action_IntPtr_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Action_IntPtr_IntPtr));
            var __arg0 = ReferenceEquals(pSpi, null) ? global::System.IntPtr.Zero : pSpi.__Instance;
            ___RegisterSpiDelegate(__Instance, __arg0);
        }

        /// <summary>订阅行情。</summary>
        /// <param name="ppInstrumentID">合约ID</param>
        /// <param name="nCount">要订阅/退订行情的合约个数</param>
        public override int SubscribeMarketData(string[] ppInstrumentID, int nCount)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 8 * 8);
            var ___SubscribeMarketDataDelegate = (global::ProxyCTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int));
            var __ret = ___SubscribeMarketDataDelegate(__Instance, ppInstrumentID, nCount);
            return __ret;
        }

        /// <summary>退订行情。</summary>
        /// <param name="ppInstrumentID">合约ID</param>
        /// <param name="nCount">要订阅/退订行情的合约个数</param>
        public override int UnSubscribeMarketData(string[] ppInstrumentID, int nCount)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 9 * 8);
            var ___UnSubscribeMarketDataDelegate = (global::ProxyCTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int));
            var __ret = ___UnSubscribeMarketDataDelegate(__Instance, ppInstrumentID, nCount);
            return __ret;
        }

        /// <summary>订阅询价。</summary>
        /// <param name="ppInstrumentID">合约ID</param>
        /// <param name="nCount">要订阅/退订行情的合约个数</param>
        public override int SubscribeForQuoteRsp(string[] ppInstrumentID, int nCount)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 10 * 8);
            var ___SubscribeForQuoteRspDelegate = (global::ProxyCTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int));
            var __ret = ___SubscribeForQuoteRspDelegate(__Instance, ppInstrumentID, nCount);
            return __ret;
        }

        /// <summary>退订询价。</summary>
        /// <param name="ppInstrumentID">合约ID</param>
        /// <param name="nCount">要订阅/退订行情的合约个数</param>
        public override int UnSubscribeForQuoteRsp(string[] ppInstrumentID, int nCount)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 11 * 8);
            var ___UnSubscribeForQuoteRspDelegate = (global::ProxyCTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Func_int_IntPtr__MarshalAs_UnmanagedType_LPArray___stringArray_int));
            var __ret = ___UnSubscribeForQuoteRspDelegate(__Instance, ppInstrumentID, nCount);
            return __ret;
        }

        /// <summary>用户登录请求</summary>
        public override int ReqUserLogin(global::ProxyCTP.CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 12 * 8);
            var ___ReqUserLoginDelegate = (global::ProxyCTP.Delegates.Func_int_IntPtr_IntPtr_int)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Func_int_IntPtr_IntPtr_int));
            var __arg0 = ReferenceEquals(pReqUserLoginField, null) ? global::System.IntPtr.Zero : pReqUserLoginField.__Instance;
            var __ret = ___ReqUserLoginDelegate(__Instance, __arg0, nRequestID);
            return __ret;
        }

        /// <summary>登出请求</summary>
        public override int ReqUserLogout(global::ProxyCTP.CThostFtdcUserLogoutField pUserLogout, int nRequestID)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 13 * 8);
            var ___ReqUserLogoutDelegate = (global::ProxyCTP.Delegates.Func_int_IntPtr_IntPtr_int)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Func_int_IntPtr_IntPtr_int));
            var __arg0 = ReferenceEquals(pUserLogout, null) ? global::System.IntPtr.Zero : pUserLogout.__Instance;
            var __ret = ___ReqUserLogoutDelegate(__Instance, __arg0, nRequestID);
            return __ret;
        }

        /// <summary>请求查询组播合约</summary>
        public override int ReqQryMulticastInstrument(global::ProxyCTP.CThostFtdcQryMulticastInstrumentField pQryMulticastInstrument, int nRequestID)
        {
            var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 14 * 8);
            var ___ReqQryMulticastInstrumentDelegate = (global::ProxyCTP.Delegates.Func_int_IntPtr_IntPtr_int)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Func_int_IntPtr_IntPtr_int));
            var __arg0 = ReferenceEquals(pQryMulticastInstrument, null) ? global::System.IntPtr.Zero : pQryMulticastInstrument.__Instance;
            var __ret = ___ReqQryMulticastInstrumentDelegate(__Instance, __arg0, nRequestID);
            return __ret;
        }

        /// <summary>
        /// <para>获取当前交易日</para>
        /// <para>获取到的交易日</para>
        /// </summary>
        /// <remarks>只有登录成功后,才能得到正确的交易日</remarks>
        public override string TradingDay
        {
            get
            {
                var __slot = *(void**)((IntPtr)__OriginalVTables[0] + 3 * 8);
                var ___GetTradingDayDelegate = (global::ProxyCTP.Delegates.Func_IntPtr_IntPtr)CMarshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::ProxyCTP.Delegates.Func_IntPtr_IntPtr));
                var __ret = ___GetTradingDayDelegate(__Instance);
                if (__ret == global::System.IntPtr.Zero)
                    return default(string);
                var __retPtr = (byte*)__ret;
                int __length = 0;
                while (*(__retPtr++) != 0) __length += sizeof(byte);
                return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
            }
        }
    }

}
