using System;

namespace PowersOf2
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("PowerOf2App");
                Console.WriteLine("---------------\n\r");

                Console.Write("Exponent: ");
                if (!int.TryParse(Console.ReadLine(), out var exponent))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Is not a natural number");
                    Console.ReadKey();
                    continue;
                }

                var s = " ";
                for (var i = 0; i < exponent; i++) s += Math.Pow(2, i) + " ";

                Console.WriteLine(s);

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