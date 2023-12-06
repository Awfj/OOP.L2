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
        usersRichTextBox = new RichTextBox();
        searchResultsLabel = new Label();
        addEditGroupBox = new GroupBox();
        editMovieRadioButton = new RadioButton();
        addMovieRadioButton = new RadioButton();
        movieIdFindLabel = new Label();
        movieIdNumericUpDown = new NumericUpDown();
        findMovieToEditButton = new Button();
        label1 = new Label();
        label2 = new Label();
        userNameTextBox = new TextBox();
        AddUserButton = new Button();
        userIDNumericUpDown = new NumericUpDown();
        userIDLabel = new Label();
        userIDTextBox = new TextBox();
        chooseUseIDLabel = new Label();
        selectUserButton = new Button();
        subscriptionLabel = new Label();
        subscribeButton = new Button();
        unsubscribeButton = new Button();
        ((System.ComponentModel.ISupportInitialize)raitingTrackBar).BeginInit();
        addEditGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)movieIdNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)userIDNumericUpDown).BeginInit();
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
        // usersRichTextBox
        // 
        usersRichTextBox.Location = new Point(403, 301);
        usersRichTextBox.Name = "usersRichTextBox";
        usersRichTextBox.ReadOnly = true;
        usersRichTextBox.Size = new Size(364, 86);
        usersRichTextBox.TabIndex = 84;
        usersRichTextBox.Text = "";
        // 
        // searchResultsLabel
        // 
        searchResultsLabel.AutoSize = true;
        searchResultsLabel.Location = new Point(403, 274);
        searchResultsLabel.Name = "searchResultsLabel";
        searchResultsLabel.Size = new Size(85, 15);
        searchResultsLabel.TabIndex = 85;
        searchResultsLabel.Text = "Пользователи";
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
        movieIdFindLabel.Size = new Size(210, 15);
        movieIdFindLabel.TabIndex = 91;
        movieIdFindLabel.Text = "Выберите ID фильма для изменения:";
        movieIdFindLabel.Visible = false;
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
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(80, 389);
        label1.Name = "label1";
        label1.Size = new Size(152, 15);
        label1.TabIndex = 100;
        label1.Text = "Добавление пользователя";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(40, 410);
        label2.Name = "label2";
        label2.Size = new Size(34, 15);
        label2.TabIndex = 101;
        label2.Text = "Имя:";
        // 
        // userNameTextBox
        // 
        userNameTextBox.Location = new Point(80, 407);
        userNameTextBox.Name = "userNameTextBox";
        userNameTextBox.Size = new Size(145, 23);
        userNameTextBox.TabIndex = 102;
        // 
        // AddUserButton
        // 
        AddUserButton.Location = new Point(80, 436);
        AddUserButton.Name = "AddUserButton";
        AddUserButton.Size = new Size(104, 23);
        AddUserButton.TabIndex = 103;
        AddUserButton.Text = "Добавить";
        AddUserButton.UseVisualStyleBackColor = true;
        AddUserButton.Click += CteateUserButton_Click;
        // 
        // userIDNumericUpDown
        // 
        userIDNumericUpDown.Location = new Point(188, 477);
        userIDNumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
        userIDNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        userIDNumericUpDown.Name = "userIDNumericUpDown";
        userIDNumericUpDown.Size = new Size(49, 23);
        userIDNumericUpDown.TabIndex = 104;
        userIDNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        userIDNumericUpDown.Visible = false;
        // 
        // userIDLabel
        // 
        userIDLabel.AutoSize = true;
        userIDLabel.Location = new Point(12, 508);
        userIDLabel.Name = "userIDLabel";
        userIDLabel.Size = new Size(170, 15);
        userIDLabel.TabIndex = 105;
        userIDLabel.Text = "ID выбранного пользователя:";
        userIDLabel.Visible = false;
        // 
        // userIDTextBox
        // 
        userIDTextBox.Location = new Point(188, 505);
        userIDTextBox.Name = "userIDTextBox";
        userIDTextBox.ReadOnly = true;
        userIDTextBox.Size = new Size(33, 23);
        userIDTextBox.TabIndex = 106;
        userIDTextBox.Visible = false;
        // 
        // chooseUseIDLabel
        // 
        chooseUseIDLabel.AutoSize = true;
        chooseUseIDLabel.Location = new Point(12, 479);
        chooseUseIDLabel.Name = "chooseUseIDLabel";
        chooseUseIDLabel.Size = new Size(173, 15);
        chooseUseIDLabel.TabIndex = 107;
        chooseUseIDLabel.Text = "Выберите пользователя по ID:";
        chooseUseIDLabel.Visible = false;
        // 
        // selectUserButton
        // 
        selectUserButton.Location = new Point(243, 477);
        selectUserButton.Name = "selectUserButton";
        selectUserButton.Size = new Size(75, 23);
        selectUserButton.TabIndex = 108;
        selectUserButton.Text = "Выбрать";
        selectUserButton.UseVisualStyleBackColor = true;
        selectUserButton.Visible = false;
        selectUserButton.Click += SelectUserButton_Click;
        // 
        // subscriptionLabel
        // 
        subscriptionLabel.AutoSize = true;
        subscriptionLabel.Location = new Point(12, 540);
        subscriptionLabel.Name = "subscriptionLabel";
        subscriptionLabel.Size = new Size(284, 15);
        subscriptionLabel.TabIndex = 109;
        subscriptionLabel.Text = "Подписка на получение информации о новинках:";
        subscriptionLabel.Visible = false;
        // 
        // subscribeButton
        // 
        subscribeButton.Location = new Point(302, 536);
        subscribeButton.Name = "subscribeButton";
        subscribeButton.Size = new Size(89, 23);
        subscribeButton.TabIndex = 110;
        subscribeButton.Text = "Подписаться";
        subscribeButton.UseVisualStyleBackColor = true;
        subscribeButton.Visible = false;
        subscribeButton.Click += SubscribeButton_Click;
        // 
        // unsubscribeButton
        // 
        unsubscribeButton.Enabled = false;
        unsubscribeButton.Location = new Point(396, 536);
        unsubscribeButton.Name = "unsubscribeButton";
        unsubscribeButton.Size = new Size(89, 23);
        unsubscribeButton.TabIndex = 111;
        unsubscribeButton.Text = "Отписаться";
        unsubscribeButton.UseVisualStyleBackColor = true;
        unsubscribeButton.Visible = false;
        unsubscribeButton.Click += UnsubscribeButton_Click;
        // 
        // MovieCatalogForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(784, 564);
        Controls.Add(unsubscribeButton);
        Controls.Add(subscribeButton);
        Controls.Add(subscriptionLabel);
        Controls.Add(selectUserButton);
        Controls.Add(chooseUseIDLabel);
        Controls.Add(userIDTextBox);
        Controls.Add(userIDLabel);
        Controls.Add(userIDNumericUpDown);
        Controls.Add(AddUserButton);
        Controls.Add(userNameTextBox);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(findMovieToEditButton);
        Controls.Add(movieIdNumericUpDown);
        Controls.Add(movieIdFindLabel);
        Controls.Add(addEditGroupBox);
        Controls.Add(searchResultsLabel);
        Controls.Add(usersRichTextBox);
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
        ((System.ComponentModel.ISupportInitialize)userIDNumericUpDown).EndInit();
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
    private RichTextBox usersRichTextBox;
    private Label searchResultsLabel;
    private GroupBox addEditGroupBox;
    private RadioButton editMovieRadioButton;
    private RadioButton addMovieRadioButton;
    private Label movieIdFindLabel;
    private NumericUpDown movieIdNumericUpDown;
    private Button findMovieToEditButton;
    private Label label1;
    private Label label2;
    private TextBox userNameTextBox;
    private Button AddUserButton;
    private NumericUpDown userIDNumericUpDown;
    private Label userIDLabel;
    private TextBox userIDTextBox;
    private Label chooseUseIDLabel;
    private Button selectUserButton;
    private Label subscriptionLabel;
    private Button subscribeButton;
    private Button unsubscribeButton;
}
