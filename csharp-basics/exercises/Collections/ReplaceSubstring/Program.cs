using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };            

            var wordsList = words.Select(word => word = Regex.Replace(word, "ea", "*"));

            Console.Clear();

            foreach(var word in wordsList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
