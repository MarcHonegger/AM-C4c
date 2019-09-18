using System;

namespace Vasen
{
    class Program
    {
        static void Main()
        {
            var x = 0.0;
            var y = 0.0;
            for (var i = 0.05; i < 5; i+=0.05)
            {
                Console.WriteLine(i + ": " + ((i * 50) + 200) * (10 - i));
                if (y < ((i * 50) + 200) * (10 - i))
                {
                    y = ((i * 50) + 200) *(10 - i);
                    x = i;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(x);
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
