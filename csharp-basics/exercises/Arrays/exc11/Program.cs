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

        private static void FindNemo(string str)
        {
            DisplayText($"{str}", newLines: 2, delay: 1000);
                                
            bool parsed = true;

            if(str.IndexOf("Nemo") < 0)
            {
                parsed = false;
            }

            else
            {
                if(str.IndexOf("Nemo") == 0)
                {
                    if(str[str.IndexOf("Nemo")+4].ToString() != " ")
                    {
                        parsed = false;
                    }
                }

                else if(str.IndexOf("Nemo") + 4 == str.Length)
                {
                    if(str[str.IndexOf("Nemo")-1].ToString() != " ")
                    {
                        parsed = false;
                    }
                }

                else if(str.IndexOf("Nemo") + 6 < str.Length)
                {
                    if(str[str.IndexOf("Nemo")-1].ToString() != " " || str[str.IndexOf("Nemo")+4].ToString() != " ")
                    {
                        parsed = false;
                    }
                }

                if(parsed) 
                {
                    string[] array = str.Split(' ');
                    int idx = Array.FindIndex(array, i => i.Contains("Nemo"));
                    DisplayText($"I found Nemo at {idx + 1}", delay: 1000);
                }
            }

            if(!parsed)
            {
                parsed = false;
                DisplayText("I can't find Nemo :(", delay: 1000);
            }

            DisplayText("\n", delay: 1000);
            DisplayText("Press any key to continue!");
            Console.ReadKey(true);
            Clear();
        }

        private static void Main(string[] args)
        {
            Clear();
            DisplayText("-= Finding Nemo purely =-", tick: 0, delay: 1000, newLines: 2);
            DisplayText("This program finds word 'Nemo' alone or incapsulated in whitespaces");
            DisplayText("", delay: 1000);
            DisplayText("Press any key to continue!");
            
            Console.ReadKey(true);
            Clear();

            bool quit = false;

            while(!quit)
            {                              
                FindNemo("I am finding Nemo !"); 
                FindNemo("where is NeMo ?"); 
                FindNemo("Nemo is me");                 
                FindNemo("NemoNemo is me"); 
                FindNemo("and _Nemo_ is me"); 
                FindNemo("and also +Nemo is me"); 
                FindNemo("I Nemo am");

                DisplayText("That's it for now! :-)", newLines: 2, delay: 500);
                DisplayText("Press 'q' key to quit!");
                DisplayText("Press any key to restart!");
            
                if(Console.ReadKey(true).Key.ToString() == "Q")
                {
                    quit = true;
                } 

                else
                {
                    Clear();
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
