
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

    static void displayText(string text="\n", int delay=30){
        for(int i1=0;i1<text.Length;i1++){
            Console.Write(text[i1]);
            sleep(delay);
            if(i1 == text.Length-1){
                Console.Write("\n");
            }
        }
    }

    static void Main(string[] args){

        clc();
        sleep(1000);
        displayText("-= employees management system v1.0 =-",0);

        Regex rx = new Regex("[^0-9]");
        bool quit=false, err=false, retry=false;
        int[] menu={0,0};
        
        int cols = 47; 
        int rightIndent1 = 16; 
        int rightIndent2 = 28; 
        int rightIndent3 = 45;

        int choise = -1;

        string[] opts1 = {
            "Show employees",
            "Quit"
        };

        string[] opts2 = {
            "Show employee data",
            "Report employee salaries",
            "Add employee [unavailable]",
            "Remove employee [unavailable]",
            "Return"
        };

        string[,] employees = {
            {"<NAME>","<BASE PAY>","<WORKHOURS>"},
            {"Alfred","7.50","35"},
            {"Bobby","8.20","47"},
            {"Max","10.00","73"}
        };

        string[,] salaries =  new string[32,3];

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
                    displayText("To choose an option press number key.");
                    
                    var key = Console.ReadKey(true);
                    //displayText(key.Key.ToString());
                    if(key.Key.ToString() == "D1"){ choise=1; menu[0]=1; menu[1]=0; }
                    else if(key.Key.ToString() == "D2"){ choise=5; quit=true; }
                    else { 
                        displayText();
                        displayText("Please choose available options.");
                        sleep(1000);
                        choise=-1; 
                    }
                    clc();
                }
            }


            if(menu[0]==1 && menu[1]==1){
                cols = 47;
                rightIndent3 = 45;

                for(int i1=0; i1<employees.GetLength(0); i1++){
                    if(i1==0){
                        for(int i3=0; i3<cols;i3++){
                            if(i3==0 || i3 == cols-1){ Console.Write("+"); }
                            else { Console.Write("-"); }
                        }
                        Console.WriteLine();
                    }

                    for(int i2=0; i2<cols; i2++){
                        if(i2>=(rightIndent1-employees[i1,0].Length-1) && i2<rightIndent1-1){
                            Console.Write(employees[i1,0][i2-(rightIndent1-employees[i1,0].Length-1)]);
                        } else if(i2>=(rightIndent1-employees[i1,0].Length-1) && i2<rightIndent1-1){
                            Console.Write(employees[i1,0][i2-(rightIndent1-employees[i1,0].Length-1)]);
                        } else if(i2>=(rightIndent2-employees[i1,1].Length-1) && i2<rightIndent2-1){
                            Console.Write(employees[i1,1][i2-(rightIndent2-employees[i1,1].Length-1)]);
                        } else if(i2>=(rightIndent3-employees[i1,2].Length-1) && i2<rightIndent3-1){
                            Console.Write(employees[i1,2][i2-(rightIndent3-employees[i1,2].Length-1)]);
                        } else if(i2==0 || i2==rightIndent1 || i2==rightIndent2 || i2==rightIndent3 || i2==cols-1){
                            Console.Write(" "); 
                        } else if(i1>0 && i2==2){
                            Console.Write(i1); 
                        } else {
                            Console.Write(" ");
                        }
                        
                    }

                    if(i1==employees.GetLength(0)-1){
                        Console.WriteLine();
                        for(int i3=0; i3<cols;i3++){
                            if(i3==0 || i3 == cols-1){ Console.Write("+"); }
                            else { Console.Write("-"); }
                        }
                    }

                    Console.WriteLine();
                }
                displayText();
                displayText("To continue program just press any key!");
                Console.ReadKey(true);
                choise=-1;
                menu[0]=1; menu[1]=0;
                clc();
            }

            if(menu[0]==1 && menu[1]==0){
                for(int i1=0; i1<opts2.GetLength(0); i1++){
                    displayText($"{i1+1}. {opts2[i1]}");
                }
                displayText();
                displayText("To choose an option press number key.");
                
                var key = Console.ReadKey(true);
                if(key.Key.ToString() == "D1"){ choise=1; menu[0]=1; menu[1]=1; }
                else if(key.Key.ToString() == "D2"){ choise=2; menu[0]=1; menu[1]=2; }
                else if(key.Key.ToString() == "D3"){ err = true; }
                else if(key.Key.ToString() == "D4"){ err = true; }
                else if(key.Key.ToString() == "D5"){ choise=-1; menu[0]--; menu[1]=0; }
                
                if(err){ 
                    displayText("Please choose available option.");
                    sleep(1000);
                    choise=-1; 
                }
                clc();
            }

            if(menu[0]==1 && menu[1]==2){
                rightIndent3 = 61;
                cols = 63;
                for(int i1=0; i1<employees.GetLength(0); i1++){

                    if(i1==0){
                        salaries[i1,0] = "<NAME>";
                        salaries[i1,1] = "<SALARY>";
                        salaries[i1,2] = "<NOTES>";

                        for(int i3=0; i3<cols;i3++){
                            if(i3==0 || i3 == cols-1){ Console.Write("+"); }
                            else { Console.Write("-"); }
                        }
                        Console.WriteLine();
                    }

                    if(i1>0){
                        decimal salary=0m;
                        string salaryString = "";
                        string errorString = "";
                        salary = decimal.Parse(employees[i1,1]) * decimal.Parse(employees[i1,2]);
                        salaryString = salary.ToString();

                        if(double.Parse(employees[i1,1])<8.00){
                            errorString = "minimum wage exceeded!";
                        } else {
                            errorString = "";
                        }
                        salaries[i1,0] = employees[i1,0];
                        salaries[i1,1] = salaryString;
                        salaries[i1,2] = errorString;
                    }

                    for(int i2=0; i2<cols; i2++){
                        if(i2>=(rightIndent1-salaries[i1,0].Length-1) && i2<rightIndent1-1){
                            Console.Write(salaries[i1,0][i2-(rightIndent1-salaries[i1,0].Length-1)]);
                        } else if(i2>=(rightIndent2-salaries[i1,1].Length-1) && i2<rightIndent2-1){
                            Console.Write(salaries[i1,1][i2-(rightIndent2-salaries[i1,1].Length-1)]);
                        } else if(i2>=(rightIndent3-salaries[i1,2].Length-1) && i2<rightIndent3-1){
                            Console.Write(salaries[i1,2][i2-(rightIndent3-salaries[i1,2].Length-1)]);
                        } else if(i2==0 || i2==rightIndent1 || i2==rightIndent2 || i2==rightIndent3 || i2==cols-1){
                            Console.Write(" "); 
                        } else if(i1>0 && i2==2){
                            Console.Write(i1); 
                        } else {
                            Console.Write(" ");
                        }
                        
                    }

                    if(i1==employees.GetLength(0)-1){
                        Console.WriteLine();
                        for(int i3=0; i3<cols;i3++){
                            if(i3==0 || i3 == cols-1){ Console.Write("+"); }
                            else { Console.Write("-"); }
                        }
                    }

                    Console.WriteLine();
                }
                displayText();
                displayText("To continue program just press any key!");
                Console.ReadKey(true);
                choise=-1;
                menu[0]=1; menu[1]=0;
                clc();
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