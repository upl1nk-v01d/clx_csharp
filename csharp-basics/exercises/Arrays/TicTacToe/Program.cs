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

        //private static char[,] _board = new char[3, 3]; //what's this?
        public static string[,] theBoard = new string [3,3];

        private static void Main(string[] args)
        {
            Clear();
            //DisplayText("-= TicTacToe =-",tick:0,delay:1000);
            //DisplayText("The classic",delay:1000);

            Regex regexNotNumbers = new Regex("[^0-9]");
            Random randomNumbers = new Random();

            bool quit = false;
            bool error;

            string prompt = "";

            InitBoard();
            DisplayBoard();

            while(!quit)
            {
                error = false;

                if(CheckBoardTurns() < 1)
                {
                    DisplayText("Game ended!");
                } 
                
                else 
                {
                    DisplayText("Your turn!");
                    DisplayText("Choose your cell: ", newLines: 0);

                    prompt = Console.ReadLine();

                    Sleep(150);
                    Clear();
                }

                if(regexNotNumbers.Matches(prompt).Count > 0)
                {
                    error = true;

                    Console.Clear();
                    DisplayText("what?", delay: 1000);
                } 
                
                else if(prompt.Length > 1)
                {
                    error = true;

                    Console.Clear();
                    DisplayText("Too many?", delay: 1000);
                 } 
                 
                else if(prompt.Length <= 0)
                {
                    error = true;
                    Console.Clear();
                    DisplayText("eh?", delay: 1000);
                } 
                
                else if(!error)
                {
                    ReplaceBoardCell(int.Parse(prompt), "X");
                    DisplayBoard();

                    DisplayText("", delay: 1000);
                    DisplayText("Press any key to retry!");
                    DisplayText("Press 'q' key to abort!");
                    
                    if(Console.ReadKey(true).Key.ToString() == "Q")
                    {
                        quit = true;
                    } 
                    
                    else 
                    {
                        Clear();
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
        private static int CheckBoardTurns()
        {
            int cellsCount = 0;

            for (int row = 0; row < theBoard.GetLength(0); row++)
            {
                for (int column = 0; column < theBoard.GetLength(1); column++)
                {
                    if (theBoard[row, column] != " ")
                    { 
                        cellsCount++; 
                    }
                }
            }

            return cellsCount;
        }

        private static void ReplaceBoardCell(int num, string symbol)
        {
            int cellsCount = 0;

            for (int row = 0; row < theBoard.GetLength(0); row++)
            {
                for (int column = 0; column < theBoard.GetLength(1); column++)
                {
                    if((num - 1) == cellsCount)
                    { 
                        theBoard[row, column] = symbol; 
                    }

                    cellsCount++;
                }
            }
        }

        private static void InitBoard()
        {
            int cell = 0;

            for (int row = 0; row < theBoard.GetLength(0); row++)
            {
                for (int column = 0; column < theBoard.GetLength(1); column++)
                {
                    cell++;
                    theBoard[row, column]=cell.ToString();
                }
            }
        }

        private static void DisplayBoard()
        {
            string board = "";

            for (int row = 0; row < theBoard.GetLength(0); row++)
            {
                for (int i = 0; i < theBoard.GetLength(0); i++)
                {
                    board += "+---";
                    if(i == theBoard.GetLength(0) - 1)
                    {
                        board += "+\n";
                    }
                }
            
                for (int column = 0; column < theBoard.GetLength(0); column++)
                {
                    board += "| " + theBoard[row, column] + " ";
                    if(column == theBoard.GetLength(0) - 1)
                    {
                        board += "|\n";
                    }
                }
                if(row == theBoard.GetLength(0) - 1)
                {
                    for (int i = 0; i < theBoard.GetLength(0); i++)
                    {
                        board += "+---";
                        if(i == theBoard.GetLength(0) - 1)
                        {
                            board += "+\n";
                        }
                    }
                }
            }

            DisplayText(board, tick: 1, newLines: 0);
        }
    }
}
