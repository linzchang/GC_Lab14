using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab14
{
    static class CountUtil
    {
        public static void Count(ICountable e, int MaxCount)
        {
            int delay = 1000;

            for (int i = 0; i < MaxCount; i++)
            {
                e.IncrementCount();
                Console.WriteLine(e.GetCountString());
                Thread.Sleep(delay);
            }
            CountChuckle.AhAhAh();
            Console.WriteLine(" ");
        }
    }
}
