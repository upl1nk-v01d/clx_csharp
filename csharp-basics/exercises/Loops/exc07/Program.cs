using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("-= Welcome to Piglet! =-\n");
        Console.WriteLine("Roll the dice and be a swine :0");   
        Console.WriteLine("\n");
        Console.WriteLine("Press any key to continue...");

        Console.ReadKey(true);

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Press any key to roll a dice...");
        Console.ReadKey();

        bool stop = false;

        int score = 0;

        Random randomDiceNumber = new Random();

        while(!stop)
        {
            Console.Clear();

            int rolledDiceNumber = randomDiceNumber.Next(1, 7);

            Console.WriteLine($"You rolled a {rolledDiceNumber}:\n");
            
            if(rolledDiceNumber == 1)
            {
                score = 0;
                Console.WriteLine($"You got 0 points, oink:0\n");
            }
            else
            {
                score += rolledDiceNumber;
                Console.WriteLine($"You got {score} points!\n");
            }
            
            Console.WriteLine("Roll again? press 'Y' or 'N' key");

            if(Console.ReadKey(true).Key.ToString() == "N")
            {
                stop = true;
                Console.Clear();
                Console.WriteLine("See you later, pig!");
            }
        }

        Console.ReadKey(true);
        Console.Clear();
    }
}