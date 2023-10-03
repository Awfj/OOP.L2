namespace OOP.L2;

partial class MovieCatalogForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        movieLabel = new Label();
        movieGenreLabel = new Label();
        countryLabel = new Label();
        raitingLabel = new Label();
        titleTextBox = new TextBox();
        movieTitleLabel = new Label();
        addEditMovieButton = new Button();
        moviesRichTextBox = new RichTextBox();
        genreComboBox = new ComboBox();
        raitingTextBox = new TextBox();
        raitingTrackBar = new TrackBar();
        moviesLabel = new Label();
        sortComboBox = new ComboBox();
        sortByLabel = new Label();
        sortMoviesButton = new Button();
        countryComboBox = new ComboBox();
        searchResultsRichTextBox = new RichTextBox();
        searchResultsLabel = new Label();
        searchTitleTextBox = new TextBox();
        searchMoviesLabel = new Label();
        searchByFieldLabel = new Label();
        searchMovieButton = new Button();
        addEditGroupBox = new GroupBox();
        editMovieRadioButton = new RadioButton();
        addMovieRadioButton = new RadioButton();
        movieIdFindLabel = new Label();
        removeMovieLabel = new Label();
        movieIdRemoveLabel = new Label();
        removeMovieButton = new Button();
        movieIdNumericUpDown = new NumericUpDown();
        findMovieToEditButton = new Button();
        movieIdForRemoveNumericUpDown = new NumericUpDown();
        searchComboBox = new ComboBox();
        searchValueLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)raitingTrackBar).BeginInit();
        addEditGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)movieIdNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)movieIdForRemoveNumericUpDown).BeginInit();
        SuspendLayout();
        // 
        // movieLabel
        // 
        movieLabel.AutoSize = true;
        movieLabel.Location = new Point(12, 132);
        movieLabel.Name = "movieLabel";
        movieLabel.Size = new Size(213, 15);
        movieLabel.TabIndex = 0;
        movieLabel.Text = "Введите информацию о кинофильме";
        // 
        // movieGenreLabel
        // 
        movieGenreLabel.AutoSize = true;
        movieGenreLabel.Location = new Point(33, 200);
        movieGenreLabel.Name = "movieGenreLabel";
        movieGenreLabel.Size = new Size(41, 15);
        movieGenreLabel.TabIndex = 0;
        movieGenreLabel.Text = "Жанр:";
        // 
        // countryLabel
        // 
        countryLabel.AutoSize = true;
        countryLabel.Location = new Point(25, 235);
        countryLabel.Name = "countryLabel";
        countryLabel.Size = new Size(49, 15);
        countryLabel.TabIndex = 0;
        countryLabel.Text = "Страна:";
        // 
        // raitingLabel
        // 
        raitingLabel.AutoSize = true;
        raitingLabel.Location = new Point(20, 269);
        raitingLabel.Name = "raitingLabel";
        raitingLabel.Size = new Size(54, 15);
        raitingLabel.TabIndex = 0;
        raitingLabel.Text = "Рейтинг:";
        // 
        // titleTextBox
        // 
        titleTextBox.Location = new Point(80, 162);
        titleTextBox.Name = "titleTextBox";
        titleTextBox.Size = new Size(145, 23);
        titleTextBox.TabIndex = 1;
        // 
        // movieTitleLabel
        // 
        movieTitleLabel.AutoSize = true;
        movieTitleLabel.Location = new Point(12, 165);
        movieTitleLabel.Name = "movieTitleLabel";
        movieTitleLabel.Size = new Size(62, 15);
        movieTitleLabel.TabIndex = 0;
        movieTitleLabel.Text = "Название:";
        // 
        // addEditMovieButton
        // 
        addEditMovieButton.Location = new Point(80, 320);
        addEditMovieButton.Name = "addEditMovieButton";
        addEditMovieButton.Size = new Size(104, 23);
        addEditMovieButton.TabIndex = 5;
        addEditMovieButton.Text = "Добавить";
        addEditMovieButton.UseVisualStyleBackColor = true;
        addEditMovieButton.Click += AddMovieButton_Click;
        // 
        // moviesRichTextBox
        // 
        moviesRichTextBox.Location = new Point(403, 65);
        moviesRichTextBox.Name = "moviesRichTextBox";
        moviesRichTextBox.ReadOnly = true;
        moviesRichTextBox.Size = new Size(364, 144);
        moviesRichTextBox.TabIndex = 50;
        moviesRichTextBox.Text = "";
        // 
        // genreComboBox
        // 
        genreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        genreComboBox.FormattingEnabled = true;
        genreComboBox.Location = new Point(80, 197);
        genreComboBox.Name = "genreComboBox";
        genreComboBox.Size = new Size(145, 23);
        genreComboBox.TabIndex = 2;
        // 
        // raitingTextBox
        // 
        raitingTextBox.Location = new Point(332, 271);
        raitingTextBox.Name = "raitingTextBox";
        raitingTextBox.ReadOnly = true;
        raitingTextBox.Size = new Size(25, 23);
        raitingTextBox.TabIndex = 80;
        raitingTextBox.Text = "1";
        // 
        // raitingTrackBar
        // 
        raitingTrackBar.Location = new Point(80, 269);
        raitingTrackBar.Maximum = 100;
        raitingTrackBar.Minimum = 1;
        raitingTrackBar.Name = "raitingTrackBar";
        raitingTrackBar.Size = new Size(246, 45);
        raitingTrackBar.TabIndex = 4;
        raitingTrackBar.Value = 1;
        raitingTrackBar.ValueChanged += RaitingTrackBar_ValueChanged;
        // 
        // moviesLabel
        // 
        moviesLabel.AutoSize = true;
        moviesLabel.Location = new Point(403, 35);
        moviesLabel.Name = "moviesLabel";
        moviesLabel.Size = new Size(82, 15);
        moviesLabel.TabIndex = 0;
        moviesLabel.Text = "Кинофильмы";
        // 
        // sortComboBox
        // 
        sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        sortComboBox.FormattingEnabled = true;
        sortComboBox.Location = new Point(505, 223);
        sortComboBox.Name = "sortComboBox";
        sortComboBox.Size = new Size(121, 23);
        sortComboBox.TabIndex = 81;
        // 
        // sortByLabel
        // 
        sortByLabel.AutoSize = true;
        sortByLabel.Location = new Point(401, 226);
        sortByLabel.Name = "sortByLabel";
        sortByLabel.Size = new Size(98, 15);
        sortByLabel.TabIndex = 82;
        sortByLabel.Text = "Сортировать по:";
        // 
        // sortMoviesButton
        // 
        sortMoviesButton.Location = new Point(632, 223);
        sortMoviesButton.Name = "sortMoviesButton";
        sortMoviesButton.Size = new Size(97, 23);
        sortMoviesButton.TabIndex = 83;
        sortMoviesButton.Text = "Сортировать";
        sortMoviesButton.UseVisualStyleBackColor = true;
        sortMoviesButton.Click += SortMoviesButton_Click;
        // 
        // countryComboBox
        // 
        countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        countryComboBox.FormattingEnabled = true;
        countryComboBox.Location = new Point(80, 232);
        countryComboBox.Name = "countryComboBox";
        countryComboBox.Size = new Size(145, 23);
        countryComboBox.TabIndex = 3;
        // 
        // searchResultsRichTextBox
        // 
        searchResultsRichTextBox.Location = new Point(403, 301);
        searchResultsRichTextBox.Name = "searchResultsRichTextBox";
        searchResultsRichTextBox.ReadOnly = true;
        searchResultsRichTextBox.Size = new Size(364, 86);
        searchResultsRichTextBox.TabIndex = 84;
        searchResultsRichTextBox.Text = "";
        // 
        // searchResultsLabel
        // 
        searchResultsLabel.AutoSize = true;
        searchResultsLabel.Location = new Point(403, 274);
        searchResultsLabel.Name = "searchResultsLabel";
        searchResultsLabel.Size = new Size(111, 15);
        searchResultsLabel.TabIndex = 85;
        searchResultsLabel.Text = "Результаты поиска";
        // 
        // searchTitleTextBox
        // 
        searchTitleTextBox.Location = new Point(147, 424);
        searchTitleTextBox.Name = "searchTitleTextBox";
        searchTitleTextBox.Size = new Size(145, 23);
        searchTitleTextBox.TabIndex = 86;
        // 
        // searchMoviesLabel
        // 
        searchMoviesLabel.AutoSize = true;
        searchMoviesLabel.Location = new Point(12, 361);
        searchMoviesLabel.Name = "searchMoviesLabel";
        searchMoviesLabel.Size = new Size(123, 15);
        searchMoviesLabel.TabIndex = 87;
        searchMoviesLabel.Text = "Поиск кинофильмов";
        // 
        // searchByFieldLabel
        // 
        searchByFieldLabel.AutoSize = true;
        searchByFieldLabel.Location = new Point(45, 391);
        searchByFieldLabel.Name = "searchByFieldLabel";
        searchByFieldLabel.Size = new Size(96, 15);
        searchByFieldLabel.TabIndex = 88;
        searchByFieldLabel.Text = "Поиск по полю:";
        // 
        // searchMovieButton
        // 
        searchMovieButton.Location = new Point(147, 453);
        searchMovieButton.Name = "searchMovieButton";
        searchMovieButton.Size = new Size(104, 23);
        searchMovieButton.TabIndex = 89;
        searchMovieButton.Text = "Найти";
        searchMovieButton.UseVisualStyleBackColor = true;
        searchMovieButton.Click += FindMovieButton_Click;
        // 
        // addEditGroupBox
        // 
        addEditGroupBox.Controls.Add(editMovieRadioButton);
        addEditGroupBox.Controls.Add(addMovieRadioButton);
        addEditGroupBox.Location = new Point(20, 12);
        addEditGroupBox.Name = "addEditGroupBox";
        addEditGroupBox.Size = new Size(146, 78);
        addEditGroupBox.TabIndex = 90;
        addEditGroupBox.TabStop = false;
        // 
        // editMovieRadioButton
        // 
        editMovieRadioButton.AutoSize = true;
        editMovieRadioButton.Enabled = false;
        editMovieRadioButton.Location = new Point(0, 43);
        editMovieRadioButton.Name = "editMovieRadioButton";
        editMovieRadioButton.Size = new Size(134, 19);
        editMovieRadioButton.TabIndex = 1;
        editMovieRadioButton.Text = "Изменение фильма";
        editMovieRadioButton.UseVisualStyleBackColor = true;
        editMovieRadioButton.CheckedChanged += MovieRadioButton_CheckedChanged;
        editMovieRadioButton.Click += EditMovieRadioButton_Click;
        // 
        // addMovieRadioButton
        // 
        addMovieRadioButton.AutoSize = true;
        addMovieRadioButton.Checked = true;
        addMovieRadioButton.Location = new Point(0, 18);
        addMovieRadioButton.Name = "addMovieRadioButton";
        addMovieRadioButton.Size = new Size(133, 19);
        addMovieRadioButton.TabIndex = 0;
        addMovieRadioButton.TabStop = true;
        addMovieRadioButton.Text = "Добавление фильм";
        addMovieRadioButton.UseVisualStyleBackColor = true;
        addMovieRadioButton.CheckedChanged += MovieRadioButton_CheckedChanged;
        addMovieRadioButton.Click += AddMovieRadioButton_Click;
        // 
        // movieIdFindLabel
        // 
        movieIdFindLabel.AutoSize = true;
        movieIdFindLabel.Location = new Point(12, 93);
        movieIdFindLabel.Name = "movieIdFindLabel";
        movieIdFindLabel.Size = new Size(209, 15);
        movieIdFindLabel.TabIndex = 91;
        movieIdFindLabel.Text = "Выберите id фильма для изменения:";
        movieIdFindLabel.Visible = false;
        // 
        // removeMovieLabel
        // 
        removeMovieLabel.AutoSize = true;
        removeMovieLabel.Location = new Point(14, 488);
        removeMovieLabel.Name = "removeMovieLabel";
        removeMovieLabel.Size = new Size(133, 15);
        removeMovieLabel.TabIndex = 93;
        removeMovieLabel.Text = "Удаление кинофильма";
        // 
        // movieIdRemoveLabel
        // 
        movieIdRemoveLabel.AutoSize = true;
        movieIdRemoveLabel.Location = new Point(56, 517);
        movieIdRemoveLabel.Name = "movieIdRemoveLabel";
        movieIdRemoveLabel.Size = new Size(20, 15);
        movieIdRemoveLabel.TabIndex = 94;
        movieIdRemoveLabel.Text = "Id:";
        // 
        // removeMovieButton
        // 
        removeMovieButton.Location = new Point(137, 515);
        removeMovieButton.Name = "removeMovieButton";
        removeMovieButton.Size = new Size(104, 23);
        removeMovieButton.TabIndex = 96;
        removeMovieButton.Text = "Удалить";
        removeMovieButton.UseVisualStyleBackColor = true;
        removeMovieButton.Click += RemoveMovieButton_Click;
        // 
        // movieIdNumericUpDown
        // 
        movieIdNumericUpDown.Location = new Point(227, 91);
        movieIdNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        movieIdNumericUpDown.Name = "movieIdNumericUpDown";
        movieIdNumericUpDown.Size = new Size(49, 23);
        movieIdNumericUpDown.TabIndex = 97;
        movieIdNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        movieIdNumericUpDown.Visible = false;
        // 
        // findMovieToEditButton
        // 
        findMovieToEditButton.Location = new Point(282, 91);
        findMovieToEditButton.Name = "findMovieToEditButton";
        findMovieToEditButton.Size = new Size(75, 23);
        findMovieToEditButton.TabIndex = 99;
        findMovieToEditButton.Text = "Найти";
        findMovieToEditButton.UseVisualStyleBackColor = true;
        findMovieToEditButton.Visible = false;
        findMovieToEditButton.Click += FindMovieToEditButton_Click;
        // 
        // movieIdForRemoveNumericUpDown
        // 
        movieIdForRemoveNumericUpDown.Location = new Point(82, 515);
        movieIdForRemoveNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        movieIdForRemoveNumericUpDown.Name = "movieIdForRemoveNumericUpDown";
        movieIdForRemoveNumericUpDown.Size = new Size(49, 23);
        movieIdForRemoveNumericUpDown.TabIndex = 100;
        movieIdForRemoveNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // searchComboBox
        // 
        searchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        searchComboBox.FormattingEnabled = true;
        searchComboBox.Location = new Point(147, 388);
        searchComboBox.Name = "searchComboBox";
        searchComboBox.Size = new Size(121, 23);
        searchComboBox.TabIndex = 101;
        // 
        // searchValueLabel
        // 
        searchValueLabel.AutoSize = true;
        searchValueLabel.Location = new Point(14, 427);
        searchValueLabel.Name = "searchValueLabel";
        searchValueLabel.Size = new Size(127, 15);
        searchValueLabel.TabIndex = 102;
        searchValueLabel.Text = "Значение для поиска:";
        // 
        // MovieCatalogForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(784, 564);
        Controls.Add(searchValueLabel);
        Controls.Add(searchComboBox);
        Controls.Add(movieIdForRemoveNumericUpDown);
        Controls.Add(findMovieToEditButton);
        Controls.Add(movieIdNumericUpDown);
        Controls.Add(removeMovieButton);
        Controls.Add(movieIdRemoveLabel);
        Controls.Add(removeMovieLabel);
        Controls.Add(movieIdFindLabel);
        Controls.Add(addEditGroupBox);
        Controls.Add(searchMovieButton);
        Controls.Add(searchByFieldLabel);
        Controls.Add(searchMoviesLabel);
        Controls.Add(searchTitleTextBox);
        Controls.Add(searchResultsLabel);
        Controls.Add(searchResultsRichTextBox);
        Controls.Add(countryComboBox);
        Controls.Add(sortMoviesButton);
        Controls.Add(sortByLabel);
        Controls.Add(sortComboBox);
        Controls.Add(raitingTrackBar);
        Controls.Add(raitingTextBox);
        Controls.Add(genreComboBox);
        Controls.Add(moviesRichTextBox);
        Controls.Add(addEditMovieButton);
        Controls.Add(titleTextBox);
        Controls.Add(raitingLabel);
        Controls.Add(countryLabel);
        Controls.Add(movieTitleLabel);
        Controls.Add(movieGenreLabel);
        Controls.Add(moviesLabel);
        Controls.Add(movieLabel);
        Name = "MovieCatalogForm";
        Text = "Movie Catalog";
        ((System.ComponentModel.ISupportInitialize)raitingTrackBar).EndInit();
        addEditGroupBox.ResumeLayout(false);
        addEditGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)movieIdNumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)movieIdForRemoveNumericUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label movieLabel;
    private Label movieGenreLabel;
    private Label countryLabel;
    private Label raitingLabel;
    private TextBox titleTextBox;
    private Label movieTitleLabel;
    private Button addEditMovieButton;
    private RichTextBox moviesRichTextBox;
    private ComboBox genreComboBox;
    private TextBox raitingTextBox;
    private TrackBar raitingTrackBar;
    private Label moviesLabel;
    private ComboBox sortComboBox;
    private Label sortByLabel;
    private Button sortMoviesButton;
    private ComboBox countryComboBox;
    private RichTextBox searchResultsRichTextBox;
    private Label searchResultsLabel;
    private TextBox searchTitleTextBox;
    private Label searchMoviesLabel;
    private Label searchByFieldLabel;
    private Button searchMovieButton;
    private GroupBox addEditGroupBox;
    private RadioButton editMovieRadioButton;
    private RadioButton addMovieRadioButton;
    private Label movieIdFindLabel;
    private Label removeMovieLabel;
    private Label movieIdRemoveLabel;
    private Button removeMovieButton;
    private NumericUpDown movieIdNumericUpDown;
    private Button findMovieToEditButton;
    private NumericUpDown movieIdForRemoveNumericUpDown;
    private ComboBox searchComboBox;
    private Label searchValueLabel;
}
