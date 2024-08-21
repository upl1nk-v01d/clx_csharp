using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadLine();
        
            if (double.Parse(input) > 0)
            {
                Console.WriteLine("Number is positive");
            } 

            else if (double.Parse(input) < 0)
            {
                Console.WriteLine("Number is negative");
            } 

            else if (double.Parse(input) == 0)
            {
                Console.WriteLine("Number is zero");
            }
        }
    }
}
