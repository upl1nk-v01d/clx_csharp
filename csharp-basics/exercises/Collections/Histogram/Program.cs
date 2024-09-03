using System;
using System.IO;
using System.Collections.Generic;

namespace Histogram
{
    class Program
    {
        private const string Path = "../Histogram/midtermscores.txt";

        private static List<string> stars = new List<string>(new string[11]); 

        private static void AddStarToList(int position)
        {
            stars[position] += "*";
        }

        private static void Main(string[] args)
        {
            Console.Clear();
            
            var readText = File.ReadAllLines(Path);
            
            foreach (var line in readText)
            {
                string[] nums = line.Split(" ");

                foreach(var num in nums)
                {
                    AddStarToList(Convert.ToInt32(Math.Floor(double.Parse(num) * 0.1)));
                }
            }

            var i = 0;
            
            foreach (var star in stars)
            {
                i++;
                
                if(i > 10)
                {
                    Console.WriteLine($"  100: {star}");
                } 
                else
                {
                    Console.WriteLine($"{(i - 1) % 10 * 10:0#}-{i * 10 - 1:0#}: {star}");
                }   
            }
        }
    }
}
