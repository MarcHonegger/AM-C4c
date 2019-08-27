using System;

namespace GreetApp
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("GreetApp");
                Console.WriteLine("---------------\n\r");
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Dear " + name);

                
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
