using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Library
{
    public partial class AddBookInDB : Form
    {
        public AddBookInDB()
        {
            InitializeComponent();
        }

        private void AddBookInDB_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string title = BookNameTextBox.Text;
            string author = AuthorTextBox.Text;
            string description = DescriptionTextBox.Text;
            string genre = GenreTextBox.Text;
            int pagesCount = int.Parse(PagesCountTextBox.Text);

            using(var db = new DBLibraryAppCore.ApplicationContext())
            {
                db.books.Add(new DBLibraryAppCore.Book
                {
                    Title = title,
                    Author = author,
                    Description = description,
                    Genre = genre,
                    PagesCount = pagesCount,
                });              
                db.SaveChanges();
            }
            this.Close();

        }
    }
}
