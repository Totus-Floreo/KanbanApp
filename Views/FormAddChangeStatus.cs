using KanbanApp.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KanbanApp.Views
{
    public partial class FormAddChangeStatus : Form
    {
        private Kanban _kanban;

        public FormAddChangeStatus(Kanban kanban)
        {
            InitializeComponent();
            _kanban = kanban;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_kanban != null && _kanban.name == nameBox.Text)
            {
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            if (StatusNameExists())
            {
                MessageBox.Show("Данное имя уже принадлежит одному из статусов данного канбана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.Text == "Добавление канбана")
            {
                _kanban = new Kanban()
                {
                    name = nameBox.Text
                };

                DataBaseContext.Database.Kanbans.Add(_kanban);
            }
            else
            {
                _kanban.name = nameBox.Text;
            }

            DataBaseContext.SaveDatabase();
            this.DialogResult = DialogResult.OK;
        }

        private bool StatusNameExists()
        {
            return DataBaseContext.Database.Status.ToList().Exists(s =>
            s.Kanban == _kanban &&
            s.name == nameBox.Text);
        }
    }
}
