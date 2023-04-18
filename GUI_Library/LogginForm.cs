using DBLibraryAppCore;
using Npgsql;
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
    public partial class LogginForm : Form
    {
        public LogginForm()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoggInButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passField.Text;

            //var db = new NpgsqlConnection(DBLibraryAppCore.ApplicationContext.connectionstring);
            //db.Open();

            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM public.users WHERE 'Login' =  @lU AND 'Password' = @pU", new NpgsqlConnection(DBLibraryAppCore.ApplicationContext.connectionstring));
            npgsqlCommand.Connection.Open();
            npgsqlCommand.Parameters.Add("@lU", NpgsqlTypes.NpgsqlDbType.Varchar).Value = loginUser;
            npgsqlCommand.Parameters.Add("@pU", NpgsqlTypes.NpgsqlDbType.Varchar).Value = passwordUser;

            var db = new DBLibraryAppCore.ApplicationContext();
            var list = db.users.Where(x => x.Login == loginUser && x.Password == passwordUser).ToList();




            if (list.Count > 0)
            {
                MessageBox.Show("Успешная авторизация");
                
                MainForm mainForm = new MainForm();
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }

            //adapter.SelectCommand = npgsqlCommand;
            //adapter.Fill(table);

            //Не работает выгрузка бд в table 

            //if(table.Rows.Count > 0 )
            //{
            //    MessageBox.Show("Успешная авторизация");
            //}
            //else
            //{
            //    MessageBox.Show("No");
            //}

        }

        private void wayToRegLabel_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            Hide();           
        }
    }
}
