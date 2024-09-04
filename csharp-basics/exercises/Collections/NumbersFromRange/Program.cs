using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            var random = new Random();
            var numbers = new List<int>();

            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }

            var filteredNumbers = new List<int>();

            foreach(var number in numbers)
            {
                if(number > 30 && number < 100)
                {
                    filteredNumbers.Add(number);
                }
            }

            foreach(var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
