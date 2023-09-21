namespace OOP.L2;

public partial class MovieCatalogForm : Form
{
    private MovieCatalog movieCatalog = new();

    public MovieCatalogForm()
    {
        InitializeComponent();

        genreComboBox.DataSource = Enum.GetValues(typeof(MovieGenre));
        sortComboBox.DataSource = Enum.GetValues(typeof(MovieAttribute));
        countryComboBox.DataSource = Enum.GetValues(typeof(Country));
    }

    private void AddMovieButton_Click(object sender, EventArgs e)
    {
        string title = titleTextBox.Text.Trim();

        if (Movie.IsTitleValid(title) == false)
        {
            MessageBox.Show("Заполните поле \"Название!\"");
            return;
        }

        MovieGenre genre = (MovieGenre)genreComboBox.SelectedItem;
        string country = countryComboBox.Text;
        int raiting = RaitingTrackBar.Value;
        Movie movie = new(title, genre, country, raiting);
        movieCatalog.AddMovie(movie);

        movieCatalog.ShowMovies(moviesRichTextBox);
        ClearInputFields();
    }

    private void RaitingTrackBar_ValueChanged(object sender, EventArgs e)
    {
        raitingTextBox.Text = RaitingTrackBar.Value.ToString();
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
        countryComboBox.Text = string.Empty;
        RaitingTrackBar.Value = 1;
    }

    private void SortMoviesButton_Click(object sender, EventArgs e)
    {
        movieCatalog.SortMovies(sortComboBox.Text);
        movieCatalog.ShowMovies(moviesRichTextBox);
    }
}
