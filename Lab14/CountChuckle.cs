using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab14
{
    class CountChuckle
    {
        public static void AhAhAh()
        {
            int delay = 500;
            Console.Write(" ah ");
            Thread.Sleep(delay);
            Console.Write("ah ");
            Thread.Sleep(delay);
            Console.Write("ah!\n");
            Thread.Sleep(delay);
        }
    }
}
