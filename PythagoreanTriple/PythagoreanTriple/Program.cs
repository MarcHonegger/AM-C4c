using System;

namespace PythagoreanTriple
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("PythagoreanTriple");
                Console.WriteLine("---------------\n\r");

                if (!double.TryParse(Console.ReadLine(), out var n1) || !double.TryParse(Console.ReadLine(), out var n2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Is not a natural number");
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