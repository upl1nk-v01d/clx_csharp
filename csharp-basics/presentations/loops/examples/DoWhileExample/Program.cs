using System;

namespace DoWhileExample
{
    class Program
    {
        private static void Main(string[] args)
        {
            var x = 21;

            do {
                Console.WriteLine("Value of x: " + x);
                x++;
            } while (x < 20);
        }
    }
}