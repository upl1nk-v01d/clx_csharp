using System;
using System.Collections.Generic;

namespace ListExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.Clear();
            
            Console.WriteLine("Original array list: ");
            Console.WriteLine(string.Join(",", colors));

            colors.Clear();

            Console.WriteLine("New array list: ");
            Console.WriteLine(string.Join(",", colors));
        }
    }
}
