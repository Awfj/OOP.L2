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
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        titleTextBox = new TextBox();
        label5 = new Label();
        movieButton = new Button();
        moviesRichTextBox = new RichTextBox();
        genreComboBox = new ComboBox();
        raitingTextBox = new TextBox();
        raitingTrackBar = new TrackBar();
        label6 = new Label();
        sortComboBox = new ComboBox();
        label7 = new Label();
        SortMoviesButton = new Button();
        countryComboBox = new ComboBox();
        searchResultsRichTextBox = new RichTextBox();
        label8 = new Label();
        searchTitleTextBox = new TextBox();
        label9 = new Label();
        label10 = new Label();
        SearchMovieButton = new Button();
        groupBox1 = new GroupBox();
        editMovieRadioButton = new RadioButton();
        addMovieRadioButton = new RadioButton();
        oldMovieTitleLabel = new Label();
        label1 = new Label();
        label11 = new Label();
        removeMovieButton = new Button();
        movieIdNumericUpDown = new NumericUpDown();
        label12 = new Label();
        findMovieToEditButton = new Button();
        movieIdForRemoveNumericUpDown = new NumericUpDown();
        searchComboBox = new ComboBox();
        label13 = new Label();
        ((System.ComponentModel.ISupportInitialize)raitingTrackBar).BeginInit();
        groupBox1.SuspendLayout();
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
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(33, 200);
        label2.Name = "label2";
        label2.Size = new Size(41, 15);
        label2.TabIndex = 0;
        label2.Text = "Жанр:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(25, 235);
        label3.Name = "label3";
        label3.Size = new Size(49, 15);
        label3.TabIndex = 0;
        label3.Text = "Страна:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(20, 269);
        label4.Name = "label4";
        label4.Size = new Size(54, 15);
        label4.TabIndex = 0;
        label4.Text = "Рейтинг:";
        // 
        // titleTextBox
        // 
        titleTextBox.Location = new Point(80, 162);
        titleTextBox.Name = "titleTextBox";
        titleTextBox.Size = new Size(145, 23);
        titleTextBox.TabIndex = 1;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(12, 165);
        label5.Name = "label5";
        label5.Size = new Size(62, 15);
        label5.TabIndex = 0;
        label5.Text = "Название:";
        // 
        // movieButton
        // 
        movieButton.Location = new Point(80, 320);
        movieButton.Name = "movieButton";
        movieButton.Size = new Size(104, 23);
        movieButton.TabIndex = 5;
        movieButton.Text = "Добавить";
        movieButton.UseVisualStyleBackColor = true;
        movieButton.Click += AddMovieButton_Click;
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
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(403, 35);
        label6.Name = "label6";
        label6.Size = new Size(82, 15);
        label6.TabIndex = 0;
        label6.Text = "Кинофильмы";
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
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(401, 226);
        label7.Name = "label7";
        label7.Size = new Size(98, 15);
        label7.TabIndex = 82;
        label7.Text = "Сортировать по:";
        // 
        // SortMoviesButton
        // 
        SortMoviesButton.Location = new Point(632, 223);
        SortMoviesButton.Name = "SortMoviesButton";
        SortMoviesButton.Size = new Size(97, 23);
        SortMoviesButton.TabIndex = 83;
        SortMoviesButton.Text = "Сортировать";
        SortMoviesButton.UseVisualStyleBackColor = true;
        SortMoviesButton.Click += SortMoviesButton_Click;
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
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(403, 274);
        label8.Name = "label8";
        label8.Size = new Size(111, 15);
        label8.TabIndex = 85;
        label8.Text = "Результаты поиска";
        // 
        // searchTitleTextBox
        // 
        searchTitleTextBox.Location = new Point(147, 424);
        searchTitleTextBox.Name = "searchTitleTextBox";
        searchTitleTextBox.Size = new Size(145, 23);
        searchTitleTextBox.TabIndex = 86;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(12, 361);
        label9.Name = "label9";
        label9.Size = new Size(123, 15);
        label9.TabIndex = 87;
        label9.Text = "Поиск кинофильмов";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(45, 391);
        label10.Name = "label10";
        label10.Size = new Size(96, 15);
        label10.TabIndex = 88;
        label10.Text = "Поиск по полю:";
        // 
        // SearchMovieButton
        // 
        SearchMovieButton.Location = new Point(147, 453);
        SearchMovieButton.Name = "SearchMovieButton";
        SearchMovieButton.Size = new Size(104, 23);
        SearchMovieButton.TabIndex = 89;
        SearchMovieButton.Text = "Найти";
        SearchMovieButton.UseVisualStyleBackColor = true;
        SearchMovieButton.Click += FindMovieButton_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(editMovieRadioButton);
        groupBox1.Controls.Add(addMovieRadioButton);
        groupBox1.Location = new Point(20, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(146, 78);
        groupBox1.TabIndex = 90;
        groupBox1.TabStop = false;
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
        // oldMovieTitleLabel
        // 
        oldMovieTitleLabel.AutoSize = true;
        oldMovieTitleLabel.Location = new Point(12, 93);
        oldMovieTitleLabel.Name = "oldMovieTitleLabel";
        oldMovieTitleLabel.Size = new Size(209, 15);
        oldMovieTitleLabel.TabIndex = 91;
        oldMovieTitleLabel.Text = "Выберите id фильма для изменения:";
        oldMovieTitleLabel.Visible = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(14, 488);
        label1.Name = "label1";
        label1.Size = new Size(133, 15);
        label1.TabIndex = 93;
        label1.Text = "Удаление кинофильма";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(56, 517);
        label11.Name = "label11";
        label11.Size = new Size(20, 15);
        label11.TabIndex = 94;
        label11.Text = "Id:";
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
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(89, 123);
        label12.Name = "label12";
        label12.Size = new Size(0, 15);
        label12.TabIndex = 98;
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
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(14, 427);
        label13.Name = "label13";
        label13.Size = new Size(127, 15);
        label13.TabIndex = 102;
        label13.Text = "Значение для поиска:";
        // 
        // MovieCatalogForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(784, 564);
        Controls.Add(label13);
        Controls.Add(searchComboBox);
        Controls.Add(movieIdForRemoveNumericUpDown);
        Controls.Add(findMovieToEditButton);
        Controls.Add(label12);
        Controls.Add(movieIdNumericUpDown);
        Controls.Add(removeMovieButton);
        Controls.Add(label11);
        Controls.Add(label1);
        Controls.Add(oldMovieTitleLabel);
        Controls.Add(groupBox1);
        Controls.Add(SearchMovieButton);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(searchTitleTextBox);
        Controls.Add(label8);
        Controls.Add(searchResultsRichTextBox);
        Controls.Add(countryComboBox);
        Controls.Add(SortMoviesButton);
        Controls.Add(label7);
        Controls.Add(sortComboBox);
        Controls.Add(raitingTrackBar);
        Controls.Add(raitingTextBox);
        Controls.Add(genreComboBox);
        Controls.Add(moviesRichTextBox);
        Controls.Add(movieButton);
        Controls.Add(titleTextBox);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label5);
        Controls.Add(label2);
        Controls.Add(label6);
        Controls.Add(movieLabel);
        Name = "MovieCatalogForm";
        Text = "Movie Catalog";
        ((System.ComponentModel.ISupportInitialize)raitingTrackBar).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)movieIdNumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)movieIdForRemoveNumericUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label movieLabel;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox titleTextBox;
    private Label label5;
    private Button movieButton;
    private RichTextBox moviesRichTextBox;
    private ComboBox genreComboBox;
    private TextBox raitingTextBox;
    private TrackBar raitingTrackBar;
    private Label label6;
    private ComboBox sortComboBox;
    private Label label7;
    private Button SortMoviesButton;
    private ComboBox countryComboBox;
    private RichTextBox searchResultsRichTextBox;
    private Label label8;
    private TextBox searchTitleTextBox;
    private Label label9;
    private Label label10;
    private Button SearchMovieButton;
    private GroupBox groupBox1;
    private RadioButton editMovieRadioButton;
    private RadioButton addMovieRadioButton;
    private Label oldMovieTitleLabel;
    private Label label1;
    private Label label11;
    private Button removeMovieButton;
    private NumericUpDown movieIdNumericUpDown;
    private Label label12;
    private Button findMovieToEditButton;
    private NumericUpDown movieIdForRemoveNumericUpDown;
    private ComboBox searchComboBox;
    private Label label13;
}
