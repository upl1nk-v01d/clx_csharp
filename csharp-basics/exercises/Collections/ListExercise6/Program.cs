using System;
using System.Collections.Generic;

namespace ListExercise6
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

            Console.WriteLine(string.Join(",", colors));

            colors.RemoveAt(2);

            Console.WriteLine("\nAfter removing third element from the list:\n");
            Console.WriteLine(string.Join(",", colors));
        }
    }
}
