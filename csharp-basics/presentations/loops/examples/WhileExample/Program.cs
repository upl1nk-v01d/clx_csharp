using System;

namespace WhileExample
{
    class Program
    {
        private static void Main(string[] args)
        {
            var x = 1;

            while (x <= 4) {
                Console.WriteLine("Value of x: " + x);
                x++;
            }
        }
    }
}