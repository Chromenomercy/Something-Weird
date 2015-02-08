using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BasicPerformanceEvaluation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("\nPress Enter to begin performance evaluation");
            Console.ReadLine();

            SpeedTest();

            Console.Write("\nPress Enter to exit performance evaluation");
            Console.ReadLine();
        }


        private static void SpeedTest()
        {
            Stopwatch stop_watch = new Stopwatch();
            long num_iterations = 100000000;
            int num_tests = 12;
            long total_result = 0;
            long out1 = 3 * 10 ^ 100000;
            long out2 = 3 * 10 ^ 100000;
            

            for (int test = 0; test < num_tests; test++) {

                Console.WriteLine("Beginning test " + (test + 1));

                stop_watch.Start();

                for (int i = 0; i < num_iterations; i++)
                {
                    out1 += out2;
                    out2 -= out2;
                }

                total_result += Convert.ToInt64(stop_watch.ElapsedMilliseconds);
                stop_watch.Reset();
            }

            long average_ms = total_result / num_tests;

            Console.WriteLine("Speed test result = " + average_ms);

        }
    }
}
