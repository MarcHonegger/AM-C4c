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

            var q = int.Parse(Console.ReadLine());

            var sw1 = new Stopwatch();
            var sw2 = new Stopwatch();

            var count = 0;
            var count2 = 0;
            for (var x = 1; x < q; x++)
            {
                Console.ResetColor();
                sw1.Start();
                for (var j = x + 1; j < q; j++)
                {
                    var c = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(j, 2));
                    var a = Math.Sqrt(Math.Pow(j, 2) - Math.Pow(x, 2));

                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    if (c % 1 == 0)
                        // Console.WriteLine($"({i}, {j}, {c}) {solText}");
                        count++;
                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    else
                        // ReSharper disable once SwitchStatementMissingSomeCases
                        switch (a % 1)
                        {
                            // ReSharper disable once CompareOfFloatsByEqualityOperator
                            case 0 when a < x:
                                // Console.WriteLine($"({a}, {i}, {j}) {solText}");
                                count++;
                                break;
                            // case 0 when a < j:
                                // Console.WriteLine($"({i}, {a}, {j}) {solText}");
                                // count++;
                                //   break;
                        }

                    // Console.WriteLine(i + " | " + x);
                }

                sw1.Stop();
                Console.WriteLine(x);
            }

            for (var x = 1; x < q; x++)
            {
                // Console.ForegroundColor = ConsoleColor.Yellow;
                // onsole.WriteLine("SW1: " + sw1.ElapsedMilliseconds);
                Console.ForegroundColor = solColor;
                // Console.ReadKey();
                sw2.Start();
                for (var j = x + 1; j < q; j++)
                {
                    long a1 = x, b1 = j, c1;
                    for (c1 = b1; c1 < a1 + b1; c1++)
                        if (a1 * a1 + b1 * b1 == c1 * c1)
                            // Console.WriteLine("(" + a1 + ", " + b1 + ", " + c1 + ") ist ein passendes Tripel");
                            count2++;

                    c1 = b1;
                    for (b1 = a1; b1 < c1; b1++)
                        if (a1 * a1 + b1 * b1 == c1 * c1)
                            // Console.WriteLine("(" + a1 + ", " + b1 + ", " + c1 + ") ist ein passendes Tripel");
                            count2++;
                }

                // Console.WriteLine(i + " | " + x);

                sw2.Stop();

                Console.WriteLine(x);
            }

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Marc: " + sw1.ElapsedMilliseconds / 1000 + "." + sw1.ElapsedMilliseconds % 1000 + "s (" +
                              count + ") / Köstler: " + sw2.ElapsedMilliseconds / 1000 + "." +
                              sw2.ElapsedMilliseconds % 1000 + "s" + "(" + count2 + ")");
            Console.ReadKey();
        }
    }
}