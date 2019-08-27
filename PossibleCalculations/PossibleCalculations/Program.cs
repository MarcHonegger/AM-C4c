using System;
using System.Collections.Generic;

namespace PossibleCalculations
{
    internal static class Program
    {
        private static void Main()
        {
            var resDescriptions = new List<string>(){"A + B", "A - B", "B - A", "A * B", "A / B", "B / A"};

            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("PossibleCalculations");
                Console.WriteLine("---------------\n\r");

                Console.Write("A: ");
                var line1 = Console.ReadLine();
                Console.Write("B: ");
                var line2 = Console.ReadLine();

                if (!uint.TryParse(line1, out var number1) || !uint.TryParse(line2, out var number2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("At least one is not a natural number");
                    Console.ReadKey();
                    continue;
                }

                double double1 = number1;
                double double2 = number2;

                var resolutions = new List<double>()
                {
                    (double1 + double2),
                    (double1 - double2),
                    (double2 - double1),
                    (double1 * double2),
                    (double1 / double2),
                    (double2 / double1),
                };

                for (int i = 0; i < resolutions.Count; i++)
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