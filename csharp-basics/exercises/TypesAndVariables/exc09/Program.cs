using System.Text.RegularExpressions;

namespace exc09
{
    class Program
    {
        static void Main(string[] args){
            string? prompt;
            bool quit = false;
            int sw = 0;
            decimal meters=0, hours=0, minutes=0, seconds=0;
            bool err = false;

            Regex regex = new Regex("[^0-9]");

            Console.Clear();
            Console.WriteLine("Welcome to speed computing machine! :)");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            while(!quit){

                if(!err){ 
                    Console.Clear(); 
                }

                err = false;
                Console.WriteLine("To quit program just enter character 'q' in prompt");
                
                if(sw == 0){
                    Console.Write("Now please enter distance in meters: ");
                }
                if(sw == 1){
                    Console.Write("Now please enter hours: ");
                }
                if(sw == 2){
                    Console.Write("Please enter minutes: ");
                }
                if(sw == 3){
                    Console.Write("And lastly, please enter seconds: ");
                }
                if(sw > 3){
                    decimal sumSeconds=seconds+minutes*60+hours*3600;
                    decimal speedMS = meters/sumSeconds;
                    decimal speedKMH = meters/sumSeconds*3.6m;
                    decimal speedMH = meters/sumSeconds*2.2369m;
                    Console.WriteLine($"Your speed in meters/second is {speedMS:0.00000000}");
                    Console.WriteLine($"Your speed in km/h is {speedKMH:0.00000000}");
                    Console.WriteLine($"Your speed in miles/h {speedMH:0.00000000}");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to quit...");
                    Console.ReadKey();
                    Console.WriteLine("See you later! :)");
                    System.Environment.Exit(1);
                }

                prompt = Console.ReadLine();

                if(prompt.ToLower() == "q"){
                    Console.Clear();
                    Console.WriteLine("Goodbye! :)");
                    quit = true;
                } else if(regex.Matches(prompt).Count > 0){
                    err = true;
                    Console.Clear();
                    Console.WriteLine("Please enter only numbers! :\\");
                } else if(prompt.Length<=0){
                    err = true;
                    Console.Clear();
                    Console.WriteLine("Please enter something? ;)");
                } else {
                    if(sw == 0){ meters = Convert.ToDecimal(prompt); }
                    if(sw == 1){ hours = Convert.ToDecimal(prompt); }
                    if(sw == 2){ minutes = Convert.ToDecimal(prompt); }
                    if(sw == 3){ seconds = Convert.ToDecimal(prompt); }
                    sw++;
                }
            }
        }
    }
}