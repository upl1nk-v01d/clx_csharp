class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("-= Enter two words =-");
        Console.WriteLine("The necessary dots will be drawn between words");
        Console.WriteLine("\n");

        Console.Write("Please enter first word: ");

        string chosenWord1 = Console.ReadLine()!;
        Console.WriteLine();

        Console.Write("Please enter second word: ");
        
        string chosenWord2 = Console.ReadLine()!;
        Console.WriteLine();

        Console.Clear();

        Console.WriteLine("The result: \n");

        int maxColumns = 30;

        for(int i = 0; i < 30; i++)
        {
            if(i < chosenWord1.Length)
            {
                Console.Write(chosenWord1[i]);
            }

            else if(i + 1 > maxColumns - chosenWord2.Length)
            {
                Console.Write(chosenWord2[i - maxColumns + chosenWord2.Length]);
            }

            else
            {
                Console.Write(".");
            }
        }

        Console.WriteLine("\n");
        Console.Write("Press any key to terminate program!");

        Console.ReadKey();
        Console.Clear();
    }
}
