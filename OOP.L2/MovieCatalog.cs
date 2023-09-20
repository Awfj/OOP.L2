namespace OOP.L2;
public class MovieCatalog
{
    private readonly List<Movie> movies = new();

    public void AddMovie(Movie movie)
    {
        movies.Add(movie);
    }

    public void RemoveMovie(Movie movie)
    {
        movies.Remove(movie);
    }

    public void EditMovie()
    {

    }

    public void ShowMovies()
    {
        foreach (Movie movie in movies)
        {
            Console.WriteLine($"" +
                $"Title: {movie.GetTitle()}, " +
                $"Genre: {movie.GetGenre()}, " +
                $"Country: {movie.GetCountry()}, " +
                $"Raiting: {movie.GetRaiting()}");
        }
    }

    public void FindMovie()
    {

    }

    public void StructureMovies()
    {

    }
}
