using System;
using System.Collections.Generic;
using System.Text;

namespace ZufallsZahl
{
    internal class Program
    {
        private static void Main()
        {
            var random = new Random();

            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("Random");
                Console.WriteLine("---------------\n\r");

                var numbers = new List<int>();

                for (var i = 1; i <= 100; i++)
                {
                    var r = random.Next(1, 7);
                    numbers.Add(r);
                }

                numbers.Sort();
                var x = numbers[0];

                foreach (var i in numbers)
                {
                    if (x != i)
                        Console.WriteLine();

                    Console.ForegroundColor = (ConsoleColor) i;
                    Console.Write(i);

                    x = i;
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