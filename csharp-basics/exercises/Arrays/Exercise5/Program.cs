using System;
using System.Text.RegularExpressions;

namespace Exercise5
{
    class Program
    {
        private static void Sleep(int delay = 1)
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

        static void DisplayText(string text = "\n", int tick = 30, int newLine = 1, int delay = 0)
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
            int[] myArray = { 25, 14, 56, 15, 36, 56, 77, 18, 29, 49 };
            
            Regex regexNotNumbers = new Regex("[^0-9]");

            bool quit = false; 
            bool error = false;

            int sw = 0;

            int num1 = 0;
            int num2 = 0;

            string prompt = "";

            Clear();
            DisplayText("-= Array Index Catch =-", tick: 0, delay: 1000);
            DisplayText("This program allow to detect specific index in array", delay: 1000);

            while(!quit)
            {
                if(!error)
                { 
                    Clear(); 
                }

                error = false;

                if(sw == 0)
                {
                    DisplayText("Please enter the first whole number: ", newLine: 0);
                    prompt = Console.ReadLine()!; //added '!' to forgive null reference
                } 
                
                else if(sw == 1)
                {
                    DisplayText("Please enter the second whole number: ", newLine: 0);
                    prompt = Console.ReadLine()!; //added '!' to forgive null reference
                }

                if(regexNotNumbers.Matches(prompt).Count > 0)
                {
                    error = true;

                    Console.Clear();
                    DisplayText("No no no no no!", delay: 1000);
                } 
                
                else if(prompt.Length <= 0)
                {
                    error = true;

                    Console.Clear();
                    DisplayText("no blankety blanks here!", delay: 1000);
                }
                
                else if(!error) 
                {
                    if(sw == 0){ 
                        num1 = int.Parse(prompt); 
                        sw++; 
                    }

                    else if(sw == 1)
                    { 
                        num2 = int.Parse(prompt);
                        sw++; 
                    }

                    else if(sw > 1)
                    { 
                        int idx1 = -1;
                        int idx2 = -1;

                        DisplayText($"Detecting numbers {num1} and {num2}....", delay: 1000);
                        DisplayText("Reading array....", delay: 500);
                        DisplayText();

                        for(int i = 0; i < myArray.GetLength(0); i++)
                        {
                            DisplayText($"{myArray[i]} ", newLine: 0);

                            if((i + 1) % 4 == 0)
                            { 
                                DisplayText(); 
                            }

                            if(myArray[i] == num1)
                            { 
                                idx1 = i; 
                            }

                            if(myArray[i] == num2)
                            { 
                                idx2 = i; 
                            }
                        }

                        DisplayText("\n", delay: 1000);

                        if(idx1 > -1)
                        {
                            DisplayText($"The number {num1} index is {idx1}!");
                        } 
                        
                        else 
                        {
                            DisplayText($"Oh no... no index for {num1}!");
                        }

                        if(idx2 > -1)
                        {
                            DisplayText($"The number {num2} index is {idx2}!");
                        } 
                        
                        else {
                            DisplayText($"Aaah... no index for {num2}!");
                        }

                        DisplayText();
                        DisplayText("Press any key to retry!");
                        DisplayText("Press 'q' key to abort!");

                        if(Console.ReadKey(true).Key.ToString() == "Q")
                        {
                            quit = true;
                        } 

                        else 
                        {
                            sw = 0;
                        }
                    }
                }
                
                if(quit)
                {
                    Clear();
                    DisplayText("Goodbye! :)", delay: 1000);

                    Clear();
                    Exit(1);
                }
                
            }
        }
    }
}
