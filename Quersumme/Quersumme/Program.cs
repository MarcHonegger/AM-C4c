using System;

namespace Quersumme
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("StarTriangle");
                Console.WriteLine($"---------------{Environment.NewLine}");

                Console.Write("Berechne die Quersumme von: ");
                if (!int.TryParse(Console.ReadLine(), out var z))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Input is not a integer");
                    Console.ReadKey();
                    continue;
                }

                var q = 0;
                var y = z;
                z = Math.Abs(z);

                while (z > 0)
                {
                    q += z % 10;
                    z /= 10;
                }

                Console.WriteLine("Die Quersumme von " + y + " ist " + q + $".{Environment.NewLine}");

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
