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

    private static int RollingDices(int dices)
    {
        Random randomNumber = new Random();

        int sum = 0;

        for(int d = 0; d < dices; d++)
        {
            int num = randomNumber.Next(1, 7);
            sum += num;
            Console.Write($"dice nr. {d + 1} = {num}\t");

            if((d + 1) % 4 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine("\n");

        return sum;
    }

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("-= RollTwoDice =-\n");
        Console.WriteLine("Your luck is on your side!");   
        Console.WriteLine("\n");
        Console.WriteLine("Press any key to continue...");

        Console.ReadKey(true);
        Console.Clear();

        bool stop = false;
        int sw = 0;

        int desiredSum = 0;
        int dicesQuantity = 0;

        string prompt;

        while(!stop)
        {
            Console.WriteLine();

            if(sw == 0)
            {
                Console.Write("Please enter a positive number of desired dices sum: ");
            }

            if(sw == 1)
            {
                Console.Write("Please enter a positive number of desired dices quantity: ");
            }

            prompt = Console.ReadLine()!;

            if(Validation(prompt) != "")
            {
                if(sw == 0)
                {
                    desiredSum = int.Parse(prompt);
                }

                if(sw == 1)
                {
                    dicesQuantity = int.Parse(prompt);
                }

                sw++;

                if(sw > 1)
                {
                    Console.WriteLine("Rolling dices...\n");

                    int dicesSum = RollingDices(dicesQuantity);

                    if(desiredSum == dicesSum)
                    {
                        Console.WriteLine($"WOW! You got lucky with {dicesSum} your chosen {desiredSum} sum!");
                    }
                    
                    else
                    {
                        Console.WriteLine($"Aaah! You missed lucky {dicesSum} sum with your chosen {desiredSum} sum!");
                    }

                    Console.WriteLine("\nRoll again? press 'Y' or 'N' key");

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