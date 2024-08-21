using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {

        Regex regex = new Regex("[^0-9]");

        Console.Clear();
        Console.WriteLine("Welcome to 15 number playground! :)");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        bool quit = false;
        bool error = false;
        bool detected = false;

        int sw = 0;
        int num1 = 0; 
        int num2 = 0;
        
        string prompt;

        while(!quit)
        {

            if(!error)
            { 
                Console.Clear(); 
            }

            error = false;
            Console.WriteLine("To quit program just enter character 'q' in prompt");
            
            if(sw == 0)
            {
                Console.Write("Please enter the first random integer number: ");
            }

            if(sw == 1)
            {
                Console.Write("Ok, now enter the second random integer number: ");
            }

            if(sw > 1)
            {
                Console.Clear();
                Console.WriteLine("To continue program just press any key!");
                Console.WriteLine($"So your numbers are {num1} and {num2}");
                Console.ReadKey();
                if(num1 == 15)
                {
                    Console.WriteLine($"Hey, your first number is {num1}");
                    Console.ReadKey();
                    detected = true;
                }

                if(num2 == 15 && num1 != 15)
                {
                    Console.WriteLine($"Hey, your second number is {num2}");
                    detected = true;
                }

                if(num2 == 15 && num1 == 15)
                {
                    Console.WriteLine($"Wow, your second number is {num2}, is that accidental?");
                    detected = true;
                }

                if(num1 + num2 == 15)
                {
                    Console.WriteLine($"Your both number added together is {num1+num2}");
                    Console.WriteLine($"That's interesting!");
                    detected=true;
                }

                if(Math.Abs(num1 - num2) == 15)
                {
                    Console.WriteLine($"Your both number difference is {Math.Abs(num1-num2)}");
                    Console.WriteLine($"That's interesting!");
                    detected=true;
                }

                if(!detected)
                {
                    Console.WriteLine($"There's nothing more interesting! :d");
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to quit...");
                Console.ReadKey();
                Console.WriteLine("See you later! :)");
                System.Environment.Exit(1);
            }

            prompt = Console.ReadLine()!;

            if(prompt.ToLower() == "q")
            {
                Console.Clear();
                Console.WriteLine("Goodbye! :)");
                quit = true;
            } 

            else if(regex.Matches(prompt).Count > 0)
            {
                error = true;
                Console.Clear();
                Console.WriteLine("Please enter only numbers! :/");
            } 
            
            else if(prompt.Length<=0)
            {
                error = true;
                Console.Clear();
                Console.WriteLine("blankety blank won't do a thing! ;)");
            } 
            
            else 
            {
                if(sw == 0)
                { 
                    num1 = Convert.ToInt32(prompt); 
                }

                if(sw == 1)
                { 
                    num2 = Convert.ToInt32(prompt); 
                }
                
                sw++;
            }
        }
    }
}