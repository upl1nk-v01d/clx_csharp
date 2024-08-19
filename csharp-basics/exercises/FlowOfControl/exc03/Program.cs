using System.Text.RegularExpressions;

class Program{

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

    static string weekDayCallback(int n){
        string d;
        switch (n){
            case 1:
                d = "Monday";
                break;
            case 2:
                d = "Tuesday";
                break;
            case 3:
                d = "Wednesday";
                break;
            case 4:
                d = "Thursday";
                break;
            case 5:
                d = "Friday";
                break;
            case 6:
                d = "Saturday";
                break;
            case 7:
                d = "Sunday";
                break;
            default:
                d = "not a valid day";
                break;
        }

        return d;
    }

    static void Main(string[] args){

        clc();
        sleep(1000);
        displayText("-= PrintDayInWord =-",0);
        sleep(1000);
        displayText("let's have some weekdays fun ;)",30);
        sleep(1000);

        Regex rx = new Regex("[^0-9]");
        bool quit=false, err=false;
        string? prompt;

        while(!quit){

            if(!err){ 
                clc(); 
            }

            err = false;

            displayText("Please enter weekday number: ",30, 0);
            prompt = Console.ReadLine()!; //added '!' to forgive null reference
            if(rx.Matches(prompt).Count > 0){
                err = true;
                Console.Clear();
                displayText("wtf? Please only a digit!");
                displayText("Please please please...");
            } else if(prompt.Length<=0){
                err = true;
                Console.Clear();
                displayText("Oh com' on! :@");
                sleep(1000);
                displayText("Input a whole number, please!");
            } else {
                string callback = weekDayCallback(int.Parse(prompt));
                displayText($"The number {prompt} of weekday is {callback}.");
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
                displayText("Goodbye! :)");
                sleep(1000);
                clc();
                exit(1);
            }
            
        }
    }
}