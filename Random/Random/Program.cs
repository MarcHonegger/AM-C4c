using System;
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

                if (!uint.TryParse(Console.ReadLine(), out var amount))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Is not a natural number");
                    Console.ReadKey();
                    continue;
                }

                var random = new System.Random();
                for (var i = 0; i < amount; i++) Console.WriteLine(random.Next());

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