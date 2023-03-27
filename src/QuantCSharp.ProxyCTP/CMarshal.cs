using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantCSharp.ProxyCTP
{

    //待改进优化unmangedpool
    public unsafe static class CMarshal
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static IntPtr AllocHGlobal(int cbSize)
        {
            var ret = System.Runtime.InteropServices.Marshal.AllocHGlobal(cbSize);
            System.Runtime.CompilerServices.Unsafe.InitBlock(ret.ToPointer(), 0x00, (uint)cbSize);
            return ret;
        }

        internal static void FreeHGlobal(IntPtr ptr)
        {
            System.Runtime.InteropServices.Marshal.FreeHGlobal(ptr);
        }

        internal static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) where TDelegate : notnull
        {
            return System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(d);
        }

        internal static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t) => System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(ptr, t);
    }
}
