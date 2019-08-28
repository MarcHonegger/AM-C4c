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

                Console.Write("Write a number: ");
                if (!uint.TryParse(Console.ReadLine(), out var x))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("input is not a natural number");
                    Console.ReadKey();
                    continue;
                }

                var primeNumbers = new List<int> {2};

                var isPrime = true;

                for (var j = 3; j < x; j += 2)
                    if (x % j == 0)
                        isPrime = false;

                if (isPrime)
                {
                    Console.Write("\n In Prime Factors: " + x);
                }
                else
                {
                    for (var j = 3; j <= x / 2; j += 2)
                    {
                        for (var i = 2; i < j; i++)
                            if (j % i == 0)
                                break;

                        primeNumbers.Add(j);
                    }

                    Console.Write("In Prime Factors: ");

                    const int count = 0;
                    double y = x;
                    while (true)
                    {
                        if (count >= primeNumbers.Count) break;

                        if (Math.Abs(y % primeNumbers[count]) < 0.01)
                        {
                            if (Math.Abs(y - x) > 0.01) Console.Write(", ");
                            Console.Write(primeNumbers[count]);
                            y /= primeNumbers[count];
                            continue;
                        }

                        primeNumbers.RemoveAt(0);
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