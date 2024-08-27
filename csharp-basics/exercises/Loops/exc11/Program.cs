using System.Text.RegularExpressions;

class Program
{
    private static string CheckCapitalization(string letter)
    {
        Regex regexCapitalLetters = new Regex("[A-Z]");
        Regex regexNotCapitalLetters = new Regex("[a-z]");

        if(regexCapitalLetters.Matches(letter).Count > 0)
        {
            return letter.ToLower();
        }
        else if(regexNotCapitalLetters.Matches(letter).Count > 0)
        {
            return letter.ToUpper();
        }

        return " ";
    }

    private static string ReverseCase(string text)
    {
        string output = "";

        for(int i = 0; i < text.Length; i++)
        {
            output += CheckCapitalization(text[i].ToString());
        }

        return output;
    }

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("-= RevPitalize =-\n");
        Console.WriteLine("screwing around with text capitalization!");   
        Console.WriteLine("\n");
        Console.WriteLine("Press any key to continue...");

        Console.ReadKey(true);
        Console.Clear();
        Console.WriteLine();

        string[] stringsArray = 
        {
            "Happy Birthday",
            "MANY THANKS",
            "sPoNtAnEoUs",
            "CoDeLeX",
            "eDGARS",
            "sANDRIS",
        };

        Console.WriteLine("Reversing text capitalization...\n");

        for(int i = 0; i < stringsArray.GetLength(0); i++)
        {
            Console.WriteLine($"{stringsArray[i]} -> {ReverseCase(stringsArray[i])}");
        }
        
        Console.WriteLine("\n");
        Console.WriteLine("Press any key to exit program!");

        Console.ReadKey(true);
        
        Console.Clear();
        Console.WriteLine("Goodbye! :-)");
    }
}
             
    
