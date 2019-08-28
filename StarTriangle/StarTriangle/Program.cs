using System;

namespace StarTriangle
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("StarTriangle");
                Console.WriteLine("---------------\n\r");

                Console.Write("Size: ");
                if (!uint.TryParse(Console.ReadLine(), out var size))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Is not a natural number");
                    Console.ReadKey();
                    continue;
                }

                for (var i = 0; i < size; i++)
                {
                    var s = "";
                    var spaces = size - 1 - i;
                    for (var j = 0; j < spaces; j++) s += " ";

                    var stars = 1 + i;
                    for (var j = 0; j < stars; j++) s += " *";
                    Console.WriteLine(s);
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