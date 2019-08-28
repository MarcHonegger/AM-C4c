﻿using System;
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

                var x = int.Parse(Console.ReadLine());
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
                while (true)
                {
                    if (count >= primeNumbers.Count)
                    {
                        count = -1;
                        break;
                    }

                    if (x % primeNumbers[count] == 0)
                    {
                        Console.WriteLine(primeNumbers[count]);
                        x /= primeNumbers[count];
                        count = -1;
                    }

                    count++;
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