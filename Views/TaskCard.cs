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
        public TaskCard()
        {
            InitializeComponent();
        }

        public void GenerateTaskCardData(Model.Task task)
        {
            labeltaskID.Text = "Задача " + Convert.ToString(task.taskID);
            labeltask.Text = task.name;
            labeltool.Text = task.Tool.name;
        }
    }
}
