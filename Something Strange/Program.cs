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
            Console.WriteLine("Welcome to FizzBuzz!");
            Console.WriteLine("What number should I run fizzbuzz until?");

            int max = ask_for_number();
            Console.WriteLine();
            display_numbers(max);

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
        /// <summary>
        /// asks for a number and tries again until the value is above 1 and is a number
        /// </summary>
        /// <returns>number that has been asked for</returns>
        static int ask_for_number()
        {
            int value = 100;
            bool valid_number;
            do
            {
                string input = Console.ReadLine();
                try
                {
                    value = Convert.ToInt16(input);
                    valid_number = value > 1;
                }
                catch
                {
                    valid_number = false;
                }
                if (!valid_number)
                {
                    Console.WriteLine("That is not a valid number. Please enter anothe number.");
                }
            }
            while (!valid_number);
            return value;
        }
        /// <summary>
        /// displays numbers accounting for 3 being fizz and 5 being buzz
        /// </summary>
        /// <param name="max">number to count to</param>
        static void display_numbers(int max)
        {
            for (int i = 1; i <= max; i++)
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
        }
    }
}