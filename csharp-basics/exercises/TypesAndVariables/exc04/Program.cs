namespace exc04
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Please, enter your name: "); //prompt message
            string? name = Console.ReadLine(); //waiting for user input
            Console.Write("Please, enter your year of birth: "); //prompt message
            int birthYear;

            //repeated (while) prompt below on incorrect submission
            while(!int.TryParse(Console.ReadLine(), out birthYear)){
                Console.Write("Please, enter NUMBERS of your year of yout birth: ");
            }
            
            Console.WriteLine();
            Console.WriteLine($"My name is {name} and I was born in {birthYear}.");
        }
    }
}