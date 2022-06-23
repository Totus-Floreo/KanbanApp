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
using Task = KanbanApp.Model.Task;

namespace KanbanApp.Views
{
    public partial class StatusColumn : UserControl
    {
        private List<Task> allTasks = new List<Task>(DataBaseContext.Database.Tasks);
        private List<Task> needTask = new List<Task>();
        public StatusColumn()
        {
            InitializeComponent();
        }

        public void GenerateStatusColumnData(Status status)
        {
            statusBox.Text = status.name;
            foreach (Task task in allTasks)
            {
                if(task.Status.statusID == status.statusID)
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
    }
}
