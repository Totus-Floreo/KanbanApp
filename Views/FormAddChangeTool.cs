using KanbanApp.Model;
using System;
using System.Windows.Forms;

namespace KanbanApp.Views
{
    public partial class FormAddChangeTool : Form
    {
        private Kanban _kanban;
        private Tool _tool;

        public FormAddChangeTool(Kanban kanban)
        {
            InitializeComponent();
            _kanban = kanban;
            this.Text = "Добавление исполнителя";
        }

        public FormAddChangeTool(Kanban kanban, Tool tool)
        {
            InitializeComponent();
            nameBox.Text = tool.name;
            postBox.Text = tool.post;
            _kanban = kanban;
            _tool = tool;
            this.Text = "Изменение исполнителя";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_tool != null && _tool.name == nameBox.Text && _tool.post == postBox.Text)
            {
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            if(nameBox.Text == "" ||
               postBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.Text == "Добавление исполнителя")
            {
                _tool = new Tool()
                {
                    name = nameBox.Text,
                    post = postBox.Text,
                    kanbanID = _kanban.kanbanID
                };

                DataBaseContext.Database.Tools.Add(_tool);
            }
            else
            {
                _tool.name = nameBox.Text;
                _tool.post = postBox.Text;
            }

            DataBaseContext.SaveDatabase();
            this.DialogResult = DialogResult.OK;
        }
    }
}
