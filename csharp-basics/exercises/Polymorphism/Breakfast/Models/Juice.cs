namespace Breakfast.Models;

public class Juice
{
    public Juice PourJuice()
    {
        Console.WriteLine("Pouring orange juice");
        Task.Delay(1000).Wait();
        return new Juice();
    }

    public async Task<Juice> PourJuiceAsync()
    {
        Console.WriteLine("Pouring orange juice");
        await Task.Delay(1000);
        return new Juice();
    }
}