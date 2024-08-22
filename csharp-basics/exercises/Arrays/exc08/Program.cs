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

        public static List<char> theBoard = new List<char>(); 

        private static string[] words = 
        {
            "superman",
            "programmer",
            "codelex",
            "sandris",
            "hangman"
        };

        private static string chosenWord = "";

        private static void Main(string[] args)
        {
            Clear();
            DisplayText("-= Guess the worD =-", tick: 0, delay: 1000);
            DisplayText("Like goog old Hangman game", delay: 1000, newLines: 2);

            Regex regexNotNumbers = new Regex("[^0-9]");
            Random randomNumbers = new Random();

            bool quit = false;
            bool error;
            bool gameEnded = false;

            int sw = 0;

            string playerTurn = "Human";
            string winner = "";

            string prompt = "";
            int chosenNumber = -1;
            char chosenLetter = '_';

            InitGame();

            while(!quit)
            {
                error = false;

                if(!gameEnded)
                {
                    if(playerTurn == "Human")
                    {
                        DisplayText("");
                        DisplayText("Your turn!", delay: 1000);

                        while(sw < 2)
                        {            
                            error = false;

                            if(sw == 0)
                            {
                                Clear();
                                DisplayBoard();
                                DisplayText("");
                                DisplayText("Choose your cell: ", newLines: 0);
                            }

                            if(sw == 1)
                            {
                                Clear();
                                DisplayBoard();
                                DisplayText("");
                                DisplayText("Choose your letter: ", newLines: 0);
                            }
                            
                            
                            prompt = Console.ReadLine()!;

                            if(sw == 0)
                            {
                                if(regexNotNumbers.Matches(prompt).Count > 0)
                                {
                                    error = true;

                                    Clear();
                                    DisplayText("Enter only a number!", delay: 1000);
                                } 
                            } 
                            
                            else if(prompt.Length > 1)
                            {
                                error = true;

                                Clear();
                                DisplayText("Too many chars", delay: 1000);
                            } 
                            
                            else if(prompt.Length <= 0)
                            {
                                error = true;
                                Clear();
                                DisplayText("No chars", delay: 1000);
                            } 

                            if(!error)
                            {
                                sw++;

                                if(sw == 1)
                                {
                                    chosenNumber = int.Parse(prompt);
                                }

                                if(sw == 2)
                                {
                                    if(CheckBoardCell(char.Parse(prompt)) == '_')
                                    {                                        
                                        chosenLetter = char.Parse(prompt);

                                        break;
                                    }

                                    else
                                    {
                                        error = true;
                                        DisplayText("You chose wrong cell!", delay: 500);
                                        DisplayText("Try again!");
                                    }
                                }
                            }
                        }

                        Sleep(150);
                        Clear();
                    }

                    else if(playerTurn == "Computer")
                    {
                        DisplayBoard();

                        DisplayText("");
                        DisplayText("Computer's turn!", delay: 1000);

                        for(int i = 0; i < 9; i++)
                        {
                            chosenNumber = randomNumbers.Next(1, chosenWord.Count());

                            if(CheckBoardCell(chosenNumber) == '_')
                            {
                                break;
                            }
                        }

                        DisplayText($"Computer chose cell: {chosenNumber}", newLines: 0, delay: 1000);

                        string letters = "abcdefghijklmnopqrstuvwxyz";
                        Random randomLetter = new Random();
                        int num = randomLetter.Next(0, letters.Length);

                        chosenLetter = letters[num];
                        
                        DisplayText("");
                        DisplayText($"Computer chose letter: {chosenLetter}", newLines: 0, delay: 1000);

                        Sleep(1000);
                        Clear();
                    }
                }
                
                if(!error)
                {                    
                    if(playerTurn == "Human")
                    {
                        ReplaceBoardCell(chosenNumber, chosenLetter);
                        playerTurn = "Computer";
                        sw = 0;
                    }

                    else if(playerTurn == "Computer")
                    {
                        ReplaceBoardCell(chosenNumber, chosenLetter);
                        playerTurn = "Human";
                    }
                    
                    DisplayBoard();

                    winner = CheckWinner();

                    if(winner == "X" || winner == "0")
                    {
                        gameEnded = true;
                        DisplayText("", delay: 1000);
                        DisplayText($"We have a winner '{winner}'!");
                    }

                    else if(CheckBoardUnusedCells() < 1)
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
                        InitGame();
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

        private static void InitGame()
        {

            Random randomNumber = new Random();
            chosenWord = words[randomNumber.Next(0, words.Count())];

            foreach(char value in chosenWord)
            {
                theBoard.Add(value);
            }

            int cell = 0;

            for (int column = 0; column < theBoard.Count; column++)
            {
                cell++;
                theBoard[column]='_';
            }
        }
        
        private static int CheckBoardUnusedCells()
        {
            int cellsCount = 0;

            for (int column = 0; column < theBoard.Count; column++)
            {
                if (theBoard[column] == '_')
                { 
                    cellsCount++; 
                }
            }

            return cellsCount;
        }

        private static string CheckWinner()
        {

            return "";
        }

        private static char CheckBoardCell(int num)
        {
            int cellsCount = 0;

            for (int column = 0; column < theBoard.Capacity; column++)
            {
                if((num - 1) == cellsCount)
                { 
                    return theBoard[column];
                }

                cellsCount++;
            }
            return '_';
        }

        private static void ReplaceBoardCell(int num, char symbol)
        {
            int cellsCount = 0;

            for (int column = 0; column < theBoard.Capacity; column++)
            {
                if((num - 1) == cellsCount)
                { 
                    theBoard[column] = symbol; 
                }

                cellsCount++;
            }
        }

        private static void DisplayBoard()
        {
            string board = "";

            for (int i = 0; i < theBoard.Count; i++)
            {
                board += "+---";
                if(i == theBoard.Count - 1)
                {
                    board += "+\n";
                }
            }

            for (int column = 0; column < theBoard.Count; column++)
            {
                board += "| " + theBoard[column] + " ";
                if(column == theBoard.Count - 1)
                {
                    board += "|\n";
                }
            }

            for (int i = 0; i < theBoard.Count; i++)
            {
                board += $"+-{i + 1}-";
                if(i == theBoard.Count - 1)
                {
                    board += "+\n";
                }
            }
            
            DisplayText(board, tick: 1, newLines: 0);
        }
    }
}
