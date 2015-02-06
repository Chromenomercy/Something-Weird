using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quadratic equation in standard form: ax ^ 2 + bx + c");

            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            if (Solve_X(a, b, c) != " ")
            {
                Console.WriteLine("\nX-intercept(s): " + Solve_X(a, b, c));
            }
            else
            {
                Console.WriteLine("\nNo X-intercepts");
            }
            Console.WriteLine("Y-intercept: " + Y_Intercept(c));
            Console.WriteLine("Vertex: " + Vertex(a, b, c));
            Console.WriteLine("\n\n(" + stopWatch.ElapsedMilliseconds * 0.001 + "seconds)");

            Console.ReadKey();
        }

        public static string Solve_X(double a, double b, double c)
        {
            double[] x = new double[2] { 0, 0 };

            if ((b * b - 4 * a * c) > 0)
            {
                x[0] = ((-b) + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
                x[1] = ((-b) - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
            }

            else if ((b * b - 4 * a * c) == 0)
            {
                x[0] = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                return Convert.ToString(x[0]);
            }
            else
            {
                return " ";
            }

            return Convert.ToString("(" + x[0] + ", 0) and (" + x[1] + ", 0)");
        }

        public static string Y_Intercept(double c)
        {
            double y = c;

            return Convert.ToString("(0, " + y + ")");
        }

        public static string Vertex(double a, double b, double c)
        {
            double x = -(b / (2 * a));
            double y = ((4 * a * c) - (b * b)) / (4 * a);

            return Convert.ToString("(" + x + ", " + y + ")");
        }
    }
}