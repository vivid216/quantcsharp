using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantCSharp.ProxyCTP
{
    internal class SafeNumIncrement
    {
        static int safeInstanceCount = 0;

        public static int SafeInstanceCount
        {
            get
            {
                System.Threading.Interlocked.Increment(ref safeInstanceCount);
                return safeInstanceCount;
            }
        }
    }
}
