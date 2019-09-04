using System;
using System.Text;

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
                Console.WriteLine($"---------------{Environment.NewLine}");

                Console.Write("Size: ");
                if (!int.TryParse(Console.ReadLine(), out var size) || size < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Input is not a natural number");
                    Console.ReadKey();
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Click R for Colored");
                if (Console.ReadKey(true).Key == ConsoleKey.R)
                    rainbow = true;

                Console.WriteLine("Click F to fill");
                if (Console.ReadKey(true).Key == ConsoleKey.F) 
                    filled = true;
                
                Console.ResetColor();

                Console.WriteLine();

                const string leftPad = "  ";
                const char fillChar = '*';
                const char spacing = ' ';

                var s = new StringBuilder();
                for (var stars = 1; stars <= size; stars++)
                {
                    s.Append(leftPad);

                    var spaces = size - stars;
                    s.Append(spacing, spaces);

                    if (filled || stars == size)
                    {
                        for (var j = 0; j < stars; j++)
                        {
                            s.Append(spacing);
                            s.Append(fillChar);
                        }
                    }
                    else
                    {
                        s.Append(spacing);
                        s.Append(fillChar);
                        if (stars > 1)
                        {
                            s.Append(spacing, (stars - 1) * 2 - 1);
                            s.Append(fillChar);
                        }
                    }

                    s.AppendLine();

                    if (rainbow)
                    {
                        Console.ForegroundColor = (ConsoleColor) r.Next(1, 16);
                    }
                }
                Console.WriteLine(s);

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Click C to clear ");
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