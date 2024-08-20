using System;
using System.Text.RegularExpressions;

namespace Exercise4
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

        static void displayText(string text="\n", int tick=30, int endLine=1, int delay=0){
            for(int i1=0;i1<text.Length;i1++){
                Console.Write(text[i1]);
                sleep(tick);
                if(endLine==1 && i1 == text.Length-1){
                    Console.Write("\n");
                }
            }
            sleep(delay);
        }
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            
            Regex rx = new Regex("[^0-9]");
            bool quit=false, err=false;
            string prompt;

            clc();
            displayText("-= Array Number Catch =-",tick:0,delay:1000);
            displayText("This program allow to detect specific number in array",delay:1000);

            while(!quit){

                if(!err){ 
                    clc(); 
                }

                err = false;

                displayText("Please enter a whole number: ",endLine:0);
                prompt = Console.ReadLine()!; //added '!' to forgive null reference
                if(rx.Matches(prompt).Count > 0){
                    err = true;
                    Console.Clear();
                    displayText("what?",delay:1000);
                } else if(prompt.Length<=0){
                    err = true;
                    Console.Clear();
                    displayText("eh?",delay:1000);
                } else {
                    int detectedNumber = int.Parse(prompt);
                    bool detected = false;

                    displayText("Detecting....",delay:1000);
                    displayText("Reading array....",delay:500);
                    displayText();

                    for(int i=0;i<myArray.GetLength(0);i++){
                        displayText($"{myArray[i]} ",endLine:0);
                        if((i+1) % 5 == 0){ displayText(); }
                        if(myArray[i]==detectedNumber){
                            detected=true;
                        }
                    }

                    displayText("\n",delay:1000);

                    if(detected){
                        displayText($"The number {detectedNumber} is detected!");
                    } else {
                        displayText($"Hmm... the number {detectedNumber} is not detected!");
                    }
                    
                    displayText();
                    displayText("Press any key to retry!");
                    displayText("Press 'q' key to abort!");
                    if(Console.ReadKey(true).Key.ToString() == "Q"){
                        quit = true;
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
    }
}
