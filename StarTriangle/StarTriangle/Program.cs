using System;

namespace StarTriangle
{
    internal static class Program
    {
        private static void Main()
        {
            var r = new Random();

            while (true)
            {
                var rainbow = false;
                var filled = false;
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("StarTriangle");
                Console.WriteLine("---------------\n\r");

                Console.Write("Size: ");
                if (!uint.TryParse(Console.ReadLine(), out var size))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Input is not a natural number");
                    Console.ReadKey();
                    continue;
                }
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Click R for Rainbow");
                if (Console.ReadKey(true).Key == ConsoleKey.R) rainbow = true;
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Click F to fill");
                if (Console.ReadKey(true).Key == ConsoleKey.F) filled = true;

                Console.WriteLine();

                for (var i = 0; i < size - 1; i++)
                {
                    var s = "  ";
                    var spaces = size - 1 - i;
                    for (var j = 0; j < spaces; j++) s += " ";

                    var stars = 1 + i;
                    if (stars >= 3 && !filled)
                    {
                        s += " *";
                        for (var j = 2; j < stars; j++) s += "  ";
                        s += " *";
                    }
                    else
                    {
                        for (var j = 0; j < stars; j++) s += " *";
                    }

                    if (rainbow) Console.ForegroundColor = (ConsoleColor) r.Next(1, 16);
                    else Console.ResetColor();

                    Console.WriteLine(s);
                }

                Console.Write("  ");
                for (var i = 0; i < size; i++) Console.Write(" *");
                Console.WriteLine();

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