namespace Breakfast.Models;

public class Egg
{
    public Egg FryEggs(int eggs)
    {
        for (var egg = 0; egg < eggs; egg++)
        {
            Console.WriteLine("Cooking a egg");
            Task.Delay(3000).Wait();
        }
        return new Egg();
    }

    public async Task<Egg> FryEggsAsync(int eggs)
    {
        for (var egg = 0; egg < eggs; egg++)
        {
            Console.WriteLine("Cooking a egg");
            await Task.Delay(millisecondsDelay: 3000);
        }
        return new Egg();
    }
}