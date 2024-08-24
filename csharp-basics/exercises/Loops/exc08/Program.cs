using System.Text.RegularExpressions;

class Program
{

    private static string drawConstant(string symbol, int con = 1)
    {
        string output = "";
        
        for(int ci = 0; ci < con; ci++)
        {
            output += symbol;
        }

        return output;
    }

    private static string AsciiFigure(int num, int con = 1)
    {
        string output = "";

        for(int i1 = num; i1 > 0; i1--)
        {
            for(int i2 = 0; i2 < i1; i2++)
            {
                output += drawConstant("/", con);
            }
            
            for(int i3 = 0; i3 < num - i1; i3++)
            {
                output += drawConstant("*", con);
            }

            for(int i4 = 0; i4 < num - i1; i4++)
            {
                output += drawConstant("*", con);
            }

            for(int i5 = num; i5 > num - i1; i5--)
            {
                output += drawConstant("\\", con);
            }

            output += "\n";
        }

        return output;
    }

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("-= A.S.C.I.I figures! =-\n");
        Console.WriteLine("let's draw some pyramids");   
        Console.WriteLine("\n");
        Console.WriteLine("Press any key to continue...");

        Console.ReadKey(true);
        Console.Clear();

        Regex regexNotNumbers = new Regex("[^0-9]");

        bool stop = false;
        int sw = 0;

        int drawLayers = 0;
        int drawConstant = 0;

        string prompt;

        while(!stop)
        {
            Console.WriteLine();

            if(sw == 0)
            {
                Console.WriteLine("Let's draw a layers!");
                Console.Write("Please enter a positive number above zero: ");
            }

            if(sw == 1)
            {
                Console.WriteLine("Let's add a constant!");
                Console.Write("Please enter a positive number above zero: ");
            }

            prompt = Console.ReadLine()!;
            Console.Clear();

            if(prompt.Length < 1)
            {
                Console.WriteLine($"Cannot be empty!");
            }

            else if(regexNotNumbers.Matches(prompt).Count > 0)
            {
                Console.WriteLine("Please enter just digits!");
            }

            else if(int.Parse(prompt) < 1)
            {
                Console.WriteLine("Please enter a number above zero!");
            }
            
            else
            {
                if(sw == 0)
                {
                    drawLayers = int.Parse(prompt);
                }

                if(sw == 1)
                {
                    drawConstant = int.Parse(prompt);
                }

                sw++;

                if(sw > 1)
                {
                    Console.WriteLine("Drawing...\n");

                    string drawed = AsciiFigure(drawLayers, drawConstant);
                    Console.WriteLine(drawed);

                    Console.WriteLine("Restart? press 'Y' or 'N' key");

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