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

    static void DisplayText(string text="\n", int tick = 30, int newLine = 1, int delay = 0)
    {
        for(int i1 = 0; i1 < text.Length; i1++)
        {
            Console.Write(text[i1]);
            Sleep(tick);

            if(newLine == 1 && i1 == text.Length - 1)
            {
                Console.Write("\n");
            }
        }
        Sleep(delay);
    }

    static double Calculation(double n1, double n2, string op)
    {
        double result = 0;

        if(op == "+")
        { 
            result = n1 + n2; 
        }

        if(op == "-")
        { 
            result = n1 - n2; 
        }

        if(op == "*")
        { 
            result = n1 * n2; 
        }

        if(op == "/")
        { 
            result = n1 / n2; 
        }

        return result;
    }

    static void Main(string[] args)
    {
        Clear();
        Sleep(1000);
        DisplayText("-= Simple Calculator =-",tick:0, delay:1000);
        DisplayText("This program does simple calculations.", delay:500);

        bool quit = false;
        bool error = false;

        int sw = 0;

        double num1 = 0;
        double num2 = 0;

        string prompt;

        Regex regexNotNumbers = new Regex("[^0-9.]");
        Regex regexNotOperators = new Regex("[^-+*/]");

        while(!quit)
        {
            if(!error)
            { 
                Clear(); 
            }

            error = false;

            if(sw == 0)
            {
                DisplayText("Please enter the first decimal number: ", newLine: 0);
            }

            if(sw == 1)
            {
                DisplayText("Please enter the second decimal number: ", newLine: 0);
            }

            else if(sw == 2)
            {
                DisplayText("Please enter an arithmetic operator '+' '-' '*' or '/' : ", newLine: 0 );
            }
            
            prompt = Console.ReadLine()!;

            if(sw == 2)
            {
                if(regexNotOperators.Matches(prompt).Count > 0)
                {
                    error = true;

                    Clear();
                    DisplayText("Input only an arithmetic operator!", delay: 1000);
                    Clear();
                }
            } 

            else 
            {
                if(regexNotNumbers.Matches(prompt).Count > 0)
                {
                    error = true;

                    Clear();
                    DisplayText("Use only decimal numbers!", delay: 1000);
                    Clear();
                }
            }

            if(prompt.Length <= 0)
            {
                error = true;

                Clear();

                if(sw == 2)
                { 
                    DisplayText("Please input an arithmetic operator.", delay: 1000);
                }

                else
                { 
                    DisplayText("Please input some numbers.", delay: 1000); 
                }

                Clear();

            } 
            else if(prompt == ".")
            {
                error = true;

                Clear();
                DisplayText("Please use numbers too.", delay: 1000);
                Clear();
            } 
            
            else if(prompt.ToString().Length > 1 && sw == 2)
            {
                error = true;

                Clear();
                DisplayText("Please input only one arithmetic operator.", delay: 1000);
                Clear();
            } 
            
            if(!error) 
            {
                double result = 0;

                Sleep(150);

                if(sw == 0)
                { 
                    num1 = double.Parse(prompt); 
                }

                if(sw == 1)
                { 
                    num2 = double.Parse(prompt); 
                }

                if(sw == 2)
                { 
                    result = Calculation(num1, num2, prompt); 
                }
                
                sw++;

                if(sw > 2)
                {
                    DisplayText($"The result is {result:0.00}", delay: 1000);
                    
                    DisplayText();
                    DisplayText("Press any key to retry!");
                    DisplayText("Press 'q' key to Exit!");

                    if(Console.ReadKey(true).Key.ToString() == "Q")
                    {
                        quit = true;
                    } 
                    
                    else 
                    {
                        sw = 0;
                    }
                }
            }
            
            if(quit)
            {
                Clear();
                DisplayText("Exiting program...", delay: 500);
                
                Clear();
                Exit(1);
            }
        }
    }
}
