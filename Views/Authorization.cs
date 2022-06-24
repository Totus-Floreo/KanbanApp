using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KanbanApp.Model;
using KanbanApp.Views;

namespace KanbanApp
{
    public partial class Authorization : Form
    {
        readonly List<User> users = new List<User>(DataBaseContext.Database.Users.ToList());
        public User User { get; private set; } = null;

        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginBox.Text == "" && pwdBox.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка незаполненные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User = users.FirstOrDefault(u =>
                u.login == loginBox.Text &&
                u.password == pwdBox.Text);

                if (User == null)
                {
                    MessageBox.Show("Не верный логин и/или пароль!", "Некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Ошибка системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.ShowDialog();
            this.Show();
        }
    }
}
