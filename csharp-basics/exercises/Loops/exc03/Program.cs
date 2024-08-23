// Write a program that asks which number position out of 20 random numbers you want to know.
class Program
{
    static void Main(string[] args)
    {
        Random randomNumbers = new Random();

        int[] arrayNumbers = new int[20];

        Console.Clear();
        Console.WriteLine();

        for(int i = 0; i < arrayNumbers.GetLength(0); i++)
        {
            arrayNumbers[i] = randomNumbers.Next(1, 100);
            Console.Write(arrayNumbers[i] + "\t");

            if((i + 1) % 5 == 0)
            {
                Console.Write("\n");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Which position of array element you want to know?");
        Console.WriteLine("Remember that array starts indexing from number zero!");

        bool quit = false;

        while(!quit)
        {
            Console.Write("Please enter a number: ");
            string prompt = Console.ReadLine()!;
            Console.WriteLine();

            int chosenNumber = int.Parse(prompt);

            if(chosenNumber > arrayNumbers.GetLength(0))
            {
                Console.WriteLine("You chose number that is greater than array's length!");
            }

            else if(chosenNumber < 0)
            {
                Console.WriteLine("You chose number that is less than zero!");
            }

            else
            {
                Console.WriteLine($"The element nr. {prompt}: value is {arrayNumbers[chosenNumber]}");
                quit = true;
            }

        }
    }
}
