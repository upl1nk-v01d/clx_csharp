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
            var i = 10;

            while (i-->0)
            {
                numbers.Add(random.Next(1, 100));
            }

            var filteredNumbers = numbers.Where(n => n > 30 && n < 100).ToList();

            filteredNumbers.ForEach(Console.WriteLine);
        }
    }
}
