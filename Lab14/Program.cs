using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Velcome to the Count's Castle! ");
            CountChuckle.AhAhAh();
            Console.WriteLine("\nLet us count some Alligators and Sheep on this fine Halloween day.\n");
            Thread.Sleep(1000);
            Console.Write("Counting Alligators ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(".\n");
            CountTestApp.RunAlligator();
            Thread.Sleep(500);
            Console.Write("Counting Sheep ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(".\n");
            CountTestApp.RunSheep();
            Console.WriteLine("\nThat is all, fang you very much for coming!");
            Console.ReadLine();
        }
    }
}
