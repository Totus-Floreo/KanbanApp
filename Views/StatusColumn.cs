using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KanbanApp.Model;
using Task = KanbanApp.Model.Task;

namespace KanbanApp.Views
{
    public partial class StatusColumn : UserControl
    {
        private List<Task> allTasks = new List<Task>(DataBaseContext.Database.Tasks);
        private List<Task> needTask = new List<Task>();
        public Status Status { get; private set; }
        public StatusColumn(Status status)
        {
            InitializeComponent();

            this.Status = status;
            statusBox.Text = status.name;
            foreach (Task task in allTasks)
            {
                if (task.Status.statusID == status.statusID)
                {
                    needTask.Add(task);
                }
            }
            GenerateTaskCardList(needTask);
            allTasks.Clear();
            needTask.Clear();
        }

        private void GenerateTaskCardList(List<Task> taskCards)
        {
            flowLayoutPanel.Controls.Clear();
            foreach (Task task in taskCards)
            {
                TaskCard card = new TaskCard();
                card.GenerateTaskCardData(task);
                flowLayoutPanel.Controls.Add(card);
                card.MouseDoubleClick += new MouseEventHandler(EditTaskCardData);
            }
        }

        private void EditTaskCardData(object sender, EventArgs e)
        {
            TaskCard card = (TaskCard)sender;
            MessageBox.Show(card.Task.name);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить статус {Status.name}?\n" +
                $"Это действие невозможно отменить!", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataBaseContext.Database.Status.Remove(Status);
                DataBaseContext.SaveDatabase();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            FormAddChangeStatus form = new FormAddChangeStatus(Status.Kanban, Status);

            if (form.ShowDialog() == DialogResult.OK)
            {
                DataBaseContext.SaveDatabase();
            }
        }
    }
}
