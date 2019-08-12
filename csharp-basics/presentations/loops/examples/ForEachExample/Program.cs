using System;

namespace ForEachExample
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = {"Ron", "Harry", "Hermione"};

            foreach (var x in array) {
                Console.WriteLine(x);
            }
        }
    }
}