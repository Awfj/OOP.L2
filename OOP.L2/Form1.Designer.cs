namespace OOP.L2;

partial class Form1
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
        UpDownRaiting = new DomainUpDown();
        TextBoxTitle = new TextBox();
        label5 = new Label();
        TextBoxGenre = new TextBox();
        TextBoxCountry = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(90, 20);
        label1.Name = "label1";
        label1.Size = new Size(213, 15);
        label1.TabIndex = 0;
        label1.Text = "Введите информацию о кинофильме";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(111, 88);
        label2.Name = "label2";
        label2.Size = new Size(41, 15);
        label2.TabIndex = 0;
        label2.Text = "Жанр:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(103, 123);
        label3.Name = "label3";
        label3.Size = new Size(49, 15);
        label3.TabIndex = 0;
        label3.Text = "Страна:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(98, 157);
        label4.Name = "label4";
        label4.Size = new Size(54, 15);
        label4.TabIndex = 0;
        label4.Text = "Рейтинг:";
        // 
        // UpDownRaiting
        // 
        UpDownRaiting.Location = new Point(158, 155);
        UpDownRaiting.Name = "UpDownRaiting";
        UpDownRaiting.Size = new Size(43, 23);
        UpDownRaiting.TabIndex = 2;
        UpDownRaiting.Text = "100";
        // 
        // TextBoxTitle
        // 
        TextBoxTitle.Location = new Point(158, 50);
        TextBoxTitle.Name = "TextBoxTitle";
        TextBoxTitle.Size = new Size(145, 23);
        TextBoxTitle.TabIndex = 3;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(90, 53);
        label5.Name = "label5";
        label5.Size = new Size(62, 15);
        label5.TabIndex = 0;
        label5.Text = "Название:";
        // 
        // TextBoxGenre
        // 
        TextBoxGenre.Location = new Point(158, 85);
        TextBoxGenre.Name = "TextBoxGenre";
        TextBoxGenre.Size = new Size(145, 23);
        TextBoxGenre.TabIndex = 3;
        // 
        // TextBoxCountry
        // 
        TextBoxCountry.Location = new Point(158, 120);
        TextBoxCountry.Name = "TextBoxCountry";
        TextBoxCountry.Size = new Size(145, 23);
        TextBoxCountry.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(TextBoxCountry);
        Controls.Add(TextBoxGenre);
        Controls.Add(TextBoxTitle);
        Controls.Add(UpDownRaiting);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label5);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private DomainUpDown UpDownRaiting;
    private TextBox TextBoxTitle;
    private Label label5;
    private TextBox TextBoxGenre;
    private TextBox TextBoxCountry;
}
