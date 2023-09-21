namespace OOP.L2;
public class MovieCatalog
{
    private List<Movie> movies = new();

    public void AddMovie(
        string title,
        MovieGenre genre,
        Country country,
        int raiting)
    {
        Movie movie = new(title, genre, country, raiting);
        movies.Add(movie);
    }

    public void RemoveMovie(Movie movie)
    {
        movies.Remove(movie);
    }

    public void EditMovies(
        List<Movie> foundMovies, (string, MovieGenre, Country, int) movieData)
    {
        (
            string title,
            MovieGenre genre,
            Country country,
            int raiting
        ) = movieData;

        foreach (Movie movie in foundMovies)
        {
            movie.EditMovie(title, genre, country, raiting);
        }
    }

    public void ShowMovies(RichTextBox richTextBox)
    {
        richTextBox.Text = string.Empty;

        foreach (Movie movie in movies)
        {
            richTextBox.Text += movie.ToString() + "\n";
        }
        richTextBox.Text = richTextBox.Text.TrimEnd();
    }

    public void ShowMovies(RichTextBox richTextBox, List<Movie> movies)
    {
        richTextBox.Text = string.Empty;

        foreach (Movie movie in movies)
        {
            richTextBox.Text += movie.ToString() + "\n";
        }
        richTextBox.Text = richTextBox.Text.TrimEnd();
    }

    public List<Movie> GetMovies()
    {
        return movies;
    }

    public List<Movie> FindMovies(string title)
    {
        return movies.FindAll(
            movie => movie.GetTitle() == title
        );
    }

    public void SortMovies(string attribute)
    {
        switch (attribute)
        {
            case "Название":
                movies = movies.OrderBy(movie => movie.GetTitle()).ToList();
                break;
            case "Жанр":
                movies = movies.OrderBy(movie => movie.GetGenre()).ToList();
                break;
            case "Страна":
                movies = movies.OrderBy(movie => movie.GetCountry()).ToList();
                break;
            case "Рейтинг":
                movies = movies.OrderBy(movie => movie.GetRaiting()).ToList();
                break;
        }
    }
}
