using System.Diagnostics;
using System.Threading.Channels;

namespace Breakfast
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Making breakfast Synchronous");
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            BreakFastProcessSync();

            stopwatch.Stop();

            Console.WriteLine($"Breakfast is ready! The process took {stopwatch.Elapsed.Seconds} seconds");
            stopwatch.Reset();
            Console.WriteLine();
            Console.WriteLine("Making breakfast Asynchronous");

            stopwatch.Start();

            await BreakfastProcessAsync();

            stopwatch.Stop();

            Console.WriteLine($"Breakfast is ready! The process took {stopwatch.Elapsed.Seconds} seconds");
        }

        static void BreakFastProcessSync()
        {
            var breakfast = new Models.Breakfast();

            var coffee = breakfast.Coffee.PourCoffee(1);
            Console.WriteLine("Coffee is ready");
            
            var bacon = breakfast.Bacon.FryBacon(2);
            Console.WriteLine("Bacon is ready");

            var egg = breakfast.Egg.FryEggs(2);
            Console.WriteLine("Egg is ready");

            var juice = breakfast.Juice.PourJuice();
            Console.WriteLine("Juice is ready");
        }

        static async Task BreakfastProcessAsync()
        {
            var breakfast = new Models.Breakfast();
            var coffeeTask = breakfast.Coffee.PourCoffeeAsync(1);
            var baconTask = breakfast.Bacon.FryBaconAsync(2);
            var eggTask = breakfast.Egg.FryEggsAsync(2);
            var juiceTask = breakfast.Juice.PourJuiceAsync();

            var breakfastTasks = new List<Task> { coffeeTask, baconTask, eggTask, juiceTask };

            while (breakfastTasks.Count > 0)
            {
                var finishedTask = await Task.WhenAny(breakfastTasks);

                if (finishedTask == coffeeTask)
                {
                    Console.WriteLine("Coffee are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("Bacon is ready");
                }
                else if (finishedTask == eggTask)
                {
                    Console.WriteLine("Egg is ready");
                }
                else if (finishedTask == juiceTask)
                {
                    Console.WriteLine("Juice is ready");
                }
                
                breakfastTasks.Remove(finishedTask);
            }
        }
    }
}