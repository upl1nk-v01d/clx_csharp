using System;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    class Program
    {
        static void sleep(int delay=1){
            System.Threading.Thread.Sleep(delay);
        }
        static void clc(){
            Console.Clear();
        }
        static void exit(int p){
            System.Environment.Exit(p);
        }

        static void displayText(string text="\n", int tick=30, int newLines=1, int delay=0){
             if(text.Length<1){
                Console.Write("\n");
             } else {
                for(int i1=0;i1<text.Length;i1++){
                    Console.Write(text[i1]);
                    sleep(tick);
                    if(newLines>0 && i1 == text.Length-1){
                        for(int i=0;i<newLines;i++){
                            Console.Write("\n");
                        }
                    }
                }
            }
            sleep(delay);
        }
        //private static char[,] _board = new char[3, 3]; //what's this?
        public static string[,] theBoard = new string [3,3];

        private static void Main(string[] args){
            clc();
            //displayText("-= TicTacToe =-",tick:0,delay:1000);
            //displayText("The classic",delay:1000);

            Regex rx = new Regex("[^0-9]");
            Random rnd = new Random();
            bool quit=false, err;
            string prompt = "";

            InitBoard();
            DisplayBoard();

            while(!quit){

                err=false;

                if(CheckBoardTurns()<1){
                    displayText("Game ended!");
                } else {
                    displayText("Your turn!");
                    displayText("Choose your cell: ",newLines:0);
                    prompt = Console.ReadLine();
                    sleep(150);
                    clc();
                }

                if(rx.Matches(prompt).Count > 0){
                    err = true;
                    Console.Clear();
                    displayText("what?",delay:1000);
                } else if(prompt.Length>1){
                    err = true;
                    Console.Clear();
                    displayText("Too many?",delay:1000);
                 } else if(prompt.Length<=0){
                    err = true;
                    Console.Clear();
                    displayText("eh?",delay:1000);
                } else if(!err){
                    ReplaceBoardCell(int.Parse(prompt),"X");
                    DisplayBoard();
                    displayText("",delay:1000);
                    displayText("Press any key to retry!");
                    displayText("Press 'q' key to abort!");
                    
                    if(Console.ReadKey(true).Key.ToString() == "Q"){
                        quit = true;
                    } else {
                        clc();
                    }
                }
                
                if(quit){
                    clc();
                    quit=true;
                    displayText("Goodbye! :)",delay:1000);
                    clc();
                    exit(1);
                }
            }
        }
        private static int CheckBoardTurns(){
            int cells = 0;
            for (int r = 0; r < theBoard.GetLength(0); r++){
                for (int c = 0; c < theBoard.GetLength(1); c++){
                    if (theBoard[r,c]!=" "){ cells++; }
                }
            }
            return cells;
        }

        private static void ReplaceBoardCell(int n, string symbol){
            int cells = 0;
            for (int r = 0; r < theBoard.GetLength(0); r++){
                for (int c = 0; c < theBoard.GetLength(1); c++){
                    if((n-1) == cells){ theBoard[r,c] = symbol; }
                    cells++;
                }
            }
        }
        private static void InitBoard(){
            int cell=0;
            for (int r = 0; r < theBoard.GetLength(0); r++){
                for (int c = 0; c < theBoard.GetLength(1); c++){
                    cell++;
                    theBoard[r,c]=cell.ToString();
                }
            }
        }

        private static void DisplayBoard(){
            string board = "";
            for (int r = 0; r < theBoard.GetLength(0); r++){
                for (int i=0;i<theBoard.GetLength(0); i++){
                    board += "+---";
                    if(i==theBoard.GetLength(0)-1){
                        board += "+\n";
                    }
                }
            
                for (int c=0;c<theBoard.GetLength(0); c++){
                    board += "| " + theBoard[r,c] + " ";
                    if(c==theBoard.GetLength(0)-1){
                        board += "|\n";
                    }
                }
                if(r==theBoard.GetLength(0)-1){
                    for (int i=0;i<theBoard.GetLength(0); i++){
                        board += "+---";
                        if(i==theBoard.GetLength(0)-1){
                            board += "+\n";
                        }
                    }
                }
            }
            displayText(board,tick:1,newLines:0);
        }
    }
}
