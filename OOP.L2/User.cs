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

    public void Update(object entity, object element)
    {
        Movie newMovie = (Movie)entity;
        RichTextBox richTextBox = (RichTextBox)element;

        richTextBox.Text += $"{name} был(а) уведомлен(а) о новом фильме: {newMovie.GetTitle()}\n";
    }

    public override string ToString()
    {
        return $"ID: {id}, имя: {name}";
    }

    public void DisplayNewMovieInfo(Movie newMovie, RichTextBox richTextBox)
    {
        richTextBox.Text += $"{name} был(а) уведомлен(а) о новом фильме: {newMovie.GetTitle()}\n";
    }
}
