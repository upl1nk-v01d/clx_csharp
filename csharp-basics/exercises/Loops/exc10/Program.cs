using System.Text.RegularExpressions;

class Program
{

    private static string Validation(string prompt)
    { 
        Regex regexNotNumbers = new Regex("[^0-9]");

        bool error = false;

        Console.Clear();

        if(prompt.Length < 1)
        {
            error = true;
            Console.WriteLine($"Cannot be empty!");
        }

        else if(regexNotNumbers.Matches(prompt).Count > 0)
        {
            error = true;
            Console.WriteLine("Please enter just digits!");
        }

        else if(int.Parse(prompt) < 1)
        {
            error = true;
            Console.WriteLine("Please enter a number above zero!");
        }

        if(error)
        {
            return "";
        }

        else
        {
            return prompt;
        }
        
    }

    private static string DrawNumbers(int minNumber, int maxNumber)
    {
        string output = "";

        for(int i1 = minNumber-1; i1 < maxNumber; i1++)
        {
            for(int i2 = minNumber; i2 <= maxNumber; i2++)
            {
                if(i1 + i2 > maxNumber)
                {
                    output += i2 + i1 - maxNumber;
                }

                else
                {
                    output += i2 + i1;
                }
                
            }

            output += "\n";
        }

        return output;
    }

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("-= NumbersSquare =-\n");
        Console.WriteLine("Making cyphers wavy!");   
        Console.WriteLine("\n");
        Console.WriteLine("Press any key to continue...");

        Console.ReadKey(true);
        Console.Clear();

        bool stop = false;
        int sw = 0;

        int minNumberPrompt = 0;
        int maxNumberPrompt = 0;

        string prompt = "";

        while(!stop)
        {
            Console.WriteLine();

            if(sw == 0)
            {
                Console.Write("Please enter a positive min number: ");
            }

            if(sw == 1)
            {
                Console.Write("Please enter a positive max number: ");
            }

            prompt = Console.ReadLine()!;

            if(Validation(prompt) != "")
            {
                if(sw == 0)
                {
                    minNumberPrompt = int.Parse(prompt);
                }

                if(sw == 1)
                {
                    maxNumberPrompt = int.Parse(prompt);
                }

                sw++;

                if(sw > 1)
                {
                    Console.WriteLine("Drawing square of numbers...\n");

                    string drawed = DrawNumbers(minNumberPrompt, maxNumberPrompt);

                    Console.WriteLine(drawed);
                    Console.WriteLine();
                    Console.WriteLine("Draw again? press 'Y' or 'N' key");

                    if(Console.ReadKey(true).Key.ToString() == "N")
                    {
                        stop = true;
                        Console.Clear();
                        Console.WriteLine("Goodbye! :-)");
                    }

                    else 
                    {
                        sw = 0;
                        Console.Clear();
                    }
                }
            }
        }        
    }
}