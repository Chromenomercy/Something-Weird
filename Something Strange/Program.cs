using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something_Strange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz!\n");
            for (int i = 1; i <= 100; i++)
            {
                bool multiple_of_3 = i % 3 == 0;
                bool multiple_of_5 = i % 5 == 0;
                if (multiple_of_3 && multiple_of_5)
                    Console.WriteLine("FizzBuzz");
                else if (multiple_of_3)
                    Console.WriteLine("Fizz");
                else if (multiple_of_5)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.ReadKey();
            Shout();
        }
        /// <summary>
        /// Shouts
        /// </summary>
        static void Shout()
        {
            Console.WriteLine("AHAHAHAHAHAHHAHAHAHA");
        }
    }
}
