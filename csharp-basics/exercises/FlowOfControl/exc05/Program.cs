using System.Text.RegularExpressions;

class Program
{

    static void Sleep(int delay = 1){
        System.Threading.Thread.Sleep(delay);
    }

    static void Clear()
    {
        Console.Clear();
    }

    static void Exit(int num){
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

    static void phoneKeyPad(char n)
    {
        switch (n)
        {
            case 'a': case 'b': case 'c':
                Console.Write(2); 
                break;

            case 'd': case 'e': case 'f':
                Console.Write(3); 
                break;

            case 'g': case 'h': case 'i':
                Console.Write(4); 
                break;

            case 'j': case 'k': case 'l':
                Console.Write(5); 
                break;

            case 'm': case 'n': case 'o':
                Console.Write(6); 
                break;

            case 'p': case 'q': case 'r': case 's':
                Console.Write(7); 
                break;

            case 't': case 'u': case 'v':
                Console.Write(8); 
                break;

            case 'w': case 'x': case 'y': case 'z':
                Console.Write(9); 
                break;
            
            default:
                Console.WriteLine("not a valid symbol");
                break;
        }
    }

    static void Main(string[] args){

        Clear();
        Sleep(1000);

        DisplayText("-= PhoneKeyPad =-", tick: 0);
        Sleep(1000);

        DisplayText("a prompt for user interaction with phone keypad");
        Sleep(500);

        DisplayText("case-insensitive, just in case ;)");
        Sleep(1000);

        Regex regexNotLetters = new Regex("[^a-zA-Z]");

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

            DisplayText("Please enter some alphabet letters: ", newLine: 0);
            
            prompt = Console.ReadLine()!; //added '!' to forgive null reference
            
            if(regexNotLetters.Matches(prompt).Count > 0)
            {
                error = true;

                Console.Clear();
                DisplayText("Only letters are allowed here.");
            } 
            
            else if(prompt.Length <= 0)
            {
                error = true;

                Console.Clear();
                DisplayText("Eh?! ehmmm? No input? :/");
                Sleep(1000);

                DisplayText("Type in some letters.");
            } 
            
            else 
            {
                DisplayText("Converting letters to phone keypad's digits...");
                DisplayText("Get ready!! :O");

                Random r = new Random();

                prompt = prompt.ToLower();

                foreach(char v in prompt){
                    phoneKeyPad(v);
                    Sleep(r.Next(50, 200));
                }

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