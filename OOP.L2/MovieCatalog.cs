namespace OOP.L2;
public class MovieCatalog
{
    private List<Movie> movies = new();

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

    public void ShowMovies(RichTextBox richTextBox)
    {
        richTextBox.Text = string.Empty;

        foreach (Movie movie in movies)
        {
            richTextBox.Text += movie.ToString() + "\n";
        }
        richTextBox.Text = richTextBox.Text.TrimEnd();
    }

    /*public void SetMovies(Movie[] movies)
    {
        this.movies = movies;
    }*/

    public List<Movie> GetMovies()
    {
        return movies;
    }

    public void FindMovie()
    {

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
