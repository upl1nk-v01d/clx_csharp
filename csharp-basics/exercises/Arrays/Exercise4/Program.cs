using System;
using System.Text.RegularExpressions;

namespace Exercise4
{
    class Program
    {

        static void Sleep(int delay = 1)
        {
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

        static void DisplayText(string text = "\n",  int tick = 30, int newLine = 1, int delay = 0)
        {
            for(int i1 = 0; i1 < text.Length; i1++)
            {
                Console.Write(text[i1]);
                Sleep(tick);
                
                if(newLine == 1 && i1 == text.Length - 1)
                {
                    Console.Write("\n");
                }
            }
            
            Sleep(delay);
        }
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            
            Regex regexNotNumbers = new Regex("[^0-9]");
            
            bool quit = false;
            bool error = false;

            string prompt;

            Clear();
            DisplayText("-= Array Number Catch =-", tick: 0, delay: 1000);
            DisplayText("This program allow to detect specific number in array", delay: 1000);

            while(!quit)
            {

                if(!error)
                { 
                    Clear(); 
                }

                error = false;

                DisplayText("Please enter a whole number: ", newLine: 0);

                prompt = Console.ReadLine()!; //added '!' to forgive null reference

                if(regexNotNumbers.Matches(prompt).Count > 0)
                {
                    error = true;
                    Console.Clear();
                    DisplayText("what?", delay: 1000);
                } 
                
                else if(prompt.Length <= 0)
                {
                    error = true;
                    Console.Clear();
                    DisplayText("eh?", delay: 1000);
                } 
                
                else 
                {
                    int detectedNumber = int.Parse(prompt);
                    bool detected = false;

                    DisplayText("Detecting....", delay: 1000);
                    DisplayText("Reading array....", delay: 500);
                    DisplayText();

                    for(int i = 0; i < myArray.GetLength(0); i++)
                    {
                        DisplayText($"{myArray[i]} ", newLine: 0);
                        
                        if((i + 1) % 5 == 0)
                        { 
                            DisplayText(); 
                        }

                        if(myArray[i] == detectedNumber)
                        {
                            detected = true;
                        }
                    }

                    DisplayText("\n", delay: 1000);

                    if(detected)
                    {
                        DisplayText($"The number {detectedNumber} is detected!");
                    } 
                    
                    else 
                    {
                        DisplayText($"Hmm... the number {detectedNumber} is not detected!");
                    }
                    
                    DisplayText();
                    DisplayText("Press any key to retry!");
                    DisplayText("Press 'q' key to abort!");
                    
                    if(Console.ReadKey(true).Key.ToString() == "Q")
                    {
                        quit = true;
                    }
                }
                
                if(quit)
                {
                    Clear();
                    DisplayText("Goodbye! :)",delay:1000);

                    Clear();
                    Exit(1);
                }
            }
        }
    }
}
