using System.Text.RegularExpressions;

class Program
{

    static void Sleep(int delay = 1)
    {
        System.Threading.Thread.Sleep(delay);
    }

    static void Clear()
    {
        Console.Clear();
    }

    static void Exit(int num)
    {
        System.Environment.Exit(num);
    }

    static void DisplayText(string text = "\n", int delay = 30, int newLine = 1)
    {
        for(int i1 = 0; i1 < text.Length; i1++){
            Console.Write(text[i1]);
            Sleep(delay);

            if(newLine == 1 && i1 == text.Length - 1)
            {
                Console.Write("\n");
            }
        }
    }

    public static string Moran(int num)
    {
        int sum = Array.ConvertAll(num.ToString().Select(x => x.ToString()).ToArray(),Convert.ToInt32).Sum();
        int output = num / sum;
        string resultString = num % sum == 0 ? "Harshad" : "nothing";
        
        for(int i = 2; i < output; i++)
        {
            if(output % i == 0)
            {
                resultString = resultString == "Harshad" ? "Harshad" : "nothing";
                return resultString;
            }
        }

        resultString = resultString == "Harshad" ? "Moran" : resultString;
        return resultString;
    }

    static void Main(string[] args)
    {

        Clear();
        Sleep(1000);

        DisplayText("-= Harshad vs Moran =-",0);

        Regex regex = new Regex("[^0-9]");

        bool quit = false; 
        bool error = false;
        
        int[] menu = {0,0};
        int choise = -1;

        string prompt;

        string[] opts1 = 
        {
            "Calculate Moran numbers",
            "Quit"
        };

        while(!quit)
        {

            if(!error)
            { 
                Clear(); 
            }

            error = false;
            
            if(menu[0] == 0 && menu[1] == 0)
            {
                if(choise == -1)
                {
                    for(int i1 = 0; i1 < opts1.GetLength(0); i1++)
                    {
                        DisplayText($"{i1 + 1}. {opts1[i1]}");
                    }

                    DisplayText();
                    DisplayText("Enter your choice: ",newLine: 0);

                    var key = Console.ReadKey();

                    Sleep(150);

                    if(key.Key.ToString() == "D1")
                    { 
                        choise = 1; 
                        menu[0] = 1; 
                        menu[1] = 0; 
                    }

                    else if(key.Key.ToString() == "D2"){ 
                        choise = 2; 
                        quit = true; 
                    }

                    else 
                    { 
                        DisplayText();
                        DisplayText("Please choose available options.");
                        Sleep(1000);

                        choise = -1; 
                    }

                    Clear();
                }
            }

            if(menu[0] == 1 && menu[1] == 0)
            {
                DisplayText("Please enter whole number: ", newLine: 0);
                prompt = Console.ReadLine()!;
                
                if(regex.Matches(prompt).Count > 0)
                {
                    error = true;
                    Console.Clear();
                    Console.WriteLine("Please only digits!");
                } 
                
                else if(prompt.Length <= 0)
                {
                    error = true;

                    Console.Clear();
                    Console.WriteLine("Input some whole numbers, please.");
                } 

                else 
                {
                    string callback = Moran(int.Parse(prompt));

                    DisplayText($"The number {prompt} is {callback}.");
                    DisplayText();

                    DisplayText("Press any key to return to main menu!");
                    Console.ReadKey(true);

                    choise = -1;
                    menu[0] = 0;
                    menu[1] = 0;
                }
            }
            
            if(quit)
            {
                quit = true;

                Clear();
                DisplayText("Goodbye! :)");
                Sleep(1000);
                
                Clear();
                Exit(1);
            }
            
        }
    }
}