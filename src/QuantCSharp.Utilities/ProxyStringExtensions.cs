using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Buffers;

namespace QuantCSharp.Utilities
{
    /// <summary>
    /// Native类型转换帮助类
    /// </summary>
    public static class ProxyStringExtensions
    {
        /// <summary>
        /// 将字符串转换成指定长度的sbyte数组,不足的部分用默认值代替
        /// </summary>
        /// <param name="txt">字符串</param>
        /// <param name="size">转换的struct定义长度</param>
        /// <returns></returns>
        public static unsafe sbyte[] ToSbyteArray(this string txt, int size)
        {
            return txt.AsSpan().ToSbyteArray(size);
        }

        public static unsafe sbyte[] ToSbyteArray(this ReadOnlySpan<char> txt, int size)
        {
            var __value = stackalloc sbyte[size];
            fixed (char* source = &System.Runtime.InteropServices.MemoryMarshal.GetReference(txt))
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    __value[i] = (sbyte)source[i];
                }
            }

            return new Span<sbyte>(__value, size).ToArray();
        }

        public static sbyte[] ToSbyteArray(this sbyte value, int size)
        {
            var __value = new sbyte[size];
            __value[0] = value;
            return __value;
        }

        /// <summary>
        /// 将字符串转换为sbyte指针
        /// </summary>
        /// <param name="__Value"></param>
        /// <returns></returns>
        public static unsafe sbyte* ToSbytePtr(this string _Value)
        {
            return (sbyte*)Utilities.DispoIntPtr.AllocString(_Value);
        }

        /// <summary>
        /// 将sbyte数组转换成字符串
        /// </summary>
        /// <param name="__Value"></param>
        /// <returns></returns>
        public static unsafe string ToPtrString(this sbyte[] __Value)
        {
            var __s = stackalloc char[__Value.Length];
            fixed (sbyte* p = __Value)
            {
                for (int i = 0; i < __Value.Length; i++)
                {
                    __s[i] = (char)p[i];
                }
            }
            return new string(__s);
        }
    }
}
