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
        usersRichTextBox = new RichTextBox();
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
        label3 = new Label();
        notificationsRichTextBox = new RichTextBox();
        label4 = new Label();
        ((System.ComponentModel.ISupportInitialize)raitingTrackBar).BeginInit();
        addEditGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)movieIdNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)movieIdForRemoveNumericUpDown).BeginInit();
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
        moviesRichTextBox.Location = new Point(404, 41);
        moviesRichTextBox.Name = "moviesRichTextBox";
        moviesRichTextBox.ReadOnly = true;
        moviesRichTextBox.Size = new Size(364, 73);
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
        moviesLabel.Location = new Point(405, 14);
        moviesLabel.Name = "moviesLabel";
        moviesLabel.Size = new Size(82, 15);
        moviesLabel.TabIndex = 0;
        moviesLabel.Text = "Кинофильмы";
        // 
        // sortComboBox
        // 
        sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        sortComboBox.FormattingEnabled = true;
        sortComboBox.Location = new Point(508, 120);
        sortComboBox.Name = "sortComboBox";
        sortComboBox.Size = new Size(121, 23);
        sortComboBox.TabIndex = 81;
        // 
        // sortByLabel
        // 
        sortByLabel.AutoSize = true;
        sortByLabel.Location = new Point(404, 123);
        sortByLabel.Name = "sortByLabel";
        sortByLabel.Size = new Size(98, 15);
        sortByLabel.TabIndex = 82;
        sortByLabel.Text = "Сортировать по:";
        // 
        // sortMoviesButton
        // 
        sortMoviesButton.Location = new Point(635, 120);
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
        searchResultsRichTextBox.Location = new Point(404, 176);
        searchResultsRichTextBox.Name = "searchResultsRichTextBox";
        searchResultsRichTextBox.ReadOnly = true;
        searchResultsRichTextBox.Size = new Size(364, 52);
        searchResultsRichTextBox.TabIndex = 84;
        searchResultsRichTextBox.Text = "";
        // 
        // usersRichTextBox
        // 
        usersRichTextBox.Location = new Point(404, 361);
        usersRichTextBox.Name = "usersRichTextBox";
        usersRichTextBox.ReadOnly = true;
        usersRichTextBox.Size = new Size(368, 52);
        usersRichTextBox.TabIndex = 84;
        usersRichTextBox.Text = "";
        // 
        // searchResultsLabel
        // 
        searchResultsLabel.AutoSize = true;
        searchResultsLabel.Location = new Point(404, 149);
        searchResultsLabel.Name = "searchResultsLabel";
        searchResultsLabel.Size = new Size(111, 15);
        searchResultsLabel.TabIndex = 85;
        searchResultsLabel.Text = "Результаты поиска";
        // 
        // searchTitleTextBox
        // 
        searchTitleTextBox.Location = new Point(143, 424);
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
        searchByFieldLabel.Location = new Point(41, 391);
        searchByFieldLabel.Name = "searchByFieldLabel";
        searchByFieldLabel.Size = new Size(96, 15);
        searchByFieldLabel.TabIndex = 88;
        searchByFieldLabel.Text = "Поиск по полю:";
        // 
        // searchMovieButton
        // 
        searchMovieButton.Location = new Point(143, 453);
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
        movieIdFindLabel.Size = new Size(210, 15);
        movieIdFindLabel.TabIndex = 91;
        movieIdFindLabel.Text = "Выберите ID фильма для изменения:";
        movieIdFindLabel.Visible = false;
        // 
        // removeMovieLabel
        // 
        removeMovieLabel.AutoSize = true;
        removeMovieLabel.Location = new Point(10, 488);
        removeMovieLabel.Name = "removeMovieLabel";
        removeMovieLabel.Size = new Size(133, 15);
        removeMovieLabel.TabIndex = 93;
        removeMovieLabel.Text = "Удаление кинофильма";
        // 
        // movieIdRemoveLabel
        // 
        movieIdRemoveLabel.AutoSize = true;
        movieIdRemoveLabel.Location = new Point(52, 517);
        movieIdRemoveLabel.Name = "movieIdRemoveLabel";
        movieIdRemoveLabel.Size = new Size(20, 15);
        movieIdRemoveLabel.TabIndex = 94;
        movieIdRemoveLabel.Text = "Id:";
        // 
        // removeMovieButton
        // 
        removeMovieButton.Location = new Point(133, 515);
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
        movieIdForRemoveNumericUpDown.Location = new Point(78, 515);
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
        searchComboBox.Location = new Point(143, 388);
        searchComboBox.Name = "searchComboBox";
        searchComboBox.Size = new Size(121, 23);
        searchComboBox.TabIndex = 101;
        // 
        // searchValueLabel
        // 
        searchValueLabel.AutoSize = true;
        searchValueLabel.Location = new Point(10, 427);
        searchValueLabel.Name = "searchValueLabel";
        searchValueLabel.Size = new Size(127, 15);
        searchValueLabel.TabIndex = 102;
        searchValueLabel.Text = "Значение для поиска:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(442, 432);
        label1.Name = "label1";
        label1.Size = new Size(152, 15);
        label1.TabIndex = 100;
        label1.Text = "Добавление пользователя";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(402, 465);
        label2.Name = "label2";
        label2.Size = new Size(34, 15);
        label2.TabIndex = 101;
        label2.Text = "Имя:";
        // 
        // userNameTextBox
        // 
        userNameTextBox.Location = new Point(442, 462);
        userNameTextBox.Name = "userNameTextBox";
        userNameTextBox.Size = new Size(145, 23);
        userNameTextBox.TabIndex = 102;
        // 
        // AddUserButton
        // 
        AddUserButton.Location = new Point(593, 462);
        AddUserButton.Name = "AddUserButton";
        AddUserButton.Size = new Size(104, 23);
        AddUserButton.TabIndex = 103;
        AddUserButton.Text = "Добавить";
        AddUserButton.UseVisualStyleBackColor = true;
        AddUserButton.Click += CteateUserButton_Click;
        // 
        // userIDNumericUpDown
        // 
        userIDNumericUpDown.Location = new Point(578, 504);
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
        userIDLabel.Location = new Point(402, 535);
        userIDLabel.Name = "userIDLabel";
        userIDLabel.Size = new Size(170, 15);
        userIDLabel.TabIndex = 105;
        userIDLabel.Text = "ID выбранного пользователя:";
        userIDLabel.Visible = false;
        // 
        // userIDTextBox
        // 
        userIDTextBox.Location = new Point(578, 532);
        userIDTextBox.Name = "userIDTextBox";
        userIDTextBox.ReadOnly = true;
        userIDTextBox.Size = new Size(33, 23);
        userIDTextBox.TabIndex = 106;
        userIDTextBox.Visible = false;
        // 
        // chooseUseIDLabel
        // 
        chooseUseIDLabel.AutoSize = true;
        chooseUseIDLabel.Location = new Point(402, 506);
        chooseUseIDLabel.Name = "chooseUseIDLabel";
        chooseUseIDLabel.Size = new Size(173, 15);
        chooseUseIDLabel.TabIndex = 107;
        chooseUseIDLabel.Text = "Выберите пользователя по ID:";
        chooseUseIDLabel.Visible = false;
        // 
        // selectUserButton
        // 
        selectUserButton.Location = new Point(633, 504);
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
        subscriptionLabel.Location = new Point(402, 573);
        subscriptionLabel.Name = "subscriptionLabel";
        subscriptionLabel.Size = new Size(150, 15);
        subscriptionLabel.TabIndex = 109;
        subscriptionLabel.Text = "Информации о новинках:";
        subscriptionLabel.Visible = false;
        // 
        // subscribeButton
        // 
        subscribeButton.Location = new Point(558, 569);
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
        unsubscribeButton.Location = new Point(652, 569);
        unsubscribeButton.Name = "unsubscribeButton";
        unsubscribeButton.Size = new Size(89, 23);
        unsubscribeButton.TabIndex = 111;
        unsubscribeButton.Text = "Отписаться";
        unsubscribeButton.UseVisualStyleBackColor = true;
        unsubscribeButton.Visible = false;
        unsubscribeButton.Click += UnsubscribeButton_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(404, 242);
        label3.Name = "label3";
        label3.Size = new Size(79, 15);
        label3.TabIndex = 113;
        label3.Text = "Оповещения";
        // 
        // notificationsRichTextBox
        // 
        notificationsRichTextBox.Location = new Point(404, 266);
        notificationsRichTextBox.Name = "notificationsRichTextBox";
        notificationsRichTextBox.ReadOnly = true;
        notificationsRichTextBox.Size = new Size(364, 58);
        notificationsRichTextBox.TabIndex = 112;
        notificationsRichTextBox.Text = "";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(404, 339);
        label4.Name = "label4";
        label4.Size = new Size(85, 15);
        label4.TabIndex = 114;
        label4.Text = "Пользователи";
        // 
        // MovieCatalogForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(787, 610);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(notificationsRichTextBox);
        Controls.Add(searchValueLabel);
        Controls.Add(searchComboBox);
        Controls.Add(movieIdForRemoveNumericUpDown);
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
        ((System.ComponentModel.ISupportInitialize)movieIdForRemoveNumericUpDown).EndInit();
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
    private RichTextBox searchResultsRichTextBox;
    private RichTextBox usersRichTextBox;
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
    private Label label3;
    private RichTextBox notificationsRichTextBox;
    private Label label4;
}
