using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {

        Regex regex = new Regex("[^0-9]");

        Console.Clear();
        Console.WriteLine("Welcome to CheckOddEven! :)");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        bool quit = false;
        bool error = false;
        bool retry = false;

        int sw = 0;
        int num = 0;

        string prompt;

        while(!quit)
        {

            if(!error)
            { 
                Console.Clear(); 
            }

            error = false;
            retry = false;

            Console.WriteLine("To quit program just enter character 'q' in prompt");
            
            if(sw == 0)
            {
                Console.Write("Please enter random integer number: ");
            }
            
            if(sw > 0)
            {
                Console.Clear();
                Console.WriteLine("To continue program just press any key!");
                Console.WriteLine($"So your number is {num}.");

                if(num % 2 == 0)
                {
                    Console.WriteLine($"...and hey, your number {num} is Even Number");
                    Console.ReadKey();
                } 

                else 
                {
                    Console.WriteLine($"...and hey, your number {num} is Odd Number");
                    Console.ReadKey();
                }

                Console.Clear(); 
                Console.WriteLine($"Wanna try again? If not, press 'q' key.");

                if(Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    quit = true;

                    Console.WriteLine("bye! :)");
                    System.Environment.Exit(1);
                } 

                else 
                {
                    retry = true;
                    sw = 0;
                }
            }

            if(!retry)
            {
                prompt = Console.ReadLine()!;

                if(prompt.ToLower() == "q")
                {
                    Console.Clear();
                    Console.WriteLine("See you later! :)");

                    quit = true;
                } 
                
                else if(regex.Matches(prompt).Count > 0)
                {
                    error = true;

                    Console.Clear();
                    Console.WriteLine("Please enter only digits! :/");
                }

                else if(prompt.Length <= 0)
                {
                    error = true;
                    
                    Console.Clear();
                    Console.WriteLine("we are doing a job, man!");
                    Console.WriteLine("so don't be lazy and buckle your fingers!");
                } 
                
                else {
                    if(sw == 0){ 
                        num = Convert.ToInt32(prompt); 
                    }

                    sw++;
                }
            }
        }
    }
}