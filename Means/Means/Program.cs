using System;
using System.Collections.Generic;

namespace Means
{
    internal static class Program
    {
        private static void Main()
        {
            var resDescriptions = new List<string>(){"arithmetic mean", "geometric mean", "harmonic mean", "quadratic mean"};

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

                var resolutions = new List<double>
                {
                    (double1 + double2) / 2,
                    Math.Sqrt(double1 * double2),
                    2 / (1 / double2 + 1 / double1),
                    Math.Sqrt((Math.Pow(double1, 2) + Math.Pow(double2, 2)) / 2)
                };

                for (var i = 0; i < resolutions.Count; i++)
                {
                    Console.Write(resDescriptions[i] + ": ");
                    Console.WriteLine(resolutions[i]);
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