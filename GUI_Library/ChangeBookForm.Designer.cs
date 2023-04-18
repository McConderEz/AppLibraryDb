namespace GUI_Library
{
    partial class ChangeBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SaveButton = new Button();
            label5 = new Label();
            DescriptionTextBox = new TextBox();
            label4 = new Label();
            GenreTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PagesCountTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            BookNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(215, 286);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(89, 23);
            SaveButton.TabIndex = 21;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 185);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 20;
            label5.Text = "Описание книги";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(151, 185);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(153, 52);
            DescriptionTextBox.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 159);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 18;
            label4.Text = "Жанр книги";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(151, 156);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(153, 23);
            GenreTextBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 130);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 16;
            label3.Text = "Количество страниц";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 101);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 15;
            label2.Text = "Имя автора";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 72);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 14;
            label1.Text = "Название книги";
            // 
            // PagesCountTextBox
            // 
            PagesCountTextBox.Location = new Point(151, 127);
            PagesCountTextBox.Name = "PagesCountTextBox";
            PagesCountTextBox.Size = new Size(153, 23);
            PagesCountTextBox.TabIndex = 13;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(151, 98);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(153, 23);
            AuthorTextBox.TabIndex = 12;
            // 
            // BookNameTextBox
            // 
            BookNameTextBox.Location = new Point(151, 69);
            BookNameTextBox.Name = "BookNameTextBox";
            BookNameTextBox.Size = new Size(153, 23);
            BookNameTextBox.TabIndex = 11;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(151, 40);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(153, 23);
            IdTextBox.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 43);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 23;
            label6.Text = "Id книги";
            // 
            // ChangeBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 332);
            Controls.Add(label6);
            Controls.Add(IdTextBox);
            Controls.Add(SaveButton);
            Controls.Add(label5);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label4);
            Controls.Add(GenreTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PagesCountTextBox);
            Controls.Add(AuthorTextBox);
            Controls.Add(BookNameTextBox);
            Name = "ChangeBookForm";
            Text = "ChangeBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        protected Label label5;
        private TextBox DescriptionTextBox;
        protected Label label4;
        private TextBox GenreTextBox;
        protected Label label3;
        protected Label label2;
        protected Label label1;
        private TextBox PagesCountTextBox;
        private TextBox AuthorTextBox;
        private TextBox BookNameTextBox;
        private TextBox IdTextBox;
        protected Label label6;
    }
}