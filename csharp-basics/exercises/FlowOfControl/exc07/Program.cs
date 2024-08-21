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

    static void DisplayText(string text = "\n", int tick = 30, int newLine = 1, int delay = 0)
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

    static int GetComputerTurn(){
        Random randomNumber = new Random();
        return randomNumber.Next(0, 3); //3 is NOT inclusive
    }

    static void Main(string[] args){

        Clear();
        Sleep(1000);

        DisplayText("-= Rock-Paper-Scissors =-", tick: 0, delay: 1000);
        DisplayText("Are you ready to real battle with your computer?", delay: 500);
        DisplayText("Let's go!", delay: 1000);

        Regex regexNotNumbers = new Regex("[^0-9]");

        bool quit = false; 
        bool error = false;

        string prompt;

        string[] arrayRules = 
        {
            "Rock",
            "Paper",
            "Scissors"
        };

        while(!quit)
        {
            if(!error)
            { 
                Clear(); 
            }

            error = false;

            DisplayText("Your turn: ", delay: 500);
            DisplayText("Choose one of following option: ");
            
            for(int i = 0; i < arrayRules.GetLength(0); i++)
            {
                DisplayText($"{i + 1}. {arrayRules[i]}");
            }

            DisplayText();

            prompt = Console.ReadLine()!;

            if(regexNotNumbers.Matches(prompt).Count > 0)
            {
                error = true;

                Clear();
                DisplayText("Use your brain and enter only a number!", delay: 1000);
                Clear();
            } 
            
            else if(prompt.Length <= 0)
            {
                error = true;

                Clear();
                DisplayText("No turn?", delay: 1000);
                DisplayText("Get back and use your turn!", delay: 1000);
                Clear();
            } 
            
            else if(prompt.ToString().Length > 1)
            {
                error = true;

                Clear();
                DisplayText("What?", delay: 1000);
                DisplayText("Only one turn please!", delay: 1000);
                Clear();
            } 
            
            else 
            {
                Sleep(150);
                Clear();

                int responseHuman = int.Parse(prompt) - 1;

                DisplayText($"You chose {arrayRules[responseHuman]}", delay: 1000);
                DisplayText("Now computer's turn! >:(", delay: 500);
                DisplayText("Get ready...", delay: 1000);

                int responseComputer = GetComputerTurn();

                DisplayText();
                DisplayText($"Computer responded with {arrayRules[responseComputer]}!",delay: 1000);                
                
                DisplayText();
                DisplayText("And the WINNER is", newLine: 0, delay: 500);
                DisplayText("...", tick: 150, delay: 500);
                Clear();

                if(responseHuman == responseComputer)
                {
                    DisplayText("Whoaah!! It's a tie!", delay:500);
                    DisplayText("Go get em!!");
                } 
                
                else if(responseHuman == 0 && responseComputer == 1)
                {
                    DisplayText($"You lost to computer with {arrayRules[responseHuman]}");
                    DisplayText($"LOOSER!!");
                } 
                
                else if(responseHuman == 0 && responseComputer == 2)
                {
                    DisplayText($"You won computer with {arrayRules[responseHuman]}");
                    DisplayText($"Nice!");
                } 
                
                else if(responseHuman == 1 && responseComputer == 0)
                {
                    DisplayText($"You won computer with {arrayRules[responseHuman]}");
                    DisplayText($"Yeah!! Who is the king?!");
                } 
                
                else if(responseHuman == 1 && responseComputer == 2)
                {
                    DisplayText($"You lost computer with {arrayRules[responseHuman]}");
                    DisplayText($"Oh noooo!!");
                } 
                
                else if(responseHuman == 2 && responseComputer == 0)
                {
                    DisplayText($"You lost computer with {arrayRules[responseHuman]}");
                    DisplayText($"No way!!!");
                } 
                
                else if(responseHuman == 2 && responseComputer == 1)
                {
                    DisplayText($"You won computer with {arrayRules[responseHuman]}");
                    DisplayText($"Very impressive!!");
                }

                Sleep(1000);

                DisplayText();
                DisplayText("Press any key to retry!");
                DisplayText("Press 'q' key to Exit!");

                if(Console.ReadKey(true).Key.ToString() == "Q"){
                    quit = true;
                }
            }
            
            if(quit)
            {
                Clear();
                DisplayText("Hey! Are you leaving?", delay: 1000);
                DisplayText("Buuu!", delay: 1000);
                
                Clear();
                Exit(1);
            }
        }
    }
}
