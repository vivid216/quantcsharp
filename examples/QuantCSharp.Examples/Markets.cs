using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    class Markets
    {
        static async Task Main(string[] args)
        {
            var ctp = new CtpMarketSubs();
            Console.ReadLine();
            await Task.CompletedTask;
        }
    }
}
