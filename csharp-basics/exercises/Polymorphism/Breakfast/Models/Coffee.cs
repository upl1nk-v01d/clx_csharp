namespace Breakfast.Models;

public class Coffee
{
    public Coffee PourCoffee(int cup)
    {
        Console.WriteLine($"Pouring {cup} of coffee");
        Task.Delay(1000).Wait();
        return new Coffee();
    }

    public async Task<Coffee> PourCoffeeAsync(int cup)
    {
        Console.WriteLine($"Pouring {cup} of coffee");
        await Task.Delay(1000);
        return new Coffee();
    }
}