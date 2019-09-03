using System;
using System.Collections.Generic;

namespace Means
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("Means");
                Console.WriteLine("---------------\n\r");

                Console.Write("A: ");
                var line1 = Console.ReadLine();
                Console.Write("B: ");
                var line2 = Console.ReadLine();

                if (!double.TryParse(line1, out var double1) || !double.TryParse(line2, out var double2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("At least one is not a number");
                    Console.ReadKey();
                    continue;
                }

                var res = new List<(string title, double result)>
                {
                    ("arithmetic mean", (double1 + double2) / 2),
                    ("geometric mean", Math.Sqrt(double1 * double2)),
                    ("harmonic mean", 2 / (1 / double2 + 1 / double1)),
                    ("quadratic mean", Math.Sqrt((Math.Pow(double1, 2) + Math.Pow(double2, 2)) / 2))
                };

                foreach (var (title, result) in res)
                {
                    Console.WriteLine($"{title}: {result}");
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