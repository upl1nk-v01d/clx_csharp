using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.Clear();
            Console.WriteLine("Showing all vowels with 'for' loop:");

            for(int i = 0; i < vowels.GetLength(0); i++)
            {
                Console.Write(vowels[i] + "\t");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Showing all vowels with 'foreach' loop:");
            
            foreach(char e in vowels)
            {
                Console.Write(e + "\t");
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Press any key to end program!");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
