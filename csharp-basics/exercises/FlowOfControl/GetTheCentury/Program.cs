using System;
using System.Text.RegularExpressions;

namespace GetTheCentury
{
    internal class Program{
        static void sleep(int delay=1){
            System.Threading.Thread.Sleep(delay);
        }
        static void clc(){
            Console.Clear();
        }
        static void exit(int p){
            System.Environment.Exit(p);
        }

        static void displayText(string text="\n", int delay=30, int el=1){
            for(int i1=0;i1<text.Length;i1++){
                Console.Write(text[i1]);
                sleep(delay);
                if(el==1 && i1 == text.Length-1){
                    Console.Write("\n");
                }
            }
        }

        static string GetTheCentury(int n){
            string yearString = $"{n:0000}";
            int century = int.Parse(yearString.Substring(0,2));
            if(n % 1000 >= 1){
                century++;
            }            
            string s = $"{century}th";
            return s;
        }

        static void Main(string[] args){

            clc();
            sleep(1000);
            displayText("-= GetTheCentury =-",0);
            sleep(1000);
            displayText("Determine century from year number.",30);
            sleep(500);
            displayText("Year range is 1000-2010 AD.",30);
            sleep(1000);

            Regex rx = new Regex("[^0-9]");
            bool quit=false, err=false;
            string prompt;

            while(!quit){

                if(!err){ 
                    clc(); 
                }

                err = false;

                displayText("Please enter year number from 1000 to 2010: ",30, 0);
                prompt = Console.ReadLine()!; //added '!' to forgive null reference
                int year = int.Parse(prompt);
                if(rx.Matches(prompt).Count > 0){
                    err = true;
                    Console.Clear();
                    displayText("Only numbers are allowed here.");
                } else if(prompt.Length<=0){
                    err = true;
                    Console.Clear();
                    displayText("No input?");
                    sleep(1000);
                    displayText("Type in 4 year numbers.");
                } else if(int.Parse(prompt)<1000){
                    displayText($"Your entered year {prompt} is below 1000.");
                    sleep(1000);
                 } else if(int.Parse(prompt)>2010){
                    displayText($"Your entered year {prompt} is above 2010.");
                    sleep(1000);
                } else {
                    Random r = new Random();
                    displayText("Getting century from year number...");
                    sleep(1000);
                    displayText("We got ",30,0);

                    string result = GetTheCentury(year);
                    foreach(char v in result){
                        displayText($"{v}",30,0);
                        sleep(r.Next(50, 200));
                    }

                    displayText(" century!");
                    sleep(1000);
                    displayText();
                    displayText("Press any key to retry!");
                    displayText("Press 'q' key to exit!");
                    if(Console.ReadKey(true).Key.ToString() == "Q"){
                        quit = true;
                    }
                }
                
                if(quit){
                    clc();
                    quit=true;
                    displayText("Goodbye! :)");
                    sleep(1000);
                    clc();
                    exit(1);
                }
                
            }
        }
    }
}
