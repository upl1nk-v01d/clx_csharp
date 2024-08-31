using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        public static List<string> listColors = new List<string>();

        private static void Main(string[] args)
        {            
            listColors.Add("Red"); 
            listColors.Add("Green"); 
            listColors.Add("Blue"); 
            listColors.Add("White"); 
            listColors.Add("Tan"); 

            Console.Clear();
            Console.WriteLine("\nPrinting List items...\n");

            foreach(var item in listColors)
            {
                Console.WriteLine(item);
            }
        }
    }
}
