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
        List<Status> statuses = new List<Status>(DataBaseContext.database.Status.ToList());
        List<Tool> tools = new List<Tool>(DataBaseContext.database.Tools.ToList());
        public User user = null;
        public MainForm(User login)
        {
            InitializeComponent();
            user = login;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            kanbanCombo.DataSource = user.Kanbans.Select(k => k.name).ToList();
            labelHello.Text = "Добрый день, " + user.fullname + "!"; 
            
        }
    }
}
