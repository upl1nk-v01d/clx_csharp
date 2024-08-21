using System;
using System.Text.RegularExpressions;

namespace GetTheCentury
{
    internal class Program
    {
        static void Sleep(int delay = 1){
            System.Threading.Thread.Sleep(delay);
        }

        static void Clear()
        {
            Console.Clear();
        }

        static void Exit(int num)
        {
            System.Environment.Exit(num);
        }

        static void DisplayText(string text = "\n", int delay = 30, int newLine = 1)
        {
            for(int i1 = 0; i1 < text.Length; i1++)
            {
                Console.Write(text[i1]);
                Sleep(delay);
                
                if(newLine == 1 && i1 == text.Length - 1)
                {
                    Console.Write("\n");
                }
            }
        }

        static string GetTheCentury(int number)
        {
            string yearString = $"{number:0000}";
            int century = int.Parse(yearString.Substring(0, 2));
            
            if(number % 1000 >= 1)
            {
                century++;
            }     

            string result = $"{century}th";

            return result;
        }

        static void Main(string[] args)
        {
            Clear();
            Sleep(1000);

            DisplayText("-= GetTheCentury =-", newLine: 0);
            Sleep(1000);

            DisplayText("Determine century from year number.");
            Sleep(500);

            DisplayText("Year range is 1000-2010 AD.");
            Sleep(1000);

            Regex regexNotNumbers = new Regex("[^0-9]");

            bool quit = false; 
            bool error = false;

            string prompt;

            while(!quit)
            {
                if(!error)
                { 
                    Clear(); 
                }

                error = false;

                DisplayText("Please enter year number from 1000 to 2010: ", newLine: 0);
                
                prompt = Console.ReadLine()!; //added '!' to forgive null reference

                int year = int.Parse(prompt);
                
                if(regexNotNumbers.Matches(prompt).Count > 0)
                {
                    error = true;

                    Console.Clear();
                    DisplayText("Only numbers are allowed here.");
                } 
                
                else if(prompt.Length <= 0)
                {
                    error = true;
                    Console.Clear();
                    DisplayText("No input?");
                    Sleep(1000);

                    DisplayText("Type in 4 year numbers.");
                }

                else if(int.Parse(prompt) < 1000)
                {
                    DisplayText($"Your entered year {prompt} is below 1000.");
                    Sleep(1000);
                } 
                
                else if(int.Parse(prompt) > 2010)
                {
                    DisplayText($"Your entered year {prompt} is above 2010.");
                    Sleep(1000);
                } 
                
                else 
                {
                    Random randomNumber = new Random();

                    DisplayText("Getting century from year number...");
                    Sleep(1000);
                    DisplayText("We got ", newLine: 0);

                    string century = GetTheCentury(year);

                    foreach(char c in century)
                    {
                        DisplayText($"{c}", newLine: 0);
                        Sleep(randomNumber.Next(50, 200));
                    }

                    DisplayText(" century!");
                    Sleep(1000);

                    DisplayText();
                    DisplayText("Press any key to retry!");
                    DisplayText("Press 'q' key to Exit!");

                    if(Console.ReadKey(true).Key.ToString() == "Q")
                    {
                        quit = true;
                    }
                }
                
                if(quit)
                {
                    Clear();
                    DisplayText("Goodbye! :)");
                    Sleep(1000);

                    Clear();
                    Exit(1);
                }
            }
        }
    }
}
