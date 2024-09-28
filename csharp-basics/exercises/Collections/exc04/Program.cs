using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
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

        public static void RepeatedPrompt()
        {
            string prompt = "";

            Console.Write("\n\nEnter name: ");
            prompt = Console.ReadLine()!;

            while(prompt != "")
            {
                uniques.Add(prompt);

                Console.Write("Enter name: ");
                prompt = Console.ReadLine()!;
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
            
            IterateUniques();
            
            RepeatedPrompt();

            uniques = uniques.Distinct().ToList();

            JoinUniques();

            Console.WriteLine("\n");
        }
    }
}
