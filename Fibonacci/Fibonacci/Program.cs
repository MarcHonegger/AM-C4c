using System;
using System.Globalization;
using System.Text;

namespace Fibonacci
{
    internal static class Program
    {
        public static void Main()
        {
            while (true)
            { 
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("Fibonacci");
                Console.WriteLine($"---------------{Environment.NewLine}");

                double a = 0, b = 1;

                Console.WriteLine(a + " | " + b + " = " + a / b);
                for (var i = 2; i < 50; i++)
                {
                    Console.ResetColor();

                    var c = a + b;
                    a = b;
                    b = c;

                    var s = "";


                    for (int j = 2;
                        j < 22 - a.ToString(CultureInfo.InvariantCulture).Length -
                        b.ToString(CultureInfo.InvariantCulture).Length;
                        j++)
                    {
                        s += " ";
                    }

                    Console.Write($"{a} | {b} {s} = ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Math.Round(a / b, 15));

                    if (c < 0) break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\r c to clear ");
                if (Console.ReadKey().Key == ConsoleKey.C)
                {
                    Console.Clear();
                    continue;
                }

                break;
            }
        }
    }
}