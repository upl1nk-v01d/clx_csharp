using System;
using System.Collections.Generic;

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

        private static List<string> decryptedNumbers = new List<string>();

        static void decrypt(List<string> list)
        {
            foreach(var item in list)
            {
                string decrypted = "";

                foreach(char c in item)
                {
                    for(int i = 0; i < _array.GetLength(0); i++)
                    {
                        if(_array[i,0] == c.ToString())
                        {
                            decrypted += _array[i,1];
                        }
                    }
                }

                decryptedNumbers.Add(decrypted);
            }
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

            foreach(var item in cryptedNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\ndecrypted numbers:\n");
            
            decrypt(cryptedNumbers);

            foreach(var item in decryptedNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
