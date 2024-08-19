using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();
            int absoluteNumber = Math.Abs(int.Parse(input));
            Console.WriteLine($"Your {input} absolute number is {absoluteNumber}");
        }
    }
}
