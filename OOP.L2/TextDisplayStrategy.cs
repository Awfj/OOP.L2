using System.Text;

namespace OOP.L2;
public class TextDisplayStrategy : IDisplayStrategy
{
    public string Display(List<Movie> movies)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (Movie movie in movies)
        {
            stringBuilder.AppendLine($"«{movie.ToString()}»");
        }
        return stringBuilder.ToString();
    }
}
