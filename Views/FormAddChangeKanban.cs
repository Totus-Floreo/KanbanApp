using KanbanApp.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KanbanApp.Views
{
    public partial class FormAddChangeKanban : Form
    {
        private User _user;
        private Kanban _kanban = null;

        public FormAddChangeKanban(User user)
        {
            InitializeComponent();
            _user = user;
            this.Text = "Добавление канбана";
        }

        public FormAddChangeKanban(User user, Kanban kanban)
        {
            InitializeComponent();
            _user = user;
            _kanban = kanban;
            nameBox.Text = kanban.name;
            this.Text = "Изменение канбана";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(_kanban != null && _kanban.name == nameBox.Text)
            {
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            if (KanbanNameExists())
            {
                MessageBox.Show("Данное имя уже принадлежит одному из ваших канбанов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.Text == "Добавление канбана")
            {
                _kanban = new Kanban()
                {
                    name = nameBox.Text
                };

                DataBaseContext.Database.Kanbans.Add(_kanban);
                _user.Kanbans.Add(_kanban);
            }
            else
            {
                _kanban.name = nameBox.Text;
            }

            DataBaseContext.SaveDatabase();
            this.DialogResult = DialogResult.OK;
        }

        private bool KanbanNameExists()
        {
            return _user.Kanbans.ToList().Exists(k => k.name == nameBox.Text);
        }
    }
}
