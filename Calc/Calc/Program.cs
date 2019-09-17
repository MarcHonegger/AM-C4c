using System;

namespace Calc
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
                // Command line arguments  
                Console.WriteLine("Argument length: " + args.Length);  
                Console.WriteLine("Supplied Arguments are: ");  
                foreach (var obj in args)  
                {
                    Console.WriteLine(obj);       
                }
        }
    }
}