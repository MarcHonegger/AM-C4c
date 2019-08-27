﻿using System;

namespace Calc
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
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

                if (!double.TryParse(line1, out var double1) || !double.TryParse(line2, out var double2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("At least one is not a number");
                    Console.ReadKey();
                    continue;
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

}