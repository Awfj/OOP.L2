﻿namespace OOP.L2;

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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        titleTextBox = new TextBox();
        label5 = new Label();
        AddMovieButton = new Button();
        moviesRichTextBox = new RichTextBox();
        ShowMoviesButton = new Button();
        genreComboBox = new ComboBox();
        raitingTextBox = new TextBox();
        RaitingTrackBar = new TrackBar();
        label6 = new Label();
        sortComboBox = new ComboBox();
        label7 = new Label();
        SortMoviesButton = new Button();
        countryComboBox = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)RaitingTrackBar).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(14, 17);
        label1.Name = "label1";
        label1.Size = new Size(213, 15);
        label1.TabIndex = 0;
        label1.Text = "Введите информацию о кинофильме";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(35, 85);
        label2.Name = "label2";
        label2.Size = new Size(41, 15);
        label2.TabIndex = 0;
        label2.Text = "Жанр:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(27, 120);
        label3.Name = "label3";
        label3.Size = new Size(49, 15);
        label3.TabIndex = 0;
        label3.Text = "Страна:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(22, 154);
        label4.Name = "label4";
        label4.Size = new Size(54, 15);
        label4.TabIndex = 0;
        label4.Text = "Рейтинг:";
        // 
        // titleTextBox
        // 
        titleTextBox.Location = new Point(82, 47);
        titleTextBox.Name = "titleTextBox";
        titleTextBox.Size = new Size(145, 23);
        titleTextBox.TabIndex = 1;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(14, 50);
        label5.Name = "label5";
        label5.Size = new Size(62, 15);
        label5.TabIndex = 0;
        label5.Text = "Название:";
        // 
        // AddMovieButton
        // 
        AddMovieButton.Location = new Point(82, 205);
        AddMovieButton.Name = "AddMovieButton";
        AddMovieButton.Size = new Size(135, 23);
        AddMovieButton.TabIndex = 5;
        AddMovieButton.Text = "Добавить кинофильм";
        AddMovieButton.UseVisualStyleBackColor = true;
        AddMovieButton.Click += AddMovieButton_Click;
        // 
        // moviesRichTextBox
        // 
        moviesRichTextBox.Location = new Point(269, 47);
        moviesRichTextBox.Name = "moviesRichTextBox";
        moviesRichTextBox.ReadOnly = true;
        moviesRichTextBox.Size = new Size(364, 144);
        moviesRichTextBox.TabIndex = 50;
        moviesRichTextBox.Text = "";
        // 
        // ShowMoviesButton
        // 
        ShowMoviesButton.Location = new Point(269, 197);
        ShowMoviesButton.Name = "ShowMoviesButton";
        ShowMoviesButton.Size = new Size(147, 23);
        ShowMoviesButton.TabIndex = 6;
        ShowMoviesButton.Text = "Показать кинофильмы";
        ShowMoviesButton.UseVisualStyleBackColor = true;
        ShowMoviesButton.Click += ShowMoviesButton_Click;
        // 
        // genreComboBox
        // 
        genreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        genreComboBox.FormattingEnabled = true;
        genreComboBox.Location = new Point(82, 82);
        genreComboBox.Name = "genreComboBox";
        genreComboBox.Size = new Size(145, 23);
        genreComboBox.TabIndex = 2;
        // 
        // raitingTextBox
        // 
        raitingTextBox.Location = new Point(192, 154);
        raitingTextBox.Name = "raitingTextBox";
        raitingTextBox.ReadOnly = true;
        raitingTextBox.Size = new Size(25, 23);
        raitingTextBox.TabIndex = 80;
        raitingTextBox.Text = "1";
        // 
        // RaitingTrackBar
        // 
        RaitingTrackBar.Location = new Point(82, 154);
        RaitingTrackBar.Maximum = 100;
        RaitingTrackBar.Minimum = 1;
        RaitingTrackBar.Name = "RaitingTrackBar";
        RaitingTrackBar.Size = new Size(104, 45);
        RaitingTrackBar.TabIndex = 4;
        RaitingTrackBar.Value = 1;
        RaitingTrackBar.ValueChanged += RaitingTrackBar_ValueChanged;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(269, 17);
        label6.Name = "label6";
        label6.Size = new Size(82, 15);
        label6.TabIndex = 0;
        label6.Text = "Кинофильмы";
        // 
        // sortComboBox
        // 
        sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        sortComboBox.FormattingEnabled = true;
        sortComboBox.Location = new Point(180, 317);
        sortComboBox.Name = "sortComboBox";
        sortComboBox.Size = new Size(121, 23);
        sortComboBox.TabIndex = 81;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(76, 320);
        label7.Name = "label7";
        label7.Size = new Size(98, 15);
        label7.TabIndex = 82;
        label7.Text = "Сортировать по:";
        // 
        // SortMoviesButton
        // 
        SortMoviesButton.Location = new Point(180, 346);
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
        countryComboBox.Location = new Point(82, 117);
        countryComboBox.Name = "countryComboBox";
        countryComboBox.Size = new Size(145, 23);
        countryComboBox.TabIndex = 3;
        // 
        // MovieCatalogForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(countryComboBox);
        Controls.Add(SortMoviesButton);
        Controls.Add(label7);
        Controls.Add(sortComboBox);
        Controls.Add(RaitingTrackBar);
        Controls.Add(raitingTextBox);
        Controls.Add(genreComboBox);
        Controls.Add(ShowMoviesButton);
        Controls.Add(moviesRichTextBox);
        Controls.Add(AddMovieButton);
        Controls.Add(titleTextBox);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label5);
        Controls.Add(label2);
        Controls.Add(label6);
        Controls.Add(label1);
        Name = "MovieCatalogForm";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)RaitingTrackBar).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox titleTextBox;
    private Label label5;
    private Button AddMovieButton;
    private RichTextBox moviesRichTextBox;
    private Button ShowMoviesButton;
    private ComboBox genreComboBox;
    private TextBox raitingTextBox;
    private TrackBar RaitingTrackBar;
    private Label label6;
    private ComboBox sortComboBox;
    private Label label7;
    private Button SortMoviesButton;
    private ComboBox countryComboBox;
}