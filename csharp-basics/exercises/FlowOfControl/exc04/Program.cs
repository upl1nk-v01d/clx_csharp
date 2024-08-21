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

    static void DisplayText(string text = "\n", int tick = 30, int newLine = 1)
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
    }

    static string weekDayCallback(int n)
    {
        string d;
        switch (n)
        {
            case 1:
                d = "Monday";
                break;
            case 2:
                d = "Tuesday";
                break;
            case 3:
                d = "Wednesday";
                break;
            case 4:
                d = "Thursday";
                break;
            case 5:
                d = "Friday";
                break;
            case 6:
                d = "Saturday";
                break;
            case 7:
                d = "Sunday";
                break;
            default:
                d = "not a valid day";
                break;
        }

        return d;
    }

    static void Main(string[] args)
    {
        Clear();
        Sleep(1000);

        DisplayText("-= PrintDayInWord =-", tick: 0);
        Sleep(1000);

        DisplayText("let's have some weekdays fun ;)");
        Sleep(1000);

        Regex regexNotNumbers = new Regex("[^0-9]");

        bool quit = false; 
        bool error = false;

        string prompt;

        while(!quit)
        {
            if(!error)
            { 
                Clear(); 
            }

            error = false;

            DisplayText("Please enter weekday number: ", newLine: 0);
            prompt = Console.ReadLine()!; //added '!' to forgive null reference
            
            if(regexNotNumbers.Matches(prompt).Count > 0)
            {
                error = true;

                Console.Clear();
                DisplayText("wtf? Please only a digit!");
                DisplayText("Please please please...");
            } 
            
            else if(prompt.Length <= 0)
            {
                error = true;

                Console.Clear();
                DisplayText("Oh com' on! :@");
                Sleep(1000);

                DisplayText("Input a whole number, please!");
            } 
            
            else 
            {
                string callback = weekDayCallback(int.Parse(prompt));

                DisplayText($"The number {prompt} of weekday is {callback}.");
                DisplayText();
                DisplayText("Press any key to retry!");
                DisplayText("Press 'q' key to abort!");

                if(Console.ReadKey(true).Key.ToString() == "Q")
                {
                    quit = true;
                }
            }
            
            if(quit)
            {
                Clear();
                DisplayText("Goodbye! :)");
                Sleep(1000);

                Clear();
                Exit(1);
            }
        }
    }
}