using System.Text.RegularExpressions;

class Program{
    static void Main(string[] args){

        Regex rx = new Regex("[^0-9]");

        Console.Clear();
        Console.WriteLine("Welcome to -= Product1ToN =- :)");
        Console.WriteLine("This program will do factorial number computing.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        bool quit=false, err=false, retry=false;
        int sw=0;
        int num=0, fact=1;
        string? prompt;

        while(!quit){

            if(!err){ 
                Console.Clear(); 
            }

            err = false;
            retry=false;
            Console.WriteLine("To quit program just enter character 'q' in prompt");
            
            if(sw == 0){
                Console.Write("Please enter random factorial integer number: ");
            }
            if(sw > 0){
                Console.Clear();
                Console.WriteLine("To continue program just press any key!");
                Console.WriteLine($"Your input number is {num}.");

                //main procedure
                for(int i=0;i<num;i++){
                    fact *= i+1;
                }

                Console.WriteLine($"So your factorial number !{num} is {fact}.");
                Console.ReadLine();

                Console.Clear(); 
                Console.WriteLine($"Wanna try again? If not, press 'q' key.");

                if(Console.ReadKey(true).Key == ConsoleKey.Q){
                    quit=true;
                    Console.WriteLine("bb! :)");
                    System.Environment.Exit(1);
                } else {
                    retry=true;
                    sw=0;
                }
            }

            if(!retry){
                prompt = Console.ReadLine();

                if(prompt.ToLower() == "q"){
                    Console.Clear();
                    Console.WriteLine("See you later! :)");
                    quit = true;
                } else if(rx.Matches(prompt).Count > 0){
                    err = true;
                    Console.Clear();
                    Console.WriteLine("No no no no and nNO! :/");
                    Console.WriteLine("Please only digits! :)");
                } else if(prompt.Length<=0){
                    err = true;
                    Console.Clear();
                    Console.WriteLine("I know you can do it!");
                    Console.WriteLine("Fill something in...");
                } else {
                    if(sw == 0){ num = Convert.ToInt32(prompt); }
                    sw++;
                }
            }
        }
    }
}