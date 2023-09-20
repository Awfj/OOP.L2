namespace OOP.L2;

public partial class MovieCatalogForm : Form
{
    private MovieCatalog movieCatalog = new();

    public MovieCatalogForm()
    {
        InitializeComponent();

        genreComboBox.DataSource = Enum.GetValues(typeof(MovieGenre));
    }

    private void AddMovieButton_Click(object sender, EventArgs e)
    {
        string title = titleTextBox.Text;
        MovieGenre genre = (MovieGenre)genreComboBox.SelectedItem;
        string country = countryTextBox.Text;
        int raiting = RaitingTrackBar.Value;

        Movie movie = new(title, genre, country, raiting);
        movieCatalog.AddMovie(movie);

        ShowMovies();
        ClearInputFields();
    }

    private void RaitingTrackBar_ValueChanged(object sender, EventArgs e)
    {
        raitingTextBox.Text = RaitingTrackBar.Value.ToString();
    }

    private void ShowMovies()
    {
        moviesRichTextBox.Text = string.Empty;

        foreach (Movie movie in movieCatalog.GetMovies())
        {
            moviesRichTextBox.Text += movie.ToString() + "\n";
        }

        moviesRichTextBox.Text = moviesRichTextBox.Text.TrimEnd();
    }

    private void ShowMoviesButton_Click(object sender, EventArgs e)
    {

        foreach (Movie movie in movieCatalog.GetMovies())
        {
            moviesRichTextBox.Text += movie.ToString() + "\n";
        }

        moviesRichTextBox.Text = moviesRichTextBox.Text.TrimEnd();
    }

    private void ClearInputFields()
    {
        titleTextBox.Text = string.Empty;
        genreComboBox.SelectedIndex = 0;
        countryTextBox.Text = string.Empty;
        RaitingTrackBar.Value = 1;
    }
}
