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

        private static int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
        
        private static int[] numbers2 = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
        
        private static int[] numbers3 = { 91, -4, 80, -73, -28 };
        
        private static int[] numbers4 = {  };

        private static int[] CountPosSumNeg(int[] array)
        {
            int[] arraySummary = new int[2];
            int countPositiveNumbers = 0;
            int sumOfNegativeNumbers = 0;

            for(int i = 0; i < array.GetLength(0); i++)
            {
                if(array[i] >= 0)
                {
                    countPositiveNumbers++;
                } 
                
                else 
                {
                    sumOfNegativeNumbers += array[i];
                }
                
            }

            arraySummary[0] = countPositiveNumbers;
            arraySummary[1] = sumOfNegativeNumbers;
            
            return arraySummary;
        }

        private static void CheckArrayContent(string varName, int[] array)
        {
            DisplayText($"Displaying variable '{varName}' content...", newLines: 2);
                    
            int i = 0;

            foreach(int item in array)
            {
                DisplayText(item + "\t", newLines: 0);

                i++;

                if(i % 4 == 0)
                {
                    DisplayText("");
                }
            }

            int[] arraySummary =  CountPosSumNeg(array);

            DisplayText("\n", delay: 1000);
            DisplayText($"count of variable '{varName}' positive numbers is {arraySummary[0]}");
            DisplayText($"sum of variable '{varName}' negative numbers is {arraySummary[1]}", newLines: 2);

            DisplayText("\n", delay: 1000);
            DisplayText("Press any key to continue!");
            Console.ReadKey(true);
            Clear();
        }

        private static void Main(string[] args)
        {
            Clear();
            DisplayText("-= Capitalize Array's firsts =-", tick: 0, delay: 1000, newLines: 2);
            DisplayText("This program counts arrays positive numbers");
            DisplayText("and sums arrays negative numbers", delay: 1000, newLines: 2);
            DisplayText("", delay: 1000);
            DisplayText("Press any key to continue!");
            
            Console.ReadKey(true);
            Clear();

            bool quit = false;

            while(!quit)
            {                              
                CheckArrayContent("numbers1", numbers1); 
                CheckArrayContent("numbers2", numbers2); 
                CheckArrayContent("numbers3", numbers3); 
                CheckArrayContent("numbers4", numbers4); 

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
