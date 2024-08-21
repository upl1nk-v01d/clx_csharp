using System.Text.RegularExpressions;

class Geometry
{
    public double areaCircle(double r)
    {
        return Math.PI * r * 2;
    }

    public double areaRectangle(double length, double width)
    {
        return length * width;
    }

    public double areaTriangle(double base_, double height)
    {
        return base_ * height * 0.5;
    }
}
class Program
{

    static void Sleep(int delay=1)
    {
        System.Threading.Thread.Sleep(delay);
    }

    static void Clear()
    {
        Console.Clear();
    }

    static void Exit(int p)
    {
        System.Environment.Exit(p);
    }

    static void DisplayText(string text="\n", int delay=30, int newLine=1){
        for(int i1=0;i1<text.Length;i1++){
            Console.Write(text[i1]);
            Sleep(delay);
            
            if(newLine==1 && i1 == text.Length-1)
            {
                Console.Write("\n");
            }
        }
    }

    static void Main(string[] args){

        Clear();
        Sleep(1000);
        DisplayText("-= geometry area calculation =-",newLine:0);
        Sleep(1000);

        Regex regex = new Regex("[^0-9]");

        bool quit=false;
        bool error=false;

        int[] menu={0,0};
        int choise = -1;

        string prompt;

        string[] opts1 = 
        {
            "Calculate the Area of a Circle",
            "Calculate the Area of a Rectangle",
            "Calculate the Area of a Triangle",
            "Quit"
        };

        while(!quit)
        {

            if(!error){ 
                Clear(); 
            }

            error = false;
            
            if(menu[0]==0 && menu[1]==0)
            {
                if(choise == -1)
                {
                    for(int i1=0; i1<opts1.GetLength(0); i1++)
                    {
                        DisplayText($"{i1+1}. {opts1[i1]}");
                    }

                    DisplayText();
                    DisplayText("Enter your choice (1-4):");
                    
                    var key = Console.ReadKey(true);

                    if(key.Key.ToString() == "D1")
                    { 
                        choise=1; 
                        menu[0]=1; 
                        menu[1]=0; 
                    }

                    else if(key.Key.ToString() == "D2")
                    { 
                        choise=2; 
                        menu[0]=2; 
                        menu[1]=0; 
                    }

                    else if(key.Key.ToString() == "D3")
                    { 
                        choise=3; 
                        menu[0]=3; 
                        menu[1]=0; 
                    }

                    else if(key.Key.ToString() == "D4")
                    { 
                        choise=4; 
                        quit=true; 
                    }

                    else 
                    { 
                        DisplayText();
                        DisplayText("Please choose available options.");
                        Sleep(1000);

                        choise=-1; 
                    }

                    Clear();
                }
            }

            if(menu[0]==1 && menu[1]==0)
            {
                DisplayText("Please enter circle radius: ",newLine:0);
                prompt = Console.ReadLine()!;
                
                if(regex.Matches(prompt).Count > 0)
                {
                    error = true;

                    Console.Clear();
                    Console.WriteLine("Please only digits!");
                } 
                
                else if(prompt.Length<=0)
                {
                    error = true;

                    Console.Clear();
                    Console.WriteLine("Input some whole numbers, please.");
                } 
                
                else 
                {
                    Geometry circle = new Geometry();
                    double area = circle.areaCircle(double.Parse(prompt));

                    DisplayText($"Area of circle is {area:0.00}");
                    Sleep(1000);

                    DisplayText();
                    DisplayText("Press any key to return to main menu!");

                    Console.ReadKey(true);

                    choise=-1;
                    menu[0]=0; 
                    menu[1]=0;
                }
            }

            if(menu[0]==2 && menu[1]==0)
            {
                DisplayText("Please enter rectangle length: ", newLine:0);
                prompt = Console.ReadLine()!;

                double length = double.Parse(prompt);
                DisplayText("Please enter rectangle width: ", newLine:0);
                prompt = Console.ReadLine()!;

                double width = double.Parse(prompt);

                Geometry circle = new Geometry();

                double area = circle.areaRectangle(length,width);

                DisplayText($"Area of rectangle is {area:0.00}");
                Sleep(1000);

                DisplayText();
                DisplayText("Press any key to return to main menu!");
                Console.ReadKey(true);

                choise=-1;
                menu[0]=0; 
                menu[1]=0;
            }

            if(menu[0]==3 && menu[1]==0)
            {
                DisplayText("Please enter triangle length of base: ", newLine:0);
                prompt = Console.ReadLine()!;

                double length = double.Parse(prompt);

                DisplayText("Please enter triangle height: ", newLine:0);
                prompt = Console.ReadLine()!;

                double width = double.Parse(prompt);

                Geometry circle = new Geometry();
                double area = circle.areaRectangle(length,width);

                DisplayText($"Area of triangle is {area:0.00}");
                Sleep(1000);

                DisplayText();
                DisplayText("Press any key to return to main menu!");
                Console.ReadKey(true);

                choise=-1;
                menu[0]=0; 
                menu[1]=0;
            }
            
            if(quit)
            {
                quit=true;

                Clear();
                DisplayText("Exiting system...");
                Sleep(1000);

                Clear();
                Exit(1);
            }
            
        }
    }
}