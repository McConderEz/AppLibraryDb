using DBLibraryAppCore;
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
    public partial class ChangeBookForm : Form
    {
        public ChangeBookForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdTextBox.Text);
            string title = BookNameTextBox.Text;
            string author = AuthorTextBox.Text;
            string description = DescriptionTextBox.Text;
            string genre = GenreTextBox.Text;
            int pagesCount = int.Parse(PagesCountTextBox.Text);

            using (var db = new DBLibraryAppCore.ApplicationContext())
            {
                if (db.books.Count() != 0 && id > 0 && id <= db.books.Count())
                {

                    Book? book = db.books.ToArray()[id - 1];

                    if (book != null)
                    {
                        book.Title = title;
                        book.Author = author;
                        book.Description = description;
                        book.Genre = genre;
                        book.PagesCount = pagesCount;

                        db.Update(book);
                        db.SaveChanges();
                    }
                }
            }

            this.Close();
        }
    }
}
