using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();
            long absoluteNumber = Math.Abs(Int64.Parse(input));

            if(absoluteNumber > 10000000000)
            {
                Console.WriteLine($"Your {input} absolute number is above TEN BILLION");
            }

            else 
            {
                Console.WriteLine($"Your {input} absolute number is {absoluteNumber}");
            }
        }
    }
}
