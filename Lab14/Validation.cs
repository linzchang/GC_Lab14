using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab14
{
    class Validation
    {

        public static string GetName(string message)
        {
            Console.WriteLine(message);
            string answer = Console.ReadLine();

            while (true)
            {
                if (Regex.IsMatch(answer, @"[0-9]"))
                {
                    answer = GetName($"{answer} is not a valid input, please do not enter any numbers.");
                    continue;
                }
                else
                {
                    return answer;
                }
            }
        }

        public static int GetNumber(string message)
        {
            int number;

            while (true)
            {
                Console.Write(message);
                bool parsed = int.TryParse(Console.ReadLine(), out number);
                if (!parsed || number < 0)
                {
                    Console.WriteLine("That is not valid, please enter a positive number.");
                }
                else
                {
                    return number;
                }
            }
        }
    }
}
