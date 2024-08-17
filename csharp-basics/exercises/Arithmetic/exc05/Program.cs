using System.Text.RegularExpressions;

class Program{
    static void Main(string[] args){

        Regex rx = new Regex("[^0-9]");

        Console.Clear();
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("-= 3x Guess or Miss =-");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Try to guess a number between 1 to 100");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();

        bool quit=false, err=false, retry=false;
        int sw=0;
        int num=0;
        int guessesInit=3;
        int guesses=guessesInit;
        string? prompt;

        while(!quit){

            if(!err){ 
                Console.Clear(); 
            }

            err = false;
            retry=false;
            Console.WriteLine("To quit program just enter character 'q' in prompt");
            
            if(sw == 0){
                Console.Write("Please enter chosen whole number: ");
            }
            if(sw > 0){
                Console.Clear();
                Console.WriteLine("To continue program just press any key!");
                Console.WriteLine($"Your input number is {num}.");
                System.Threading.Thread.Sleep(1000);

                //main procedure
                Random r = new Random();
                int rNum = r.Next(1,101); //101 is outer bound and is exclusive

                //output
                Console.WriteLine($"But random number is {rNum}.");
                System.Threading.Thread.Sleep(1000);

                if(num == rNum){
                    Console.WriteLine($"That's right!!!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine($"You gessed it!!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine($"What a coincidence!!");
                } else {
                    if(num>rNum){
                        Console.WriteLine($"Sorry, but it's Too High!");
                        System.Threading.Thread.Sleep(1000);
                    }
                    else if(num<rNum){
                        Console.WriteLine($"Sorry, but it's Too Low!");
                        System.Threading.Thread.Sleep(1000);
                    }
                    if(Math.Abs(num-rNum) < 4){
                        Console.WriteLine($"YOU ALMOST HAD IT!! :o");
                        System.Threading.Thread.Sleep(1000);
                    } else if(Math.Abs(num-rNum) < 11){
                        Console.WriteLine($"But you almost had it! :)");
                        System.Threading.Thread.Sleep(1000);
                    }
                    guesses--;
                    Console.WriteLine($"Your guesses remaining: {guesses}");
                    System.Threading.Thread.Sleep(1000);
                }
                if(guesses<1){
                    Console.WriteLine($"You run out of guesses!! :(");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine($"But don't give up!");
                    System.Threading.Thread.Sleep(1000);
                    guesses=guessesInit;
                }
                
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine($"Wanna try again? If not, press 'q' key.");

                if(Console.ReadKey(true).Key == ConsoleKey.Q){
                    Console.Clear();
                    quit=true;
                    Console.WriteLine("bb! :)");
                    System.Threading.Thread.Sleep(1000);
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
                    System.Threading.Thread.Sleep(1000);
                    System.Environment.Exit(1);
                } else if(rx.Matches(prompt).Count > 0){
                    err = true;
                    Console.Clear();
                    Console.WriteLine("Are you following or already tired? :/");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Please enter only digits! :)");
                    System.Threading.Thread.Sleep(1000);
                } else if(prompt.Length<=0){
                    err = true;
                    Console.Clear();
                    Console.WriteLine("Eh?!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Type something...");
                    System.Threading.Thread.Sleep(1000);
                } else if(int.Parse(prompt)<1){
                    Console.WriteLine();
                    Console.WriteLine("Please enter number higher than 0");
                    System.Threading.Thread.Sleep(2000);
                } else if(int.Parse(prompt)>100){
                    Console.WriteLine();
                    Console.WriteLine("Please enter number lower than 101");
                    System.Threading.Thread.Sleep(2000);
                } else {
                    if(sw == 0){ num = Convert.ToInt32(prompt); }
                    sw++;
                }
            }
        }
    }
}