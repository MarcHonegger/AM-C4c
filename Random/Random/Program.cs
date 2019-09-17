using System;
using System.Collections.Generic;
using System.Globalization;

namespace Random
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("Random");
                Console.WriteLine("---------------\n\r");

                /*
                if (!uint.TryParse(Console.ReadLine(), out var amount))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Is not a natural number");
                    Console.ReadKey();
                    continue;
                }
                */

                var random = new System.Random();

                var numbers = new List<int>()
                {
                    random.Next(0, 10),
                    random.Next(0, 10),
                    random.Next(0, 10)
                };

                foreach (var n in numbers)
                {
                    Console.Write(n);
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