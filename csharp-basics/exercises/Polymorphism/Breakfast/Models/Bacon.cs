namespace Breakfast.Models;

public class Bacon
{
    public Bacon FryBacon(int slices)
    {
        for (var slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Cooking a slice of bacon");
            Task.Delay(2000).Wait();
        }

        return new Bacon();
    }

    public async Task<Bacon> FryBaconAsync(int slices)
    {
        for (var slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Cooking a slice of bacon");
            await Task.Delay(2000);
        }

        return new Bacon();
    }
}