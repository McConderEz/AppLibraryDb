namespace GUI_Library
{
    partial class AddBookInDB
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
            BookNameTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            PagesCountTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            GenreTextBox = new TextBox();
            label4 = new Label();
            DescriptionTextBox = new TextBox();
            label5 = new Label();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // BookNameTextBox
            // 
            BookNameTextBox.Location = new Point(138, 55);
            BookNameTextBox.Name = "BookNameTextBox";
            BookNameTextBox.Size = new Size(153, 23);
            BookNameTextBox.TabIndex = 0;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(138, 84);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(153, 23);
            AuthorTextBox.TabIndex = 1;
            // 
            // PagesCountTextBox
            // 
            PagesCountTextBox.Location = new Point(138, 113);
            PagesCountTextBox.Name = "PagesCountTextBox";
            PagesCountTextBox.Size = new Size(153, 23);
            PagesCountTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 58);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = "Название книги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 87);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "Имя автора";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 5;
            label3.Text = "Количество страниц";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(138, 142);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(153, 23);
            GenreTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 145);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Жанр книги";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(138, 171);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(153, 52);
            DescriptionTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 171);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 9;
            label5.Text = "Описание книги";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(202, 272);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(89, 23);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddBookInDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 307);
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
            Name = "AddBookInDB";
            Text = "AddBookInDB";
            Load += AddBookInDB_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BookNameTextBox;
        private TextBox AuthorTextBox;
        private TextBox PagesCountTextBox;
        protected Label label1;
        protected Label label2;
        protected Label label3;
        private TextBox GenreTextBox;
        protected Label label4;
        private TextBox DescriptionTextBox;
        protected Label label5;
        private Button SaveButton;
    }
}