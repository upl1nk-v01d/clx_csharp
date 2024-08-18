using System.Text.RegularExpressions;

class Geometry{
    public double areaCircle(double r){
        return Math.PI * r * 2;
    }
    public double areaRectangle(double length, double width){
        return length * width;
    }
    public double areaTriangle(double base_, double height){
        return base_ * height * 0.5;
    }
}
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
    static void Main(string[] args){

        clc();
        sleep(1000);
        displayText("-= geometry area calculation =-",0);

        Regex rx = new Regex("[^0-9]");
        bool quit=false, err=false;
        int[] menu={0,0};
        //double area = 0, length = 0, width = 0;

        int choise = -1;
        string? prompt;

        string[] opts1 = {
            "Calculate the Area of a Circle",
            "Calculate the Area of a Rectangle",
            "Calculate the Area of a Triangle",
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
                    displayText("Enter your choice (1-4):");
                    
                    var key = Console.ReadKey(true);
                    if(key.Key.ToString() == "D1"){ choise=1; menu[0]=1; menu[1]=0; }
                    else if(key.Key.ToString() == "D2"){ choise=2; menu[0]=2; menu[1]=0; }
                    else if(key.Key.ToString() == "D3"){ choise=3; menu[0]=3; menu[1]=0; }
                    else if(key.Key.ToString() == "D4"){ choise=4; quit=true; }
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
                displayText("Please enter circle radius: ",30, 0);
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
                    Geometry circle = new Geometry();
                    double area = circle.areaCircle(double.Parse(prompt));
                    displayText($"Area of circle is {area:0.00}");
                    sleep(1000);
                    displayText();
                    displayText("Press any key to return to main menu!");
                    Console.ReadKey(true);
                    choise=-1;
                    menu[0]=0; menu[1]=0;
                }
            }

            if(menu[0]==2 && menu[1]==0){
                displayText("Please enter rectangle length: ",30, 0);
                prompt = Console.ReadLine();
                double length = double.Parse(prompt);
                displayText("Please enter rectangle width: ",30, 0);
                prompt = Console.ReadLine();
                double width = double.Parse(prompt);
                Geometry circle = new Geometry();
                double area = circle.areaRectangle(length,width);
                displayText($"Area of rectangle is {area:0.00}");
                sleep(1000);
                displayText();
                displayText("Press any key to return to main menu!");
                Console.ReadKey(true);
                choise=-1;
                menu[0]=0; menu[1]=0;
            }

            if(menu[0]==3 && menu[1]==0){
                displayText("Please enter triangle length of base: ",30, 0);
                prompt = Console.ReadLine();
                double length = double.Parse(prompt);
                displayText("Please enter triangle height: ",30, 0);
                prompt = Console.ReadLine();
                double width = double.Parse(prompt);
                Geometry circle = new Geometry();
                double area = circle.areaRectangle(length,width);
                displayText($"Area of triangle is {area:0.00}");
                sleep(1000);
                displayText();
                displayText("Press any key to return to main menu!");
                Console.ReadKey(true);
                choise=-1;
                menu[0]=0; menu[1]=0;
            }
            
            if(quit){
                clc();
                quit=true;
                displayText("Exiting system...");
                sleep(1000);
                clc();
                exit(1);
            }
            
        }
    }
}