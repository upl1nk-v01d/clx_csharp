using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        private const string Path = "../WordCount/lear.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                Console.WriteLine(s);
            }
        }
    }
}