using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(",", firstList));

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(",", secondList));

            string joinedStrings = string.Join(",", firstList) + "," + string.Join(",", secondList);
            
            Console.WriteLine("\nPrinting joined strings...\n");
            Console.WriteLine(joinedStrings);
        }
    }
}
