using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace TestKVSM
{
    internal class Program
    {
        private static void Main()
        {
            const ConsoleColor solColor = ConsoleColor.Green;
            const string solText = "is a Pythagorean Triple";

            Console.WriteLine("PythagoreanTriple");
            Console.WriteLine("---------------\n\r Calculating...");

            var sw1 = new Stopwatch();
            var sw2 = new Stopwatch();

            var count = 0;
            var count2 = 0;
            for (var x = 2500; x < 2501; x++)
            {
                Console.ResetColor();
                sw1.Start();
                for (var i = 1; i < x; i++)
                for (var j = i + 1; j < x; j++)
                {
                    var c = Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
                    var a = Math.Sqrt(Math.Pow(j, 2) - Math.Pow(i, 2));

                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    if (c % 1 == 0)
                    {
                        // Console.WriteLine($"({i}, {j}, {c}) {solText}");
                        count++;
                    }
                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    else
                    {
                        // ReSharper disable once SwitchStatementMissingSomeCases
                        switch (a % 1)
                        {
                            // ReSharper disable once CompareOfFloatsByEqualityOperator
                            case 0 when a < i:
                                Console.WriteLine($"({a}, {i}, {j}) {solText}");
                                count++;
                                break;
                            case 1 when a < j:
                                Console.WriteLine($"({i}, {a}, {j}) {solText}");
                                count++;
                                break;
                        }
                    }
                }

                sw1.Stop();
                
                // Console.ForegroundColor = ConsoleColor.Yellow;
                // onsole.WriteLine("SW1: " + sw1.ElapsedMilliseconds);
                Console.ForegroundColor = solColor;
                // Console.ReadKey();
                sw2.Start();
                for (var i = 1; i < x; i++)
                for (var j = i + 1; j < x; j++)
                {
                    var found = false;
                    long a1 = i, b1 = j, c1;
                    for (c1 = b1; c1 < a1 + b1; c1++)
                        if (a1 * a1 + b1 * b1 == c1 * c1)
                        {
                            Console.WriteLine("(" + a1 + ", " + b1 + ", " + c1 + ") ist ein passendes Tripel");
                            count2++;
                            found = true;
                        }

                    c1 = b1;
                    for (b1 = a1; b1 < c1; b1++)
                        if (a1 * a1 + b1 * b1 == c1 * c1)
                        {
                            Console.WriteLine("(" + a1 + ", " + b1 + ", " + c1 + ") ist ein passendes Tripel");
                            count2++;
                        }
                }

                sw2.Stop();
            }

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Marc: " + sw1.ElapsedMilliseconds / 1000 + "s (" + count + ") / Köstler: " + sw2.ElapsedMilliseconds / 1000 + "s" + "(" + count2 + ")");
            Console.ReadKey();
        }
    }
}