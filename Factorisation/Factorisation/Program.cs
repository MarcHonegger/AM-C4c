using System;
using System.Collections.Generic;

namespace Factorisation
{
    internal static class Program
    {
        private static bool IsPrime(long x)
        {
            var max = Math.Ceiling(Math.Sqrt(x));
            for (var j = 3; j < max; j += 2)
                if (x % j == 0)
                    return false;

            return true;
        }

        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("Factorisation");
                Console.WriteLine($"---------------{Environment.NewLine}");

                Console.Write("Write a number: ");
                if (!long.TryParse(Console.ReadLine(), out var x) || x < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("input is not a natural number");
                    Console.ReadKey();
                    continue;
                }


                if (IsPrime(x))
                {
                    Console.WriteLine("In Prime Factors: " + x);
                }
                else
                {
                    var primeNumbers = new List<long> {2};

                    var max = Math.Ceiling(Math.Sqrt(x));
                    for (var j = 3; j <= max; j += 2)
                        if (IsPrime(j))
                            primeNumbers.Add(j);

                    Console.Write("In Prime Factors: ");

                    var y = x;
                    foreach (var primeNumber in primeNumbers)
                        while (y % primeNumber == 0)
                        {
                            if (y != x) Console.Write(", ");

                            Console.Write(primeNumber);
                            y /= primeNumber;
                        }
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