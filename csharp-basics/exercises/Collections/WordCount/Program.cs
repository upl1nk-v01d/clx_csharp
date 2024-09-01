using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static int ReadLines(string filePath)
        {
            return File.ReadAllLines(filePath).Length;
        }

        static int ReadWords(string filePath)
        {
            var words = 0;
            var lines = File.ReadAllLines(filePath);

            Regex regex = new Regex("[,.!?]");

            foreach(var line in lines)
            {
                string strippedLine = regex.Replace(line, "");

                words += strippedLine.Split(" ").Length;
            }

            return words;
        }

        static int ReadChars(string filePath)
        {
            var chars = 0;
            var lines = File.ReadAllLines(filePath);

            Regex regex = new Regex("\n");

            foreach(var line in lines)
            {
                string strippedLine = regex.Replace(line, "");
                Console.WriteLine(strippedLine);
                chars += strippedLine.ToCharArray().Length;
            }

            return chars;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReadLines("lear.txt"));
            Console.WriteLine(ReadWords("lear.txt"));
            Console.WriteLine(ReadChars("lear.txt"));
        }
    }
}
