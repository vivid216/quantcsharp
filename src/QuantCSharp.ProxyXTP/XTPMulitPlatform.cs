using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

namespace QuantCSharp.ProxyXTP
{

#if WIN

    public unsafe abstract partial class QuoteApi : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_QuoteApi;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("xtpquoteapi", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?CreateQuoteApi@QuoteApi@API@XTP@@SAPEAV123@EPEBDW4XTP_LOG_LEVEL@@@Z")]
            internal static extern __IntPtr CreateQuoteApi(byte client_id, [MarshalAs(UnmanagedType.LPUTF8Str)] string save_file_path, global::QuantCSharp.ProxyXTP.XTP_LOG_LEVEL log_level);
        }
    }

#endif


#if LINUX

    public unsafe abstract partial class QuoteApi
    {
        [StructLayout(LayoutKind.Sequential, Size = 8)]
        public partial struct __Internal
        {
            internal __IntPtr vfptr_QuoteApi;

            [SuppressUnmanagedCodeSecurity, DllImport("xtpquoteapi", EntryPoint = "_ZN3XTP3API8QuoteApi14CreateQuoteApiEhPKc13XTP_LOG_LEVEL", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr CreateQuoteApi(byte client_id,  [MarshalAs(UnmanagedType.LPUTF8Str)] string save_file_path, global::QuantCSharp.ProxyXTP.XTP_LOG_LEVEL log_level);
        }
    }

#endif


}
