using System;

namespace PythagoreanTriple
{
    internal static class Program
    {
        private static void Main()
        {
            const ConsoleColor solColor = ConsoleColor.Green;
            const string solText = "is a Pythagorean Triple";
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("PythagoreanTriple");
                Console.WriteLine("---------------\n\r");

                Console.Write("Write 2 natural Numbers: \n\r");
                if (!long.TryParse(Console.ReadLine(), out var n1) || n1 < 0 ||
                    !long.TryParse(Console.ReadLine(), out var n2) || n2 < 0 ||
                    n1 == n2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write( "One Number is not a natural number or both numbers are the same");
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
                // a ^ 2 + b ^ 2
                var c = Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n2, 2));
                // If given Numbers are a/b and c
                // c ^ 2 - a/b ^ 2
                var a = Math.Sqrt(Math.Pow(n2, 2) - Math.Pow(n1, 2));

                if (c % 1 < 0.001)
                {
                    Console.Write("(" + n1 + ", " + n2 + ", ");
                    Console.ForegroundColor = solColor;
                    Console.Write(c);
                    Console.ResetColor();
                    Console.Write(") " + solText);
                }
                else if (a % 1 < 0.001 && a < n1)
                {
                    Console.Write("(");
                    Console.ForegroundColor = solColor;
                    Console.Write(a);
                    Console.ResetColor();
                    Console.Write(", " + n1 + ", " + n2 + ") " + solText);
                }
                else if (a % 1 < 0.001 && a < n2)
                {
                    Console.Write($"({n1}, ");
                    Console.ForegroundColor = solColor;
                    Console.Write(a);
                    Console.ResetColor();
                    Console.Write(", " + n2 + ") " + solText);
                }
                else
                {
                    Console.WriteLine("There's no Pythagorean Triple for these two numbers");
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\r c to clear ");
                if (Console.ReadKey().Key == ConsoleKey.C) continue;

                break;
            }
        }
    }
}