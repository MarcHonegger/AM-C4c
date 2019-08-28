using System;

namespace Prime1To1441
{
    internal class Program
    {
        private static void Main()
        {
            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("Random");
            Console.WriteLine("---------------\n\r");

            Console.Write(2 + ", ");
            for (var i = 3; i < 1441; i += 2)
            {
                var isPrime = true;

                for (var j = 3; j < i; j+=2)
                    if (i % j == 0)
                        isPrime = false;
                
                if (isPrime)
                    Console.Write(i + ", ");
            }

            Console.ReadKey();
        }
    }
}