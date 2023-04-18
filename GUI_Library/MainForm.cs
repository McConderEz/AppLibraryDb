using DBLibraryAppCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Library
{
    public partial class MainForm : Form
    {

        string sqlCommand = "SELECT * FROM public.books";
        public MainForm()
        {
            InitializeComponent();
            dgvComponent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComponent.AllowUserToAddRows = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var db = new DBLibraryAppCore.ApplicationContext())
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlCommand, DBLibraryAppCore.ApplicationContext.connectionstring);
                var ds = new DataSet();
                adapter.Fill(ds);
                dgvComponent.DataSource = ds.Tables[0];

            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            LibraryWPF library = new LibraryWPF();
            library.AddBookInDb();
        }

        private void ChangeBookButton_Click(object sender, EventArgs e)
        {
            LibraryWPF library = new LibraryWPF();
            library.Edit();
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            using (var db = new DBLibraryAppCore.ApplicationContext())
            {
                var list = db.books.ToList();
                foreach (DataGridViewRow row in dgvComponent.SelectedRows)
                {
                    db.Remove(db.books.ToList()[row.Index]);
                    dgvComponent.Rows.Remove(row);
                }
                db.SaveChanges();
            }


        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            using (var db = new DBLibraryAppCore.ApplicationContext())
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlCommand, DBLibraryAppCore.ApplicationContext.connectionstring);
                
                var ds = new DataSet();
                adapter.Fill(ds);
                dgvComponent.DataSource = ds.Tables[0];

            }
        }
    }
}
