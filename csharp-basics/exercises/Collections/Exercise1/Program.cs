using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        public static Dictionary<string, string> ConvertToDictionary(string[] array)
        {
            List<KeyValuePair<string, string>> keyValues = new List<KeyValuePair<string, string>>();
            
            keyValues.Add(new KeyValuePair<string, string>("Audi", "Germany"));
            keyValues.Add(new KeyValuePair<string, string>("BMW", "Germany"));
            keyValues.Add(new KeyValuePair<string, string>("Honda", "Japan"));
            keyValues.Add(new KeyValuePair<string, string>("Mercedes", "Germany"));
            keyValues.Add(new KeyValuePair<string, string>("VolksWagen", "Germany"));
            keyValues.Add(new KeyValuePair<string, string>("Tesla", "USA"));

            var dictionary = keyValues.ToDictionary();

            return dictionary;
        }

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            Console.Clear();

            var list = array.ToList();

            Console.WriteLine("\n\nPrinting items from List...\n");

            list.ForEach(Console.WriteLine);

            var hashSet = list.ToHashSet();
            
            Console.WriteLine("\n\nPrinting items from Hashset...\n");

            foreach(var item in hashSet)
            {
                Console.WriteLine(item);
            }

            var dictionary = ConvertToDictionary(array);
            
            Console.WriteLine("\n\nPrinting items from Dictionary...\n");

            foreach(var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}