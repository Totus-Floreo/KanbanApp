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
        public User user = null;

        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginBox.Text != "" && pwdBox.Text != "")
                {
                    user = users.Find(u => u.login.Contains(loginBox.Text));
                    if (user == null)
                    {
                        MessageBox.Show("Не верный логин или/и пароль!", "Некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (user.password == pwdBox.Text)
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Не верный логин или/и пароль!", "Некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не оставляйте пустых полей!", "Ошибка незаполненные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка системы!", "Ошибка " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {

        }
    }
}
