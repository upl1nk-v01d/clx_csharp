using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };
            
            Console.WriteLine("\nPrinting list 'values' elements\n");            
           
            values.ForEach(Console.WriteLine);

            var uniques = values.ToHashSet().ToList();
            
            Console.WriteLine("\nPrinting list member 'uniques' elements\n");

            uniques.ForEach(Console.WriteLine);

            Console.WriteLine("\n");
        }
    }
}
