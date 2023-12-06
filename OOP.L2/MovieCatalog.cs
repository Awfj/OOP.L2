namespace OOP.L2;
public class MovieCatalog : IObservable
{
    private List<Movie> movies = new();
    private List<IObserver> observers = new();

    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(object entity, object element)
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(entity, element);
        }
    }

    public List<IObserver> GetObservers()
    {
        return observers;
    }

    public void AddMovie(
        string title,
        MovieGenre genre,
        Country country,
        int raiting)
    {
        Movie movie = new(title, genre, country, raiting);
        movies.Add(movie);
    }

    public void EditMovie(
        Movie movieToEdit, (string, MovieGenre, Country, int) movieData)
    {
        (
            string title,
            MovieGenre genre,
            Country country,
            int raiting
        ) = movieData;

        movieToEdit.SetTitle(title);
        movieToEdit.SetGenre(genre);
        movieToEdit.SetCountry(country);
        movieToEdit.SetRaiting(raiting);
    }

    public Movie? RemoveMovie(int id)
    {
        Movie? movieToRemove = movies.Find(
            movie => movie.GetID() == id
        );

        if (movieToRemove == null)
            return null;

        movies.Remove(movieToRemove);
        Movie.GetAvailableIds().Enqueue(movieToRemove.GetID());

        return movieToRemove;
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

    public Movie? FindMovie(int id)
    {
        Movie? foundMovie = movies.Find(
            movie => movie.GetID() == id
        );

        return foundMovie;
    }

    public List<Movie> FindMovie(MovieAttribute movieAttribute, string serachValue)
    {
        List<Movie> foundMovies;

        switch (movieAttribute.ToString())
        {
            case "Жанр":
                foundMovies = movies.FindAll(
            movie => movie.GetGenre().ToString() == serachValue);
                break;
            case "Страна":
                foundMovies = movies.FindAll(
            movie => movie.GetCountry().ToString() == serachValue);
                break;
            case "Рейтинг":
                foundMovies = movies.FindAll(
            movie => movie.GetRaiting().ToString() == serachValue);
                break;
            default:
                foundMovies = movies.FindAll(
            movie => movie.GetTitle() == serachValue);
                break;
        }

        return foundMovies;
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
