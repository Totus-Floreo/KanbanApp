using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KanbanApp.Model;
using KanbanApp.Views;

namespace KanbanApp
{
    public partial class Authorization : Form
    {
        readonly List<User> users = new List<User>(DataBaseContext.database.Users.ToList());
        User user = null;

        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if(loginBox.Text != null || pwdBox.Text != null)
            {
                user = users.FirstOrDefault(u => u.login.Contains(loginBox.Text));
                if (user == null)
                {
                    MessageBox.Show("Такой логин не существует!", "Ошибка логина", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(user.password.Contains(pwdBox.Text))
                {
                    this.Hide();
                    MainForm main = new MainForm(user);
                    main.ShowDialog();

                    this.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Не оставляйте пустых значений!", "Ошибка логина или пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
