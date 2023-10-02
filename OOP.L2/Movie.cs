namespace OOP.L2;
public class Movie
{
    private string title;
    private MovieGenre genre;
    private Country country;
    private int raiting;
    private readonly int id;
    private readonly string name;

    private readonly static Queue<int> availableIds = new();
    private static int nextId = 1;

    public Movie(string title, MovieGenre genre, Country country, int raiting)
    {
        if (availableIds.Count == 0)
        {
            id = nextId;
            nextId++;
        }
        else
        {
            id = availableIds.Dequeue();
        }

        this.title = title;
        this.genre = genre;
        this.country = country;
        this.raiting = raiting;
        name = $"{GetType().Name} №{id}";
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }

    public void SetGenre(MovieGenre genre)
    {
        this.genre = genre;
    }

    public void SetCountry(Country country)
    {
        this.country = country;
    }

    public void SetRaiting(int raiting)
    {
        this.raiting = raiting;
    }

    public int GetId()
    {
        return id;
    }

    public static int NextId()
    {
        return nextId;
    }

    public string GetName()
    {
        return name;
    }

    public static Queue<int> GetAvailableIds()
    {
        return availableIds;
    }

    public string GetTitle()
    {
        return title;
    }

    public MovieGenre GetGenre()
    {
        return genre;
    }

    public Country GetCountry()
    {
        return country;
    }

    public int GetRaiting()
    {
        return raiting;
    }

    public override string ToString()
    {
        return $"Имя: {name}, " +
            $"Название: {title}, " +
            $"Жанр: {genre}, " +
            $"Страна: {country}, " +
            $"Рейтинг: {raiting}";
    }
}
