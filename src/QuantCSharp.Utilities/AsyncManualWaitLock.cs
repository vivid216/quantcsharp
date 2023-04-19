using System;
using System.Threading;

namespace QuantCSharp.Utilities
{
    /// <summary>
    /// 自定一个线程同步锁
    /// </summary>
    public static class AsyncManualWaitLock
    {
        static System.Threading.CountdownEvent resetEvent = new System.Threading.CountdownEvent(0);
        static volatile int m_current_status = 0; // 1:running;0:free
        private static IAsyncLog _logger = LogManager.GetLogger(typeof(AsyncManualWaitLock));

        /// <summary>
        /// 处理此逻辑一定在wait前确保release未被执行
        /// </summary>
        public static void Wait()
        {
            bool waitSignal = resetEvent.Wait(Timeout.InfiniteTimeSpan);
            if (!waitSignal)
            {
                _logger.Error($"receive waitSignal timeout!");
            }
        }

        public static void Release()
        {
            if (Interlocked.CompareExchange(ref m_current_status, 0, 1) == 1)
            {
                if (!resetEvent.IsSet)
                {
                    try
                    {
                        resetEvent.Signal();
                    }
                    catch (InvalidOperationException)
                    {
                        _logger.Warn("best check 1v1 signal attempt made to decrement the event's count");
                    }
                }
            }
            else
            {
                _logger.Warn("no reset before release, best check 1v1 signal");
            }
        }

        public static void Reset()
        {
            SpinWait spin = new SpinWait();
            while (true)
            {
#pragma warning disable 0420
                if (Interlocked.CompareExchange(ref m_current_status, 1, 0) == 0)
#pragma warning restore 0420
                {
                    resetEvent.Reset(1);
                    break;
                }
                // The CAS failed.  Spin briefly and try again.
                spin.SpinOnce();
            }
        }
    }
}
