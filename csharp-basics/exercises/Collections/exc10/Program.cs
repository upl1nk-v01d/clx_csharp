using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10
{
    class Program
    {
        static void DisplayHashSetItems(HashSet<string> hashSet)
        {
            Console.WriteLine();

            foreach(var item in hashSet)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine("\n");
        }

        private static void Main(string[] args)
        {
            Console.Clear();

            HashSet<string> hashSet = new HashSet<string>();

            hashSet.Add("one");                
            hashSet.Add("two");                
            hashSet.Add("three");                
            hashSet.Add("four");                
            hashSet.Add("five");       

            DisplayHashSetItems(hashSet);

            hashSet.Clear();

            hashSet.Add("duplicate");       
            hashSet.Add("duplicate");       
            hashSet.Add("duplicate");       

            DisplayHashSetItems(hashSet);         
        }
    }
}