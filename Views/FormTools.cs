using KanbanApp.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KanbanApp.Views
{
    public partial class FormTools : Form
    {
        private Kanban _kanban;

        public FormTools(Kanban kanban)
        {
            InitializeComponent();
            toolBindingSource.DataSource = kanban.Tools.ToList();
            _kanban = kanban;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Tool tool = (Tool)toolBindingSource.Current;

            if(tool == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить исполнителя {tool.name}?\n" +
                $"Это действие невозможно отменить!", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if(tool.Tasks.Count > 0)
                {
                    MessageBox.Show("Данный исполнитель назначен на выполнение задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataBaseContext.Database.Tools.Remove(tool);
                DataBaseContext.SaveDatabase();
                toolBindingSource.DataSource = DataBaseContext.Database.Tools.ToList().Where(t => t.Kanban == _kanban).ToList();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Tool tool = (Tool)toolBindingSource.Current;

            if (tool == null)
            {
                return;
            }

            FormAddChangeTool form = new FormAddChangeTool(_kanban, tool);

            if(form.ShowDialog() == DialogResult.OK)
            {
                toolBindingSource.DataSource = DataBaseContext.Database.Tools.ToList().Where(t => t.Kanban == _kanban).ToList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddChangeTool form = new FormAddChangeTool(_kanban);

            if (form.ShowDialog() == DialogResult.OK)
            {
                toolBindingSource.DataSource = DataBaseContext.Database.Tools.ToList().Where(t => t.Kanban == _kanban).ToList();
            }
        }
    }
}
