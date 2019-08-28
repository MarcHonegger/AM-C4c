using System;

namespace IsPrime
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("IsPrime");
                Console.WriteLine("---------------\n\r");

                Console.Write("Number: ");
                var input = Console.ReadLine();

                if (!uint.TryParse(input, out var prime))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("At least one is not a number");
                    Console.ReadKey();
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;

                var isPrime =  prime > 1;
                for (var i = 3; i < prime; i+=2)
                {
                    if (prime % i == 0 || prime % 2 == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (!isPrime)
                    Console.WriteLine("Number is not Prime");

                if (isPrime)
                    Console.WriteLine("Number is Prime");

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