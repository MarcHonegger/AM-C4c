using System;

namespace Palindrome
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("Random");
                Console.WriteLine("---------------\n\r");

                Console.Write("Write a series of Number: ");

                var input = Console.ReadLine();
                var output = "";

                if (input is null)
                    continue;

                for (var i = 0; i < input.Length; i++) output += input[input.Length - 1 - i];

                Console.WriteLine(output);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(output);

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