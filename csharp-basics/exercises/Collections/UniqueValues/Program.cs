using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        public static List<string> uniques = new List<string>();

        public static void IterateUniques()
        {
            Console.WriteLine("\nPrinting list member 'uniques' elements\n");

            foreach(var item in uniques)
            {
                Console.WriteLine(item);
            }
            
        }

        public static void JoinUniques()
        {
            string joined = "";

            foreach(var item in uniques)
            {
                joined += item + " ";
            }

            Console.Write($"\n\nUnique name list contains: {joined}");
        }
        
        static void Main(string[] args)
        {
            Console.Clear();
            
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };
            
            Console.WriteLine("\nPrinting list 'values' elements\n");            
            values.ForEach(Console.WriteLine);

            uniques = values.Distinct().ToList();            
            
            IterateUniques();
            
            JoinUniques();

            Console.WriteLine("\n");
        }
    }
}
