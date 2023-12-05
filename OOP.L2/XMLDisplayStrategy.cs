using System.Text;

namespace OOP.L2;
public class XMLDisplayStrategy : IDisplayStrategy
{
    public string Display(List<Movie> movies)
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (Movie movie in movies)
        {
            stringBuilder.AppendLine($"<element>{movie.ToString()}</element>");
        }
        return stringBuilder.ToString();
    }
}
