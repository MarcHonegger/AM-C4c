using System;

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

                Console.Write("Write a number: ");
                if (!int.TryParse(Console.ReadLine(), out var x))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("input is not a natural number");
                    Console.ReadKey();
                    continue;
                }

                long b = 1, c = 0;

                for (var i = 2; i < x; i++)
                {
                    Console.Write(c + " ");

                    var a = b;
                    b = c;
                    c = a + b;

                    if (c < 0) break;
                }

                Console.WriteLine();
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