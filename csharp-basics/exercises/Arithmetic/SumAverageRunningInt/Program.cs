using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0m; //redefined vartype from in to decimal
            decimal average; //redefined vartype from in to decimal
            int c = 0; //iterations counter for average calculations
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number; c++;
            }
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}");

            average = sum / c; //average calculation

            Console.WriteLine($"The average is {average:0.0}");
            Console.WriteLine();
        }
    }
}
