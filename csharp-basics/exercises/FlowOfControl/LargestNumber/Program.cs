using System;
using System.Collections.Generic;

namespace LargestNumber
{
    class Program
    {

        static double LargestNumber(double[] num){
            double largest = 0;
            foreach(double v in num){
                if(v>largest){
                    largest = v;
                }
            }
            return largest;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Console.ReadLine();

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Console.ReadLine();

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Console.ReadLine();
        
            List<double> numbers = new List<double>();
            numbers.Add(double.Parse(input1));
            numbers.Add(double.Parse(input2));
            numbers.Add(double.Parse(input3));

            Console.WriteLine();
            Console.WriteLine($"Your largest number is {LargestNumber(numbers.ToArray())}");
        }
    }
}
