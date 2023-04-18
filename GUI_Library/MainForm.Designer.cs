namespace GUI_Library
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            dgvComponent = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pagesCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            AddBookButton = new Button();
            ChangeBookButton = new Button();
            DeleteBookButton = new Button();
            RefreshButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvComponent);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 341);
            panel1.TabIndex = 0;
            // 
            // dgvComponent
            // 
            dgvComponent.AutoGenerateColumns = false;
            dgvComponent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComponent.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, pagesCountDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, genreDataGridViewTextBoxColumn });
            dgvComponent.DataSource = bookBindingSource;
            dgvComponent.Location = new Point(0, 0);
            dgvComponent.Name = "dgvComponent";
            dgvComponent.RowTemplate.Height = 25;
            dgvComponent.Size = new Size(643, 341);
            dgvComponent.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // pagesCountDataGridViewTextBoxColumn
            // 
            pagesCountDataGridViewTextBoxColumn.DataPropertyName = "PagesCount";
            pagesCountDataGridViewTextBoxColumn.HeaderText = "PagesCount";
            pagesCountDataGridViewTextBoxColumn.Name = "pagesCountDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Author";
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(DBLibraryAppCore.Book);
            // 
            // AddBookButton
            // 
            AddBookButton.Location = new Point(12, 470);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(100, 32);
            AddBookButton.TabIndex = 1;
            AddBookButton.Text = "Добавить";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // ChangeBookButton
            // 
            ChangeBookButton.Location = new Point(118, 470);
            ChangeBookButton.Name = "ChangeBookButton";
            ChangeBookButton.Size = new Size(100, 32);
            ChangeBookButton.TabIndex = 2;
            ChangeBookButton.Text = "Изменить";
            ChangeBookButton.UseVisualStyleBackColor = true;
            ChangeBookButton.Click += ChangeBookButton_Click;
            // 
            // DeleteBookButton
            // 
            DeleteBookButton.Location = new Point(224, 470);
            DeleteBookButton.Name = "DeleteBookButton";
            DeleteBookButton.Size = new Size(100, 32);
            DeleteBookButton.TabIndex = 3;
            DeleteBookButton.Text = "Удалить";
            DeleteBookButton.UseVisualStyleBackColor = true;
            DeleteBookButton.Click += DeleteBookButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(330, 470);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(100, 32);
            RefreshButton.TabIndex = 4;
            RefreshButton.Text = "Обновить";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 514);
            Controls.Add(RefreshButton);
            Controls.Add(DeleteBookButton);
            Controls.Add(ChangeBookButton);
            Controls.Add(AddBookButton);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Библиотека";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvComponent;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pagesCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private BindingSource bookBindingSource;
        private Button AddBookButton;
        private Button ChangeBookButton;
        private Button DeleteBookButton;
        private Button RefreshButton;
    }
}