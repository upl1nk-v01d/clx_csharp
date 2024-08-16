using System.Text.RegularExpressions;

namespace exc07
{
    class Program
    {
        static void Main(string[] args){
            string? prompt;
            bool quit = false;
            bool parsed = false;
            int uChars = 0;

            Regex regex = new Regex("[A-Z]");

            Console.Clear();
            Console.WriteLine("Welcome to big letters counting machine! :)");
            Console.WriteLine("To quit program just enter character 'q' in prompt");
            Console.Write("Please enter a latin alphabet text: ");
            prompt = Console.ReadLine();

            while(!quit){
                if(parsed){
                    parsed = false;
                    Console.WriteLine("The uppercase letters now is: " + uChars);
                    prompt = Console.ReadLine();
                }

                if(prompt.ToLower() == "q"){
                    Console.Clear();
                    Console.WriteLine("Your quantity of big letters: " + uChars);
                    Console.WriteLine("Goodbye! :)");
                    quit = true;
                } else {
                    Console.Clear();
                    uChars = regex.Matches(prompt).Count;
                    Console.WriteLine("Your quantity of big letters: " + uChars);
                }
                
                if(!quit){
                    if(prompt.Length<=0){
                        Console.Clear();
                        Console.WriteLine("Please enter something? ;)");
                    }
                }
                
                if(!parsed && !quit){
                    Console.WriteLine("To quit program just enter character 'q' in prompt");
                    Console.Write("Now please enter some text with big letters: ");
                    prompt = Console.ReadLine();
                }
            }
        }
    }
}