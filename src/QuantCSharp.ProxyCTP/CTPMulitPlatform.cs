using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

namespace ProxyCTP
{

#if WIN
    public unsafe abstract partial class CThostFtdcMdApi
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_CThostFtdcMdApi;

            [SuppressUnmanagedCodeSecurity, DllImport("thostmduserapi", EntryPoint = "?CreateFtdcMdApi@CThostFtdcMdApi@@SAPEAV1@PEBD_N1@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr CreateFtdcMdApi([MarshalAs(UnmanagedType.LPStr)] string pszFlowPath, bool bIsUsingUdp, bool bIsMulticast);

            [SuppressUnmanagedCodeSecurity, DllImport("thostmduserapi", EntryPoint = "?GetApiVersion@CThostFtdcMdApi@@SAPEBDXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetApiVersion();
        }
    }

#endif

#if LINUX

    public unsafe abstract partial class CThostFtdcMdApi 
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_CThostFtdcMdApi;

            [SuppressUnmanagedCodeSecurity, DllImport("thostmduserapi", EntryPoint = "_ZN15CThostFtdcMdApi15CreateFtdcMdApiEPKcbb", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr CreateFtdcMdApi([MarshalAs(UnmanagedType.LPStr)] string pszFlowPath, bool bIsUsingUdp, bool bIsMulticast);

            [SuppressUnmanagedCodeSecurity, DllImport("thostmduserapi", EntryPoint = "_ZN15CThostFtdcMdApi13GetApiVersionEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetApiVersion();
        }
    }

#endif

}
