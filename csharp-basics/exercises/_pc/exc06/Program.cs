namespace exc05
{
    class Program
    {
        static void Main(string[] args){
            string? prompt;
            int c = 1; //declared entered number counter
            bool quit = false;
            bool parsed = false;
            int sum = 0;

            Console.Clear();
            Console.WriteLine("Welcome to numbers adding machine! :)");
            Console.WriteLine("To quit program just enter character 'q' in prompt");
            Console.Write("Please enter a single number: ");
            prompt = Console.ReadLine();

            while(!quit){
                if(parsed){
                    sum += Convert.ToInt32(prompt);
                    c++;
                    parsed = false;
                    Console.WriteLine("The sum now is: " + sum);
                    Console.Write("Please enter " + c + ". number: ");
                    prompt = Console.ReadLine();
                }

                if(prompt.Length==1){
                    if(prompt.ToLower() == "q"){
                        Console.Clear();
                        Console.WriteLine("Your sum of entered numbers: " + sum);
                        Console.WriteLine("Goodbye! :)");
                        quit = true;
                    } else if(int.TryParse(prompt,out _)){
                        Console.Clear();
                        Console.WriteLine("You entered number: " +prompt);
                        parsed = true;
                    }
                } 
                
                if(!quit){
                    if(!int.TryParse(prompt,out _)){
                        Console.Clear();
                        Console.Write("Please enter only a single number: ");
                    } else if(prompt.Length>1 || prompt.Length<=0){
                        Console.Clear();
                        Console.Write("Please enter only a single number: ");
                    }
                }
                
                if(!parsed && !quit){
                    prompt = Console.ReadLine();
                }
            }
        }
    }
}