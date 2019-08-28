using System;
using System.Collections.Generic;

namespace PossibleCalculations
{
    internal static class Program
    {
        private static void Main()
        {
            // Console.OutPutEncoding = System.Text.Encoding.Unicode;
            // ConsoleKeyInfo cki;

            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("PossibleCalculations");
                Console.WriteLine("---------------\n\r");

                Console.Write("Enter a Number: ");
                var line1 = Console.ReadLine();
                Console.Write("Enter a second Number: ");
                var line2 = Console.ReadLine();

                if (!double.TryParse(line1, out var double1) || !double.TryParse(line2, out var double2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("At least one is not a natural number");
                    Console.ReadKey();
                    continue;
                }

                var resolutions = new List<double>()
                {
                    (double1 + double2),
                    (double1 - double2),
                    (double2 - double1),
                    (double1 * double2),
                    (double1 / double2),
                    (double2 / double1),
                    (Math.Pow(double1, double2)),
                    (Math.Pow(double2, double1)), 
                    Math.PI * double1 * double2
                };

                var resDescriptions = new List<string>()
                {
                    double1 + " + " + double2, double1 + " - " + double2, double2 + " - " + double1,
                    double1 + " * " + double2, 
                    Math.Abs(double2) > 0.01 ? double1 + " / " + double2 : double1 + " / " + double2 + ": Is not defined !", 
                    Math.Abs(double1) > 0.01 ? double2 + " / " + double1 : double2 + " / " + double1 + ": Is not defined !",
                    double1 + " ^ " + double2, double2 + " ^ " + double1, double1 + " * " + double2 + "* PI"
                };

                for (int i = 0; i < resolutions.Count; i++)
                {
                    if (!resDescriptions[i].Contains("!"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(resDescriptions[i] + ": ");
                        Console.ResetColor();
                        Console.WriteLine(resolutions[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(resDescriptions[i]);
                    }
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