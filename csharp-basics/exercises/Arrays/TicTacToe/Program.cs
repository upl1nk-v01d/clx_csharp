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

        public static string[,] theBoard = new string [3,3];

        private static void Main(string[] args)
        {
            Clear();
            DisplayText("-= TicTacToe =-", tick: 0, delay: 1000);
            DisplayText("The refurbished classic game", delay: 1000, newLines: 2);

            Regex regexNotNumbers = new Regex("[^0-9]");
            Random randomNumbers = new Random();

            bool quit = false;
            bool error;
            bool gameEnded = false;

            string playerTurn = "X";
            string winner = "";

            string prompt = "";
            int chosenNumber = -1;

            InitBoard();

            while(!quit)
            {
                error = false;

                if(!gameEnded)
                {
                    if(playerTurn == "X")
                    {
                        FillBoardCells(true);
                        DisplayBoard();

                        DisplayText("");
                        DisplayText("Your turn!");

                        for(int i = 0; i < 9; i++)
                        {            
                            error = false;

                            DisplayText("Choose your cell: ", newLines: 0);
                            prompt = Console.ReadLine();

                            if(regexNotNumbers.Matches(prompt).Count > 0)
                            {
                                error = true;

                                Clear();
                                DisplayText("what?", delay: 1000);
                            } 
                            
                            else if(prompt.Length > 1)
                            {
                                error = true;

                                Clear();
                                DisplayText("Too many?", delay: 1000);
                            } 
                            
                            else if(prompt.Length <= 0)
                            {
                                error = true;
                                Clear();
                                DisplayText("eh?", delay: 1000);
                            } 

                            else if(CheckBoardCell(int.Parse(prompt)) != "X" && CheckBoardCell(int.Parse(prompt)) != "0")
                            {
                                FillBoardCells(false);
                                break;
                            }
                            
                            else
                            {
                                DisplayText("You chose wrong cell!", delay: 500);
                                DisplayText("Try again!");
                            }

                            if(error)
                            {
                                i--;
                            }
                        }

                        Sleep(150);
                        Clear();
                    }

                    else if(playerTurn == "0")
                    {

                        FillBoardCells(false);
                        DisplayBoard();

                        DisplayText("");
                        DisplayText("Computer's turn!", delay: 1000);

                        for(int i = 0; i < 9; i++)
                        {
                            chosenNumber = randomNumbers.Next(1, 10);

                            if(CheckBoardCell(chosenNumber) != "X" && CheckBoardCell(chosenNumber) != "0")
                            {
                                break;
                            }
                        }

                        DisplayText($"Computer chose cell: {chosenNumber}", newLines: 0);

                        Sleep(1000);
                        Clear();
                    }
                }
                
                if(!error)
                {
                    if(playerTurn == "X")
                    {
                        ReplaceBoardCell(int.Parse(prompt), "X");
                        playerTurn = "0";
                    }

                    else if(playerTurn == "0")
                    {
                        ReplaceBoardCell(chosenNumber, "0");
                        playerTurn = "X";
                    }
                    
                    DisplayBoard();

                    winner = CheckWinner();

                    if(winner == "X" || winner == "0")
                    {
                        gameEnded = true;
                        DisplayText("", delay: 1000);
                        DisplayText($"We have a winner '{winner}'!");
                    }

                    else if(CheckBoardTurns() < 1)
                    {
                        gameEnded = true;
                        DisplayText("", delay: 1000);
                        DisplayText("Game ended!");
                    } 
                
                    DisplayText("", delay: 1000);
                    DisplayText("Press any key to continue!");
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

                if(gameEnded)
                {
                    DisplayText("", delay: 1000);
                    DisplayText("Press any key to restart game!");
                    DisplayText("Press 'q' key to abort!");
                    
                    if(Console.ReadKey(true).Key.ToString() == "Q")
                    {
                        quit = true;
                    } 

                    else
                    {
                        gameEnded = false;
                        InitBoard();
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

        private static string CheckWinner()
        {
            if(theBoard[0,0] == theBoard[0,1] && theBoard[0,0] == theBoard[0,2])
            {
                return theBoard[0,0];
            }

            else if(theBoard[1,0] == theBoard[1,1] && theBoard[1,0] == theBoard[1,2])
            {
                return theBoard[1,0];
            }

            else if(theBoard[2,0] == theBoard[2,1] && theBoard[2,0] == theBoard[2,2])
            {
                return theBoard[2,0];
            }

            else if(theBoard[0,0] == theBoard[1,0] && theBoard[0,0] == theBoard[2,0])
            {
                return theBoard[0,0];
            }

            else if(theBoard[0,1] == theBoard[1,1] && theBoard[0,1] == theBoard[2,1])
            {
                return theBoard[0,1];
            }

            else if(theBoard[0,2] == theBoard[1,2] && theBoard[0,2] == theBoard[2,2])
            {
                return theBoard[0,2];
            }

            else if(theBoard[0,0] == theBoard[1,1] && theBoard[0,0] == theBoard[2,2])
            {
                return theBoard[0,0];
            }
            
            else if(theBoard[0,2] == theBoard[1,1] && theBoard[0,2] == theBoard[2,0])
            {
                return theBoard[2,0];
            }

            return "";
        }

        private static string CheckBoardCell(int num)
        {
            int cellsCount = 0;

            for (int row = 0; row < theBoard.GetLength(0); row++)
            {
                for (int column = 0; column < theBoard.GetLength(1); column++)
                {
                    if((num - 1) == cellsCount)
                    { 
                        return theBoard[row, column];
                    }

                    cellsCount++;
                }
            }
            return "";
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
                    theBoard[row, column]=" ";
                }
            }
        }

        private static void FillBoardCells(bool drawCellNumbers)
        {
            int cell = 0;

            for (int row = 0; row < theBoard.GetLength(0); row++)
            {
                for (int column = 0; column < theBoard.GetLength(1); column++)
                {
                    cell++;

                    if(theBoard[row, column] != "X" && theBoard[row, column] != "0")
                    {
                        if(drawCellNumbers)
                        {
                            theBoard[row, column]=cell.ToString();
                        }
                        
                        else
                        {
                            theBoard[row, column]=" ";
                        }
                    }
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
