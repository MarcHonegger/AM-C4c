using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EchteTeiler
{
    internal class Program
    {
        private static void Main()
        {
            var numbers = new List<long>();
            var sol = new List<long>();
            var x = 2;

            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("EchteTeiler");
                Console.WriteLine($"---------------{Environment.NewLine}");

                Console.Write("Write a number: ");
                if (!long.TryParse(Console.ReadLine(), out var y) || y < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("input is not a natural number or number one is large than number two");
                    Console.ReadKey();
                    continue;
                }

                var str = new StringBuilder();
                for (var i = x; i < y + 1; i++)
                {
                    numbers.Clear();
                    sol.Clear();
                    str.Append(i + ": ");
                    for (var j = 1; j < i / 2 + 1; j++)
                        if (i % j == 0)
                        {
                            str.Append(j + ", ");
                            if (!numbers.Contains(j))
                                numbers.Add(j);

                        }

                    if (i == numbers.Sum())
                    {
                        sol.Add(i);
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    str.Remove(str.Length - 2, 1);
                    Console.WriteLine(str);
                    str.Clear();
                    Console.ResetColor();
                }

                Console.ReadKey();
                Console.Clear();

                Console.Write("The solutions are: ");
                foreach (var s in sol)
                {
                    Console.Write(s + " ");
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