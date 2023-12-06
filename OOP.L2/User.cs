namespace OOP.L2;
public class User : IObserver
{
    private readonly int id;
    private string name;
    private static int nextId = 1;

    public User(string name)
    {
        this.name = name;
        id = nextId;
        nextId++;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public int GetID()
    {
        return id;
    }

    public static int NextID()
    {
        return nextId;
    }

    public void Update(Movie newMovie)
    {
        Console.WriteLine($"{name} был уведомлен(а) о новом филмье: {newMovie.GetTitle()}");
    }

    public override string ToString()
    {
        return $"ID: {id}, имя: {name}";
    }
}
