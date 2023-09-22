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

    private (string, MovieGenre, Country, int) GetInputValues()
    {
        string title = titleTextBox.Text.Trim();
        MovieGenre genre = (MovieGenre)genreComboBox.SelectedItem;
        Country country = (Country)countryComboBox.SelectedItem;
        int raiting = RaitingTrackBar.Value;

        return (title, genre, country, raiting);
    }

    private bool IsTitleValid(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            MessageBox.Show("Заполните поле \"Название!\"");
            return false;
        }
        return true;
    }

    private void AddMovieButton_Click(object sender, EventArgs e)
    {
        (
            string title,
            MovieGenre genre,
            Country country,
            int raiting
        ) = GetInputValues();

        if (IsTitleValid(title) == false)
            return;

        movieCatalog.AddMovie(title, genre, country, raiting);

        movieCatalog.ShowMovies(moviesRichTextBox);
        ClearInputFields();
    }

    private void EditMovieButton_Click(object sender, EventArgs e)
    {
        string oldTitle = oldMovieTitleЕextBox.Text.Trim();

        (
            string title,
            MovieGenre genre,
            Country country,
            int raiting
        ) = GetInputValues();

        if (IsTitleValid(title) == false)
            return;

        List<Movie> foundMovies = movieCatalog.FindMovies(oldTitle);

        if (foundMovies.Count == 0)
        {
            MessageBox.Show("Не найдено кинофильмов для изменения!");
            return;
        }

        movieCatalog.EditMovies(foundMovies, (title, genre, country, raiting));

        movieCatalog.ShowMovies(moviesRichTextBox);

        oldMovieTitleЕextBox.Text = string.Empty;
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

    private void SearchMovieButton_Click(object sender, EventArgs e)
    {
        string title = searchTitleTextBox.Text.Trim();
        List<Movie> foundMovies = movieCatalog.FindMovies(title);

        if (foundMovies.Count == 0)
        {
            MessageBox.Show("Ничего не найдено!");
            return;
        }

        foreach (Movie movie in foundMovies)
        {
            searchResultsRichTextBox.Text += movie.ToString() + "\n";
        }

        searchResultsRichTextBox.Text = searchResultsRichTextBox.Text.TrimEnd();

        movieCatalog.ShowMovies(searchResultsRichTextBox, foundMovies);
    }

    private void MovieRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (addMovieRadioButton.Checked)
        {
            movieButton.Text = "Добавить";
            movieLabel.Text = "Введите информацию о кинофильме";

            oldMovieTitleLabel.Visible = false;
            oldMovieTitleЕextBox.Visible = false;

            movieButton.Click -= AddMovieButton_Click;
            movieButton.Click -= EditMovieButton_Click;

            movieButton.Click += AddMovieButton_Click;
        }
        else
        {
            movieButton.Text = "Изменить";
            movieLabel.Text = "Введите новую информацию о кинофильме";

            oldMovieTitleLabel.Visible = true;
            oldMovieTitleЕextBox.Visible = true;

            movieButton.Click -= AddMovieButton_Click;
            movieButton.Click -= EditMovieButton_Click;

            movieButton.Click += EditMovieButton_Click;
        }
    }

    private void RemoveMovieButton_Click(object sender, EventArgs e)
    {
        string title = removeMovieTitleTextBox.Text.Trim();

        if (IsTitleValid(title) == false)
            return;

        movieCatalog.RemoveMovie(title);
        movieCatalog.ShowMovies(moviesRichTextBox);
        removeMovieTitleTextBox.Text = string.Empty;
    }
}
