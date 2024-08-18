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

    public static string moran(int num){
        int sum = Array.ConvertAll(num.ToString().Select(x => x.ToString()).ToArray(),Convert.ToInt32).Sum();
        int output = num / sum;
        string cb = num % sum == 0 ? "Harshad" : "nothing";
        for(int i =2; i < output;i++){
            if(output % i == 0){
                cb = cb == "Harshad" ? "Harshad" : "nothing";
                return cb;
            }
        }
        cb = cb == "Harshad" ? "Moran" : cb ;
        return cb;
    }
    static void Main(string[] args){

        clc();
        sleep(1000);
        displayText("-= Harshad vs Moran =-",0);

        Regex rx = new Regex("[^0-9]");
        bool quit=false, err=false;
        int[] menu={0,0};

        int choise = -1;
        string? prompt;

        string[] opts1 = {
            "Calculate Moran numbers",
            "Quit"
        };

        while(!quit){

            if(!err){ 
                clc(); 
            }

            err = false;
            
            if(menu[0]==0 && menu[1]==0){
                if(choise == -1){
                    for(int i1=0; i1<opts1.GetLength(0); i1++){
                        displayText($"{i1+1}. {opts1[i1]}");
                    }
                    displayText();
                    displayText("Enter your choice: ",30,0);
                    
                    var key = Console.ReadKey();
                    sleep(150);
                    if(key.Key.ToString() == "D1"){ choise=1; menu[0]=1; menu[1]=0; }
                    else if(key.Key.ToString() == "D2"){ choise=2; quit=true; }
                    else { 
                        displayText();
                        displayText("Please choose available options.");
                        sleep(1000);
                        choise=-1; 
                    }
                    clc();
                }
            }

            if(menu[0]==1 && menu[1]==0){
                displayText("Please enter whole number: ",30, 0);
                prompt = Console.ReadLine();
                if(rx.Matches(prompt).Count > 0){
                    err = true;
                    Console.Clear();
                    Console.WriteLine("Please only digits!");
                } else if(prompt.Length<=0){
                    err = true;
                    Console.Clear();
                    Console.WriteLine("Input some whole numbers, please.");
                } else {
                    string callback = moran(int.Parse(prompt));
                    displayText($"The number {prompt} is {callback}.");
                    displayText();
                    displayText("Press any key to return to main menu!");
                    Console.ReadKey(true);
                    choise=-1;
                    menu[0]=0; menu[1]=0;
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