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

    static void displayText(string text="\n", int tick=30, int el=1, int delay=0){
        for(int i1=0;i1<text.Length;i1++){
            Console.Write(text[i1]);
            sleep(tick);
            if(el==1 && i1 == text.Length-1){
                Console.Write("\n");
            }
        }
        sleep(delay);
    }

    static int GetComputerTurn(){
        Random r = new Random();
        return r.Next(0, 3); //3 is NOT inclusive
    }

    static void Main(string[] args){

        clc();
        sleep(1000);
        displayText("-= Rock-Paper-Scissors =-",0,delay:1000);
        displayText("Are you ready to real battle with your computer?",delay:500);
        displayText("Let's go!",delay:1000);

        Regex rx = new Regex("[^0-9]");
        bool quit=false, err=false;
        string prompt;

        string[] arrayRules = {
            "Rock",
            "Paper",
            "Scissors"
        };

        while(!quit){

            if(!err){ 
                clc(); 
            }

            err = false;

            displayText("Your turn: ",delay:500);
            displayText("Choose one of following option: ");
            for(int i=0;i<arrayRules.GetLength(0);i++){
                displayText($"{i+1}. {arrayRules[i]}");
            }
            displayText();
            prompt = Console.ReadLine()!;
            if(rx.Matches(prompt).Count > 0){
                err = true;
                clc();
                displayText("Use your brain and enter only a number!",delay:1000);
                clc();
            } else if(prompt.Length<=0){
                err = true;
                clc();
                displayText("No turn?",delay:1000);
                displayText("Get back and use your turn!",delay:1000);
                clc();
            } else if(prompt.ToString().Length>1){
                err = true;
                clc();
                displayText("What?",delay:1000);
                displayText("Only one turn please!",delay:1000);
                clc();
            } else {
                sleep(150);
                clc();
                int responseHuman = int.Parse(prompt)-1;
                displayText($"You chose {arrayRules[responseHuman]}",delay:1000);
                displayText("Now computer's turn! >:(",delay:500);
                displayText("Get ready...",delay:1000);

                int responseComputer = GetComputerTurn();

                displayText();
                displayText($"Computer responded with {arrayRules[responseComputer]}!",delay:1000);                
                displayText();
                displayText("And the WINNER is",el:0,delay:500);
                displayText("...",tick:150,delay:500);
                clc();

                if(responseHuman == responseComputer){
                    displayText("Whoaah!! It's a tie!",delay:500);
                    displayText("Go get em!!");
                } else if(responseHuman == 0 && responseComputer == 1){
                    displayText($"You lost to computer with {arrayRules[responseHuman]}");
                    displayText($"LOOSER!!");
                } else if(responseHuman == 0 && responseComputer == 2){
                    displayText($"You won computer with {arrayRules[responseHuman]}");
                    displayText($"Nice!");
                } else if(responseHuman == 1 && responseComputer == 0){
                    displayText($"You won computer with {arrayRules[responseHuman]}");
                    displayText($"Yeah!! Who is the king?!");
                } else if(responseHuman == 1 && responseComputer == 2){
                    displayText($"You lost computer with {arrayRules[responseHuman]}");
                    displayText($"Oh noooo!!");
                } else if(responseHuman == 2 && responseComputer == 0){
                    displayText($"You lost computer with {arrayRules[responseHuman]}");
                    displayText($"No way!!!");
                } else if(responseHuman == 2 && responseComputer == 1){
                    displayText($"You won computer with {arrayRules[responseHuman]}");
                    displayText($"Very impressive!!");
               }

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
                displayText("Hey! Are you leaving?",delay:1000);
                displayText("Buuu!",delay:1000);
                clc();
                exit(1);
            }
            
        }
    }
}
