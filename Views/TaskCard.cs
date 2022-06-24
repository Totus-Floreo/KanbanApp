using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanApp.Views
{
    public partial class TaskCard : UserControl
    {
        public Model.Task Task { get; private set; }
        public TaskCard()
        {
            InitializeComponent();
        }

        public void GenerateTaskCardData(Model.Task task)
        {
            labeltaskID.Text = "Задача " + Convert.ToString(task.taskID);
            labeltask.Text = task.name;
            labeltool.Text = task.Tool.name;
            Task = task;
        }

        private void EditTaskCardData(object sender, EventArgs e)
        {
            FormAddEditTask form = new FormAddEditTask(Task.Kanban, Task);
            if(form.ShowDialog() == DialogResult.OK)
            {
                DataBaseContext.SaveDatabase();
            }
        }
    }
}
