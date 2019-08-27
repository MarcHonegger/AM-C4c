using System;
using System.Linq;

namespace DecToBin
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("DecToBin");
                Console.WriteLine("---------------\n\r");

                Console.Write("Decimal: ");
                var input = Console.ReadLine();

                if (!uint.TryParse(input, out var dec))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("At least one is not a number");
                    Console.ReadKey();
                    continue;
                }
                
                var result = "";
                while (dec > 0)
                {
                    var remainder = dec % 2;
                    dec /= 2;
                    result += remainder;
                }

                result = ReverseString(result);

                Console.WriteLine(result);

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

        private static string ReverseString(string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}