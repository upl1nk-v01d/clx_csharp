using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create an List with string elements
            List<string> list = new List<string>();

            //TODO: Add 10 values to list
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            var random = new Random();
            string str = "";

            for(var i1 = 0; i1 < 10; i1++)
            {
                for(var i2 = 0; i2 < 3; i2++)
                {
                    str += chars[random.Next(0, chars.Length)];
                }

                list.Add(str);
                str = "";
            }

            Console.Clear();
            Console.WriteLine("\n\nPrinting unsorted 'list'...\n");

            list.Insert(4, "-- 5th_position [Foobar]");
            list[list.Count-1] = "-- changed last position value :)";
            list.ForEach(Console.WriteLine);

            Console.WriteLine("\n\nPrinting sorted 'list'...\n");
            list.Sort();
            list.ForEach(Console.WriteLine);

            bool contains = list.Contains("Foobar");
            int index =  list.FindIndex(i => i.Contains("Foobar"));

            Console.WriteLine("\n");
            Console.WriteLine($"'list' contains substring 'Foobar' at position {index + 1}");
        }
    }
}
