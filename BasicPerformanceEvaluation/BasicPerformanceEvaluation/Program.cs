using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;

namespace BasicPerformanceEvaluation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("\nEnter Name: ");
            string name = Console.ReadLine();

            Console.Write("\nPress Enter to begin performance evaluation");
            Console.ReadLine();

            SpeedTest(name);

            Console.Write("\nPress Enter to exit performance evaluation");
            Console.ReadLine();
        }


        private static void SpeedTest(string name)
        {
            Stopwatch stop_watch = new Stopwatch();
            long num_iterations = 500000000;
            int num_tests = 10;
            long total_result = 0;
            long out1 = 3 * 10 ^ 10000000000000;
            long out2 = 3 * 10 ^ 10000000000000;
            

            for (int test = 0; test < num_tests; test++) {

                Console.Write("(running test " + (test + 1) + ") ");

                stop_watch.Start();

                for (int i = 0; i < num_iterations; i++)
                {
                    out1 += out2;
                    out2 -= out2;
                }

                Console.WriteLine(stop_watch.ElapsedMilliseconds + " ms");
                total_result += Convert.ToInt64(stop_watch.ElapsedMilliseconds);
                stop_watch.Reset();
            }

            long average_ms = total_result / num_tests;

            //StreamWriter record = new StreamWriter("TestScores.txt");

            Console.WriteLine("\nSpeed test result = " + average_ms);

        }
    }
}
