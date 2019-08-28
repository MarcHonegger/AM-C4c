using System;
using System.Collections.Generic;

namespace Factorisation
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("Factorisation");
                Console.WriteLine("---------------\n\r");

                if (!uint.TryParse(Console.ReadLine(), out var x))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("input is not a natural number");
                    Console.ReadKey();
                    continue;
                }
                var primeNumbers = new List<int> {2};

                for (var i = 3; i < x; i += 2)
                {
                    var isPrime = true;

                    for (var j = 3; j < i; j += 2)
                        if (i % j == 0)
                            isPrime = false;

                    if (isPrime)
                        primeNumbers.Add(i);
                }

                var count = 0;
                double y = x;
                while (true)
                {
                    if (count >= primeNumbers.Count)
                    {
                        count = 0;
                        break;
                    }

                    if (Math.Abs(y % primeNumbers[count]) < 0.01)
                    {
                        if (Math.Abs(y - x) > 0.01) Console.Write(", ");
                        Console.Write(primeNumbers[count]);
                        y /= primeNumbers[count];
                        count = -1;
                    }

                    count++;
                }

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