using System;

namespace QuantCSharp.Utilities
{
    /// <summary>
    /// 自定一个线程同步锁
    /// </summary>
    public class AsyncManualWaitLock
    {
        static System.Threading.ManualResetEvent resetEvent = new System.Threading.ManualResetEvent(false);
        private static object p_lock = new object();
        private static volatile int p_wait_cnt = -1;

        /// <summary>
        /// 处理此逻辑一定在wait前确保release未被执行
        /// </summary>
        public static void Wait()
        {
            lock (p_lock)
            {
                if (p_wait_cnt == 0)
                {
                    return;
                }
            }
            resetEvent.Reset();
            resetEvent.WaitOne(TimeSpan.FromMilliseconds(int.MaxValue -1), true);
            p_wait_cnt = -1;

        }

        public static void Release()
        {
            lock (p_lock)
            {
                resetEvent.Set();
                p_wait_cnt = 0;
            }
        }

        public static void Reset()
        {
            lock (p_lock)
            {
                p_wait_cnt = -1;
            }
        }
    }
}
