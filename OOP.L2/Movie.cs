namespace OOP.L2;
public class Movie
{
    private string title;
    private MovieGenre genre;
    private string country;
    private int raiting;

    public Movie(string title, MovieGenre genre, string country, int raiting)
    {
        this.title = title;
        this.genre = genre;
        this.country = country;
        this.raiting = raiting;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }

    public void SetGenre(MovieGenre genre)
    {
        this.genre = genre;
    }

    public void SetCountry(string country)
    {
        this.country = country;
    }

    public void SetRaiting(int raiting)
    {
        this.raiting = raiting;
    }

    public string GetTitle()
    {
        return title;
    }

    public MovieGenre GetGenre()
    {
        return genre;
    }

    public string GetCountry()
    {
        return country;
    }

    public int GetRaiting()
    {
        return raiting;
    }

    public override string ToString()
    {
        return $"" +
            $"Название: {title}, " +
            $"жанр: {genre}, " +
            $"страна: {country}, " +
            $"рейтинг: {raiting}";
    }
}
