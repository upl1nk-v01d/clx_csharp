using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.Clear();

            Console.WriteLine("The first 10 natural numbers are: ");

            i = 1;
            
            Console.WriteLine();

            while(i < 11)
            {
                Console.Write(i + " ");
                i++;
            }
            
            Console.ReadKey(true);
            Console.WriteLine();

        }
    }
}
