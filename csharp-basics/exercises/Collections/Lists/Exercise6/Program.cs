﻿using System;
using System.Collections.Generic;

namespace ListExercise6
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            Console.WriteLine(string.Join(",", colors));

            //TODO: Remove the third element from the list.

            Console.WriteLine("After removing third element from the list:");
            Console.WriteLine(string.Join(",", colors));
        }
    }
}