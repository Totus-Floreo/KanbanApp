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

namespace KanbanApp.Views
{
    public partial class MainForm : Form
    {
        List<Kanban> kanbans = new List<Kanban>(DataBaseContext.database.Kanbans.ToList());
        List<Status> allStatuses = new List<Status>(DataBaseContext.database.Status.ToList());
        List<Status> needStatuses = new List<Status>();
        Kanban selectedKanban = new Kanban();
        public User user = null;
        public MainForm(User login)
        {
            InitializeComponent();
            user = login;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            kanbanCombo.DataSource = user.Kanbans.Select(k => k.name).ToList();
            kanbanCombo.SelectedIndex = 0;
            labelHello.Text = "Добрый день, " + user.fullname + "!";
            UpdateData();
        }

        public void UpdateData()
        {           
            selectedKanban = kanbans.First(k => k.name.Contains(kanbanCombo.Text));
            foreach (Status status in allStatuses)
            {
                if(status.Kanban.name == selectedKanban.name)
                {
                    needStatuses.Add(status);
                }
            }
            GenerateKanban(needStatuses);
            needStatuses.Clear();
        }

        public void GenerateKanban(List<Status> statuses)
        {
            flowKanbanPanel.Controls.Clear();
            foreach(Status status in statuses)
            {
                StatusColumn statusColumn = new StatusColumn();
                statusColumn.GenerateStatusColumnData(status);
                flowKanbanPanel.Controls.Add(statusColumn);
            }
        }

        private void kanbanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowKanbanPanel.Controls.Clear();
            UpdateData();
        }
    }
}
