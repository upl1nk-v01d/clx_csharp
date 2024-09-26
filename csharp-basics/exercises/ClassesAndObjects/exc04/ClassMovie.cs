using System;

class Movie
{
    public string Title { get; set; }

    public string Studio { get; set; }

    public string Rating { get; set; }

    public Movie(string title, string studio, string rating)
    {
        Title = title;
        Studio = studio;
        Rating = rating;
    }

    public Movie(string title, string studio)
    {
        Title = title;
        Studio = studio;
        Rating = "PG";
    }
}

class MovieStore
{
    private static List<Movie> movies = new List<Movie>();

    public List<Movie> GetPG()
    {
        List<Movie> titles = new List<Movie>();

        int i = 0;

        foreach(var movie in movies)
        {
            if(movie.Rating.ToString().Contains("PG"))
            {
                titles.Add(movies[i]);
            }

            i++;
        }

        return titles;
    }

    public void AddMovie(string title, string studio, string rating)
    {
        movies.Add(new Movie(title, studio, rating));
        Console.WriteLine($"Movie with {title} has been added");
    }
}
