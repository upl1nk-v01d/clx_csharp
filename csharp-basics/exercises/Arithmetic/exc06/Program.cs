using System.Text.RegularExpressions;

class Program
{

    static void Sleep(int delay=1)
    {
        System.Threading.Thread.Sleep(delay);
    }

    static void DisplayText(string text, int delay=30)
    {
        for(int i1=0;i1<text.Length;i1++)
        {
            Console.Write(text[i1]);
            Sleep(delay);
        }
    }

    static void DisplayTextArray(string[] text, int delay=30)
    {
        for(int i1=0;i1<text.Length;i1++)
        {
            for(int i2=0;i2<text[i1].Length;i2++)
            {
                Console.Write(text[i1][i2]);
                Sleep(delay);
            }

            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        string[] welcome = 
        {
            "-= CozaLozaWoza =-\n",
            "This program prints the numbers 1 to 110, 11 numbers per line.",
            "The program shall print \"Coza\" in place of the numbers which are multiples of 3, ",
            "\"Loza\" for multiples of 5, \"Woza\" for multiples of 7, ",
            "\"CozaLoza\" for multiples of 3 and 5, and so on. "
        };

        Console.Clear();
        
        DisplayTextArray(welcome);
        Sleep(1000);

        DisplayText("Press any key to start...\n");

        Console.ReadKey(true);

        bool quit=false;

        while(!quit)
        {
            DisplayText("To quit program press 'q' key\n");
            DisplayText("To start program just press any key.\n");

            if(Console.ReadKey(true).Key == ConsoleKey.Q)
            {
                quit=true;
            }

            if(!quit)
            {
                //main procedure
                string output = "";
                for(int i=1;i<111;i++)
                {
                    if(i % 7 == 0 && i % 5 == 0 && i % 3 == 0)
                    { 
                        output += "CozaLozaWoza "; 
                    }

                    else if(i % 7 == 0 && i % 3 == 0)
                    { 
                        output += "CozaWoza "; 
                    }

                    else if(i % 7 == 0){ 
                        output += "Woza "; 
                    }

                    else if(i % 5 == 0 && i % 3 == 0)
                    { 
                        output += "CozaLoza "; 
                    }

                    else if(i % 5 == 0)
                    { 
                        output += "Loza "; 
                    }

                    else if(i % 3 == 0)
                    { 
                        output += "Coza "; 
                    }

                    else {
                        output += i + " "; 
                    }
                    
                    if(i % 11 == 0)
                    {
                        output += "\n"; 
                    }

                }

                //output message
                DisplayText(output,15);

                Sleep(2000);

                Console.WriteLine();
                DisplayText($"Wanna try again? If not, press 'q' key.");

                if(Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    quit=true;
                }
            }

            if(quit)
            {
                Console.Clear();
                DisplayText("Tschau! :)",100);
                Sleep(1000);
                
                Console.Clear();
                System.Environment.Exit(1);
            }
        }
    }
}