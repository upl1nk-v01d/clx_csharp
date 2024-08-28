using System;

class Program
{
    private static readonly MovieStore store = new MovieStore();

    static private void Main(string[] args)
    {
        Console.Clear();
        store.AddMovie("Casino Royale", "Eon Productions", "PG13");
        store.AddMovie("Exile", "None Productions", "");
        store.AddMovie("Glass", "Buena Vista International", "PG13");
        store.AddMovie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG13");
        
        Console.WriteLine("\n");

        var filteredMovies = store.GetPG();

        foreach(var f in filteredMovies)
        {
            Console.WriteLine($"Movie with PG rating is {f.Title}");
        }
    }
}
