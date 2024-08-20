using System;
using System.Text.RegularExpressions;

namespace Exercise5
{
    class Program
    {

        private static void sleep(int delay=1){
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
            int[] myArray = { 25, 14, 56, 15, 36, 56, 77, 18, 29, 49 };
            
            Regex rx = new Regex("[^0-9]");
            bool quit=false, err=false;
            int sw = 0;
            int num1=0, num2=0;
            string prompt="";

            clc();
            displayText("-= Array Index Catch =-",tick:0,delay:1000);
            displayText("This program allow to detect specific index in array",delay:1000);

            while(!quit){

                if(!err){ 
                    clc(); 
                }

                err = false;

                if(sw == 0){
                    displayText("Please enter the first whole number: ",endLine:0);
                    prompt = Console.ReadLine()!; //added '!' to forgive null reference
                } else if(sw == 1){
                    displayText("Please enter the second whole number: ",endLine:0);
                    prompt = Console.ReadLine()!; //added '!' to forgive null reference
                }

                if(rx.Matches(prompt).Count > 0){
                    err = true;
                    Console.Clear();
                    displayText("No no no no no!",delay:1000);
                } else if(prompt.Length<=0){
                    err = true;
                    Console.Clear();
                    displayText("no blankety blanks here!",delay:1000);
                } else if(!err) {
                    if(sw == 0){ num1 = int.Parse(prompt); sw++; }
                    else if(sw == 1){ num2 = int.Parse(prompt); sw++; }
                    else if(sw > 1){ 
                        int idx1 = -1;
                        int idx2 = -1;

                        displayText($"Detecting numbers {num1} and {num2}....",delay:1000);
                        displayText("Reading array....",delay:500);
                        displayText();

                        for(int i=0;i<myArray.GetLength(0);i++){
                            displayText($"{myArray[i]} ",endLine:0);
                            if((i+1) % 4 == 0){ displayText(); }
                            if(myArray[i]==num1){ idx1 = i; }
                            if(myArray[i]==num2){ idx2 = i; }
                        }

                        displayText("\n",delay:1000);

                        if(idx1 > -1){
                            displayText($"The number {num1} index is {idx1}!");
                        } else {
                            displayText($"Oh no... no index for {num1}!");
                        }

                        if(idx2 > -1){
                            displayText($"The number {num2} index is {idx2}!");
                        } else {
                            displayText($"Aaah... no index for {num2}!");
                        }

                        displayText();
                        displayText("Press any key to retry!");
                        displayText("Press 'q' key to abort!");
                        if(Console.ReadKey(true).Key.ToString() == "Q"){
                            quit = true;
                        } else {
                            sw=0;
                        }
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
