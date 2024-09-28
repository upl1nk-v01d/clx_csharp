using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        private static string [,] _array = { 
            {"!", "1"},
            {"@", "2"},
            {"#", "3"},
            {"$", "4"},
            {"%", "5"},
            {"&", "6"},
            {"*", "7"},
            {"(", "8"},
            {")", "9"}
        };

        private static List<string> DecryptedNumbers = new List<string>();

        static void Decrypt(List<string> list)
        {
            DecryptedNumbers = list.Select(c => c = c
                .Replace(_array[0,0], _array[0,1])
                .Replace(_array[1,0], _array[1,1])
                .Replace(_array[2,0], _array[2,1])
                .Replace(_array[3,0], _array[3,1])
                .Replace(_array[4,0], _array[4,1])
                .Replace(_array[5,0], _array[5,1])
                .Replace(_array[6,0], _array[6,1])
                .Replace(_array[7,0], _array[7,1])
                .Replace(_array[8,0], _array[8,1])
            ).ToList();
        }

        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            Console.Clear();

            Console.WriteLine("crypted numbers:\n");

            cryptedNumbers.ForEach(Console.WriteLine);

            Console.WriteLine("\n\ndecrypted numbers:\n");
            
            Decrypt(cryptedNumbers);

            DecryptedNumbers.ForEach(Console.WriteLine);
        }
    }
}
