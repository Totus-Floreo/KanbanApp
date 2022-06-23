using KanbanApp.Model;
using System;
using System.Windows.Forms;

namespace KanbanApp.Views
{
    public partial class Registration : Form
    {
        public User User { get; set; } = new User();

        public Registration()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (!FormValidated())
            {
                return;
            }

            AppendUserInfo();

            DataBaseContext.Database.Users.Add(User);
            DataBaseContext.SaveDatabase();
            
            this.DialogResult = DialogResult.OK;
        }

        private bool FormValidated()
        {
            if (loginBox.Text == "" ||
               passwordBox.Text == "" ||
               emailBox.Text == "" ||
               fullnameBox.Text == "")
            {
                MessageBox.Show("Заполните текстовые поля!", "Некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(emailBox.Text))
            {
                MessageBox.Show("Адрес электронной почты должен соответствовать виду:\na@a.a", "Некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int age = DateTime.Now.Year - bithdayPicker.Value.Year;

            if (bithdayPicker.Value.AddYears(age) > DateTime.Now)
            {
                age--;
            }

            if (age < 18)
            {
                MessageBox.Show("Возраст пользователя должен быть больше 18 лет!", "Некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (age >= 120)
            {
                MessageBox.Show("Возраст пользователя должен быть меньше 120 лет!", "Некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AppendUserInfo()
        {
            User.login = loginBox.Text;
            User.password = passwordBox.Text;
            User.email = emailBox.Text;
            User.fullname = fullnameBox.Text;
            User.birthdate = bithdayPicker.Value;
            User.joindate = DateTime.Now;
        }

        bool IsValidEmail(string eMail)
        {
            bool result;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);
                result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                result = false;
            };

            return result;
        }
    }
}
