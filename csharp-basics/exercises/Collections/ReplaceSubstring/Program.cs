using System;
using System.Text.RegularExpressions;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };
            
            Regex regex = new Regex("ea");
            
            int i = 0;

            foreach(var word in words)
            {
                words[i] = regex.Replace(word, "*");
                i++;
            }

            Console.Clear();

            foreach(var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
