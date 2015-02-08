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

            Console.Write("\nEnter how many times to run evaluation, or -1 for an infinate loop: ");
            string setting = Console.ReadLine();
            if (setting == "-1"){

                while (true)
                {
                    SpeedTest(name);
                }
            }

            else{
                try
                {
                    int num_full_tests = Convert.ToInt32(setting);
                    while (num_full_tests > 0)
                    {
                        SpeedTest(name);
                        num_full_tests -= 1;
                    }
                }
                catch
                {

                    Console.Write("Invalid command");
                }
            }

            Console.Write("\nPress Enter to exit performance evaluation");
            Console.ReadLine();
        }

        private static void SpeedTest(string name)
        {
            Stopwatch stop_watch = new Stopwatch();
            long num_iterations = 500000000;
            int num_tests = 10;
            long total_result = 0;
            long out1 = 10000000;
            long out2 = 10000000;
            
            //test
            for (int test = 0; test < num_tests; test++) {

                Console.Write("(running test " + (test + 1) + ") ");

                stop_watch.Start();

                for (int i = 0; i < num_iterations; i++)
                {
                    out1 += out2;
                    out2 -= out2;
                }

                total_result += Convert.ToInt64(stop_watch.ElapsedMilliseconds);
                Console.WriteLine(stop_watch.ElapsedMilliseconds + " ms");
                stop_watch.Reset();
            }

            long average_ms = total_result / num_tests;

            StringBuilder newtext = new StringBuilder();

            //write score and name to text doc
            try
            {
                using (StreamReader text = new StreamReader("TestScores.txt"))
                {
                    newtext.AppendLine(text.ReadToEnd());
                    newtext.AppendLine(Convert.ToString(name + ": " + average_ms));
                }
                Console.WriteLine("Found TextScores.txt");
            }

            catch
            {
                Console.WriteLine("Creating new file names TestScores.txt");
                newtext.AppendLine(Convert.ToString(name + ": " + average_ms));
            }

            StreamWriter out_file = new StreamWriter("TestScores.txt");

            out_file.Write(newtext.ToString());
            out_file.Close();

            Console.WriteLine("\nSpeed test result = " + average_ms + "\n");

        }
    }
}
