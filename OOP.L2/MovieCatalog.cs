namespace OOP.L2;
public class MovieCatalog
{
    private List<Movie> movies = new();
    private int id;
    private string name;

    private static int nextId = 1;

    public MovieCatalog()
    {
        id = nextId;
        nextId++;

        name = $"{GetType().Name} №{id}";
    }

    public void AddMovie(
        string title,
        MovieGenre genre,
        Country country,
        int raiting)
    {
        Movie movie = new(title, genre, country, raiting);
        movies.Add(movie);

        ShowMessage(movie, "Кинофильм добавлен");
    }

    public void RemoveMovie(string title)
    {
        Movie? foundMovie = movies.Find(
            movie => movie.GetTitle() == title
        );

        if (foundMovie == null)
            return;

        movies.Remove(foundMovie);
        Movie.GetAvailableIds().Enqueue(foundMovie.GetId());

        ShowMessage(foundMovie, "Кинофильм удален");
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

        ShowMessage(foundMovies, "Фильмы изменены");
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
        var foundMovies = movies.FindAll(
            movie => movie.GetTitle() == title
        );

        ShowMessage(foundMovies, "Фильмы удалены");

        return foundMovies;
    }

    private void ShowMessage(Movie movie, string message)
    {
        MessageBox.Show($"{message}: {movie.GetName()}");
    }

    private void ShowMessage(List<Movie> movies, string message = "")
    {
        foreach (var movie in movies)
        {
            message += movie.GetName() + "\n";
        }

        MessageBox.Show($"{message}:\n{message}");
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

        ShowMessage(movies, "Фильмы отсортированы");
    }
}
