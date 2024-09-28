using System;
using System.Collections.Generic;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            Console.Clear();
            Console.WriteLine($"\nList 'colors' contains 'White' color: {colors.Contains("White")}\n");
        }
    }
}
