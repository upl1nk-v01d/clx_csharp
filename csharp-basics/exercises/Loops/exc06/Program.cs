using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("-= FizzBuzz =-\n");
        Console.WriteLine("This program prints FizzBuzz according to algorithm.");   
        Console.WriteLine("Press any key to start...");

        Console.ReadKey(true);

        Console.WriteLine();
        Console.Write("Please enter desired max value of whole number: ");
        
        string prompt = Console.ReadLine()!;

        int chosenNumber = int.Parse(prompt);
        string output = "";
            
        for(int i = 1; i < chosenNumber; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            { 
                output += "FizzBuzz"; 
            }
            else if(i % 5 == 0)
            { 
                output += "Buzz"; 
            }
            else if(i % 3 == 0)
            {
                 output += "Fizz"; 
            }
            else 
            { 
                output += i; 
            }

            output += " ";
            
            if(i % 20 == 0)
            { 
                output += "\n"; 
            }
        }

        Console.WriteLine("The result:\n");
        Console.WriteLine(output);
        Console.WriteLine();
        Console.WriteLine("Press any key to end program!");
        Console.ReadKey(true);
        Console.Clear();
    }
}