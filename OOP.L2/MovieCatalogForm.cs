namespace OOP.L2;

public partial class MovieCatalogForm : Form
{
    private MovieCatalog movieCatalog = new();
    private Movie? movieToEdit = null;

    public MovieCatalogForm()
    {
        InitializeComponent();

        genreComboBox.DataSource = Enum.GetValues(typeof(MovieGenre));
        sortComboBox.DataSource = Enum.GetValues(typeof(MovieAttribute));
        searchComboBox.DataSource = Enum.GetValues(typeof(MovieAttribute));
        countryComboBox.DataSource = Enum.GetValues(typeof(Country));

        UpdateEditMovieRadioButton();
        UpdateMovieIdNumericUpDown(movieIdNumericUpDown);
        UpdateMovieIdNumericUpDown(movieIdForRemoveNumericUpDown);

        addMovieRadioButton.Enabled = false;
        editMovieRadioButton.Enabled = false;
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

        Movie addedMovie = movieCatalog.GetMovies()[^1];
        UpdateEditMovieRadioButton();
        UpdateMovieIdNumericUpDown(movieIdNumericUpDown);
        UpdateMovieIdNumericUpDown(movieIdForRemoveNumericUpDown);
        ShowMessage(addedMovie, "Кинофильм добавлен");
    }

    private void EditMovieButton_Click(object sender, EventArgs e)
    {
        string errorMessage = "Ошибка изменения";
        string successMessage = "Кинофильм изменен";

        if (movieToEdit == null)
        {
            MessageBox.Show(errorMessage);
            return;
        }

        (
            string title,
            MovieGenre genre,
            Country country,
            int raiting
        ) = GetInputValues();

        movieCatalog.EditMovie(movieToEdit, (title, genre, country, raiting));
        movieCatalog.ShowMovies(moviesRichTextBox);

        ClearInputFields();
        ShowMessage(movieToEdit, successMessage);
        movieToEdit = null;
        DisableInputFields();
    }

    private void RemoveMovieButton_Click(object sender, EventArgs e)
    {
        string errorMessage = "Не удалось удалить кинофильм";
        string successMessage = "Кинофильм удален";

        Movie? movie = FindMovieForAction(movieIdForRemoveNumericUpDown);

        if (movie == null)
        {
            MessageBox.Show(errorMessage);
            return;
        }

        Movie? removedMovie = movieCatalog.RemoveMovie(movie.GetId());

        if (removedMovie == null)
        {
            MessageBox.Show(errorMessage);
            return;
        }

        movieCatalog.ShowMovies(moviesRichTextBox);
        ShowMessage(removedMovie, successMessage);

        UpdateMovieIdNumericUpDown(movieIdNumericUpDown);
        UpdateMovieIdNumericUpDown(movieIdForRemoveNumericUpDown);
        ClearInputFields();

        if (movieCatalog.GetMovies().Count == 0)
        {
            EnableAddMovieMode(false);
        }
    }

    private void FindMovieToEditButton_Click(object sender, EventArgs e)
    {
        string errorMessage = "Не найден кинофильм для изменения";
        string successMessage = "Найден кинофильм для изменения";

        Movie? movie = FindMovieForAction(movieIdNumericUpDown);

        if (movie == null)
        {
            DisableInputFields();
            MessageBox.Show(errorMessage);
            return;
        }

        EnableInputFields();

        UpdateEditFields(
            movie.GetTitle(),
            movie.GetGenre(),
            movie.GetCountry(),
            movie.GetRaiting());

        movieToEdit = movie;
        MessageBox.Show(successMessage);
    }

    private void FindMovieButton_Click(object sender, EventArgs e)
    {
        string searchValue = searchTitleTextBox.Text.Trim();
        string searchAttribute = searchComboBox.Text;

        Enum.TryParse(searchAttribute, out MovieAttribute movieMttribute);
        List<Movie> foundMovies = movieCatalog.FindMovie(movieMttribute, searchValue);

        if (foundMovies.Count == 0)
        {
            searchResultsRichTextBox.Text = string.Empty;
            MessageBox.Show("Ничего не найдено");
            return;
        }

        foreach (Movie movie in foundMovies)
        {
            searchResultsRichTextBox.Text += movie.ToString() + "\n";
        }

        searchResultsRichTextBox.Text = searchResultsRichTextBox.Text.TrimEnd();
        searchTitleTextBox.Text = string.Empty;
        searchComboBox.SelectedIndex = 0;

        movieCatalog.ShowMovies(searchResultsRichTextBox, foundMovies);
        ShowMessage(foundMovies, "Кинофильмы найдены");
    }

    private void MovieRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (addMovieRadioButton.Checked)
        {
            addEditMovieButton.Text = "Добавить";
            movieLabel.Text = "Введите информацию о кинофильме";

            movieIdFindLabel.Visible = false;
            movieIdNumericUpDown.Visible = false;
            findMovieToEditButton.Visible = false;

            addEditMovieButton.Click -= AddMovieButton_Click;
            addEditMovieButton.Click -= EditMovieButton_Click;

            addEditMovieButton.Click += AddMovieButton_Click;
        }
        else
        {
            addEditMovieButton.Text = "Изменить";
            movieLabel.Text = "Измените информацию о кинофильме";

            movieIdFindLabel.Visible = true;
            movieIdNumericUpDown.Visible = true;
            findMovieToEditButton.Visible = true;

            addEditMovieButton.Click -= AddMovieButton_Click;
            addEditMovieButton.Click -= EditMovieButton_Click;

            addEditMovieButton.Click += EditMovieButton_Click;
        }
    }

    private void SortMoviesButton_Click(object sender, EventArgs e)
    {
        movieCatalog.SortMovies(sortComboBox.Text);
        movieCatalog.ShowMovies(moviesRichTextBox);
        ShowMessage(movieCatalog.GetMovies(), "Кинофильмы отсортированы");
    }

    private void RaitingTrackBar_ValueChanged(object sender, EventArgs e)
    {
        raitingTextBox.Text = raitingTrackBar.Value.ToString();
    }

    private void EditMovieRadioButton_Click(object sender, EventArgs e)
    {
        EnableEditMovieMode();
    }

    private void AddMovieRadioButton_Click(object sender, EventArgs e)
    {
        EnableAddMovieMode();
    }

    private (string, MovieGenre, Country, int) GetInputValues()
    {
        string title = titleTextBox.Text.Trim();
        MovieGenre genre = (MovieGenre)genreComboBox.SelectedItem;
        Country country = (Country)countryComboBox.SelectedItem;
        int raiting = raitingTrackBar.Value;

        return (title, genre, country, raiting);
    }

    private static bool IsTitleValid(string title, bool showMessage = true)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            if (showMessage)
                MessageBox.Show("Заполните поле \"Название!\"");

            return false;
        }
        return true;
    }

    private void ClearInputFields()
    {
        titleTextBox.Text = string.Empty;
        genreComboBox.SelectedIndex = 0;
        countryComboBox.SelectedIndex = 0;
        raitingTrackBar.Value = 1;
    }

    private void ShowMessage(Movie movie, string message)
    {
        MessageBox.Show($"{message}: {movie.GetName()}");
    }

    private void ShowMessage(List<Movie> movies, string message = "")
    {
        message += ":\n";
        foreach (var movie in movies)
        {
            message += movie.GetName() + "\n";
        }
        message = message.TrimEnd();

        MessageBox.Show(message);
    }

    private void UpdateMovieIdNumericUpDown(NumericUpDown movieIdElement)
    {
        movieIdElement.Maximum = Movie.NextId() - 1;

        if (movieIdElement.Maximum != 0
            && movieIdElement.Minimum != 1)
            movieIdElement.Minimum = 1;

        if (movieCatalog.GetMovies().Count == 0)
        {
            removeMovieButton.Enabled = false;
            movieIdElement.Enabled = false;
            EnableAddMovieMode();
        }
        else
        {
            removeMovieButton.Enabled = true;
            movieIdElement.Enabled = true;
        }
    }

    private void UpdateEditMovieRadioButton()
    {
        if (editMovieRadioButton.Enabled)
            return;

        if (movieCatalog.GetMovies().Count > 0)
            editMovieRadioButton.Enabled = true;
    }

    private void UpdateEditFields(
        string title,
        MovieGenre genre,
        Country country,
        int raiting)
    {
        int genreIndex = Array.IndexOf(
            Enum.GetValues(typeof(MovieGenre)), genre);

        int countryIndex = Array.IndexOf(
            Enum.GetValues(typeof(Country)), country);


        titleTextBox.Text = title;
        genreComboBox.SelectedIndex = genreIndex;
        countryComboBox.SelectedIndex = countryIndex;
        raitingTrackBar.Value = raiting;
    }

    private Movie? FindMovieForAction(NumericUpDown movieIdElement)
    {
        int movieId = (int)movieIdElement.Value;
        Movie? movie = movieCatalog.FindMovie(movieId);

        return movie;
    }

    private void EnableInputFields()
    {
        titleTextBox.Enabled = true;
        genreComboBox.Enabled = true;
        countryComboBox.Enabled = true;
        raitingTrackBar.Enabled = true;
        raitingTextBox.Enabled = true;
        addEditMovieButton.Enabled = true;
    }

    private void DisableInputFields()
    {
        titleTextBox.Enabled = false;
        genreComboBox.Enabled = false;
        countryComboBox.Enabled = false;
        raitingTrackBar.Enabled = false;
        raitingTextBox.Enabled = false;
        addEditMovieButton.Enabled = false;
    }

    private void EnableAddMovieMode(bool enableEditRadioButton = true)
    {
        addMovieRadioButton.Checked = true;
        addMovieRadioButton.Enabled = false;
        editMovieRadioButton.Enabled = enableEditRadioButton;

        EnableInputFields();
    }

    private void EnableEditMovieMode()
    {
        editMovieRadioButton.Checked = true;
        addMovieRadioButton.Enabled = true;
        editMovieRadioButton.Enabled = false;

        DisableInputFields();
    }
}