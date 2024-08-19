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

    static void phoneKeyPad(char n){
        switch (n){
            case 'a': case 'b': case 'c':
                Console.Write(2); break;
            case 'd': case 'e': case 'f':
                Console.Write(3); break;
            case 'g': case 'h': case 'i':
                Console.Write(4); break;
            case 'j': case 'k': case 'l':
                Console.Write(5); break;
            case 'm': case 'n': case 'o':
                Console.Write(6); break;
            case 'p': case 'q': case 'r': case 's':
                Console.Write(7); break;
            case 't': case 'u': case 'v':
                Console.Write(8); break;
            case 'w': case 'x': case 'y': case 'z':
                Console.Write(9); break;
            
            default:
                Console.WriteLine("not a valid symbol");
            break;
        }
    }

    static void Main(string[] args){

        clc();
        sleep(1000);
        displayText("-= PhoneKeyPad =-",0);
        sleep(1000);
        displayText("a prompt for user interaction with phone keypad",30);
        sleep(500);
        displayText("case-insensitive, just in case ;)",30);
        sleep(1000);

        Regex rx = new Regex("[^a-zA-Z]");
        bool quit=false, err=false;
        string? prompt;

        while(!quit){

            if(!err){ 
                clc(); 
            }

            err = false;

            displayText("Please enter some alphabet letters: ",30, 0);
            prompt = Console.ReadLine()!; //added '!' to forgive null reference
            if(rx.Matches(prompt).Count > 0){
                err = true;
                Console.Clear();
                displayText("Only letters are allowed here.");
            } else if(prompt.Length<=0){
                err = true;
                Console.Clear();
                displayText("Eh?! ehmmm? No input? :/");
                sleep(1000);
                displayText("Type in some letters.");
            } else {
                displayText("Converting letters to phone keypad's digits...");
                displayText("Get ready!! :O");
                Random r = new Random();
                prompt = prompt.ToLower();
                foreach(char v in prompt){
                    phoneKeyPad(v);
                    sleep(r.Next(50, 200));
                }
                //displayText($"The number {prompt} of weekday is {callback}.");
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