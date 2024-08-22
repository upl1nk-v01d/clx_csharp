using System;
using System.Text.RegularExpressions;

namespace TicTacToe
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

        static void DisplayText(string text = "\n", int tick = 30, int newLines = 1, int delay = 0)
        {
             if(text.Length < 1)
             {
                Console.Write("\n");
             } 
             
             else 
             {
                for(int i1 = 0; i1 < text.Length; i1++)
                {
                    Console.Write(text[i1]);
                    Sleep(tick);

                    if(newLines > 0 && i1 == text.Length - 1)
                    {
                        for(int i2 = 0; i2 < newLines; i2++)
                        {
                            Console.Write("\n");
                        }
                    }
                }
            }

            Sleep(delay);
        }

        private static string[] words1 = 
        {
            "mavis", 
            "senaida", 
            "letty"
        };

        private static string[] words2 = 
        {
            "samuel", 
            "MABELLE", 
            "letitia", 
            "meridith"
        };

        private static string[] words3 = 
        {
            "Slyvia", 
            "Kristal", 
            "Sharilyn", 
            "Calista"
        };

        private static string[] CapMe(string[] array){
            for(int i1 = 0; i1 < array.GetLength(0); i1++)
            {
                array[i1] = array[i1].ToLower();

                string word = array[i1];
                string character = word[0].ToString().ToUpper();

                array[i1] = character + word.Substring(1);
            }
            
            return array;
        }

        private static void Main(string[] args)
        {
            Clear();
            DisplayText("-= Capitalize Array's firsts =-", tick: 0, delay: 1000);
            DisplayText("This program capitalize first letters of array elements", delay: 1000, newLines: 2);

            Regex regexNotNumbers = new Regex("[^0-9]");

            bool quit = false;

            int sw = 0;

            while(!quit)
            {                              
                if(sw == 0)
                {
                    DisplayText("Displaying original variable 'words1' content...", newLines: 2);
                    
                    foreach(string item in words1)
                    {
                        DisplayText(item);
                    }

                    DisplayText("", newLines: 2, delay: 1000);
                    DisplayText("Displaying capitalized variable 'cappedWords1' content...", newLines: 2);
                    
                    string[] cappedWords1 =  CapMe(words1);
                    
                    foreach(string item in cappedWords1)
                    {
                        DisplayText(item);
                    }

                    DisplayText("", newLines: 2, delay: 1000);
                    DisplayText("Press any key to continue!");
                    Console.ReadKey(true);
                    Clear();
                }

                if(sw == 0)
                {
                    DisplayText("Displaying original variable 'words2' content...", newLines: 2);
                    
                    foreach(string item in words2)
                    {
                        DisplayText(item);
                    }

                    DisplayText("", newLines: 2, delay: 1000);
                    DisplayText("Displaying capitalized variable 'cappedWords2' content...", newLines: 2);
                    
                    string[] cappedWords2 =  CapMe(words2);
                    
                    foreach(string item in cappedWords2)
                    {
                        DisplayText(item);
                    }

                    DisplayText("", newLines: 2, delay: 1000);
                    DisplayText("Press any key to continue!");
                    Console.ReadKey(true);
                    Clear();
                }

                if(sw == 0)
                {
                    DisplayText("Displaying original variable 'words3' content...", newLines: 2);
                    
                    foreach(string item in words3)
                    {
                        DisplayText(item);
                    }

                    DisplayText("", newLines: 2, delay: 1000);
                    DisplayText("Displaying capitalized variable 'cappedWords3' content...", newLines: 2);
                    
                    string[] cappedWords3 =  CapMe(words3);
                    
                    foreach(string item in cappedWords3)
                    {
                        DisplayText(item);
                    }

                    DisplayText("", newLines: 2, delay: 1000);
                    Clear();
                }

                sw++;

                if(sw > 2)
                {
                    DisplayText("Press 'q' key to quit!");
                    DisplayText("Press any key to restart!");
                
                    if(Console.ReadKey(true).Key.ToString() == "Q")
                    {
                        quit = true;
                    } 

                    else
                    {
                        Clear();
                        sw = 0;
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
