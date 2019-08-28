using System;

namespace PythagoreanTriple
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("PythagoreanTriple");
                Console.WriteLine("---------------\n\r");

                Console.Write("Write 2 natural Numbers: \n\r");
                if (!double.TryParse(Console.ReadLine(), out var n1) || !double.TryParse(Console.ReadLine(), out var n2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Is not a natural number");
                    Console.ReadKey();
                    continue;
                }

                if (n2 < n1)
                {
                    var temp = n1;
                    n1 = n2;
                    n2 = temp;
                }

                // If given Numbers are a and b
                var c = Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n2, 2));
                // If given Numbers are a/b and c
                var a = Math.Sqrt(-Math.Pow(n1, 2) + Math.Pow(n2, 2));

                if (c % 1 < 0.01)
                {
                    Console.Write("a: " + n1 + ", b: " + n2 + ", ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("c: " + c);
                }
                else if (a % 1 < 0.01)
                { 
                    Console.WriteLine("The Solution is " + a);
                }
                else
                {
                    Console.WriteLine("There's no Pythagorean Triple for these two numbers");
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