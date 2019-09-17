using System;
using System.Diagnostics;

namespace TestKVSM
{
    internal class Program
    {
        private static void Main()
        {
            const ConsoleColor solColor = ConsoleColor.Green;
            const string solText = "is a Pythagorean Triple";

            Console.WriteLine("PythagoreanTriple");
            Console.WriteLine("---------------\n\r");

            Console.Write("Write 2 natural Numbers: \n\r");

            var sw1 = new Stopwatch();
            var sw2 = new Stopwatch();

            var count = 0;
            var x = 10001;
            sw1.Start();
            for (var i = 1; i < x; i++)
            for (var j = i + 1; j < x; j++)
            {
                var n1 = i;
                var n2 = j;

                var c = Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n2, 2));
                var a = Math.Sqrt(Math.Pow(n2, 2) - Math.Pow(n1, 2));

                // ReSharper disable once CompareOfFloatsByEqualityOperator
                if (c % 1 == 0)
                {
                    Console.Write($"({n1}, {n2}, ");
                    Console.ForegroundColor = solColor;
                    Console.Write(c);
                    Console.ResetColor();
                    Console.WriteLine(") " + solText);
                    count++;
                }
                // ReSharper disable once CompareOfFloatsByEqualityOperator
                else
                {
                    // ReSharper disable once SwitchStatementMissingSomeCases
                    switch (a % 1)
                    {
                        // ReSharper disable once CompareOfFloatsByEqualityOperator
                        case 0 when a < n1:
                            Console.Write("(");
                            Console.ForegroundColor = solColor;
                            Console.Write(a);
                            Console.ResetColor();
                            Console.WriteLine($", {n1}, {n2}) {solText}");
                            count++;
                            break;
                        case 1 when a < n2:
                            Console.Write($"({n1}, ");
                            Console.ForegroundColor = solColor;
                            Console.Write(a);
                            Console.ResetColor();
                            Console.WriteLine($", {n2}) {solText}");
                            count++;
                            break;
                    }
                }
            }

            sw1.Stop();
            // Console.Clear(); 717ms
            Console.WriteLine("\r\n1: " + sw1.ElapsedMilliseconds + "ms / counter: " + count + " / max: " + x);
            Console.ReadKey();
        }
    }
}