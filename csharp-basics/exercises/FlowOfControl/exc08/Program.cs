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

    static double Calculation(double n1, double n2, string op){
        double r=0;

        if(op == "+"){ r = n1 + n2; }
        if(op == "-"){ r = n1 - n2; }
        if(op == "*"){ r = n1 * n2; }
        if(op == "/"){ r = n1 / n2; }

        return r;
    }

    static void Main(string[] args){

        clc();
        sleep(1000);
        displayText("-= Simple Calculator =-",0,delay:1000);
        displayText("This program does simple calculations.",delay:500);

        bool quit=false, err=false;
        int sw=0;
        double num1=0, num2=0;
        string prompt;

        Regex rxn = new Regex("[^0-9.]");
        Regex rxa = new Regex("[^-+*/]");

        while(!quit){

            if(!err){ 
                clc(); 
            }

            err = false;

            if(sw==0){
                displayText("Please enter the first decimal number: ",el:0);
            }
            if(sw==1){
                displayText("Please enter the second decimal number: ",el:0);
            }
            else if(sw==2){
                displayText("Please enter an arithmetic operator '+' '-' '*' or '/' : ",el:0);
            }
            
            prompt = Console.ReadLine()!;


            if(sw == 2){
                if(rxa.Matches(prompt).Count > 0){
                    err = true;
                    clc();
                    displayText("Input only an arithmetic operator!",delay:1000);
                    clc();
                }
            } else {
                if(rxn.Matches(prompt).Count > 0){
                    err = true;
                    clc();
                    displayText("Use only decimal numbers!",delay:1000);
                    clc();
                }
            }

            if(prompt.Length<=0){
                err = true;
                clc();
                if(sw==2){ displayText("Please input an arithmetic operator.",delay:1000); }
                else{ displayText("Please input some numbers.",delay:1000); }
                clc();
            } else if(prompt == "."){
                err = true;
                clc();
                displayText("Please use numbers too.",delay:1000);
                clc();
            } else if(prompt.ToString().Length>1 && sw==2){
                err = true;
                clc();
                displayText("Please input only one arithmetic operator.",delay:1000);
                clc();
            } 
            
            if(!err) {
                double result=0;
                sleep(150);
                if(sw==0){ num1 = double.Parse(prompt); }
                if(sw==1){ num2 = double.Parse(prompt); }
                if(sw==2){ result = Calculation(num1,num2,prompt); }
                sw++;
                if(sw>2){
                    displayText($"The result is {result:0.00}");
                    sleep(1000);
                    displayText();
                    displayText("Press any key to retry!");
                    displayText("Press 'q' key to exit!");
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
                displayText("Exiting program...",delay:500);
                clc();
                exit(1);
            }
        }
    }
}
