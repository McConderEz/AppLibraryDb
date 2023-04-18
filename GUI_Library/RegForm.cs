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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string logginUser = loginField.Text;
            string passwordUser = passField.Text;

            if (string.IsNullOrWhiteSpace(logginUser) || string.IsNullOrWhiteSpace(passwordUser))
            {
                MessageBox.Show("Заполните логин и пароль!");
                return;
            }

            using (var db = new DBLibraryAppCore.ApplicationContext())
            {
                var list = db.users;

                if (list.Contains(list.FirstOrDefault(x => x.Login == logginUser)))
                {
                    MessageBox.Show("Данный логин занят, попробуйте другой");
                    return;
                }

                db.users.Add(new User
                {
                    Login = logginUser,
                    Password = passwordUser
                });
                MessageBox.Show("Аккаунт создан!");
                db.SaveChanges();
            }
        }

        private void wayToLogLabel_Click(object sender, EventArgs e)
        {         
            LogginForm logginForm = new LogginForm();
            logginForm.Show();
            Hide();
        }
    }
}
