using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KanbanApp.Model;

namespace KanbanApp.Views
{
    public partial class MainForm : Form
    {
        
        Kanban selectedKanban = new Kanban();
        public User user;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
            user = authorization.User;
            if (authorization.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                DataBaseContext.DatabaseSuccessfullySaved += UpdateData;

                labelHello.Text = "Добрый день, " + user.fullname + "!";
                UpdateComboBox();
                UpdateData();
            } 
        }

        public void UpdateData()
        {
            if (kanbanCombo.Enabled == false)
            {
                selectedKanban = null;
                return;
            }
            
            selectedKanban = (Kanban)kanbanCombo.SelectedItem;

            if(selectedKanban == null)
            {
                return;
            }

            List<Status> needStatuses = DataBaseContext.Database.Status.ToList()
                .Where(s => s.Kanban == selectedKanban)
                .OrderBy(s => s.ordinal)
                .ThenBy(s => s.name)
                .ToList();

            GenerateKanban(needStatuses);
        }

        private void UpdateComboBox()
        {
            List<Kanban> defaultKanbans = new List<Kanban>()
            {
                new Kanban
                {
                    name = "Канбаны отсутствуют!"
                }
            };

            if (user.Kanbans.Count > 0)
            {
                kanbanCombo.Items.Remove(defaultKanbans[0]);
                kanbanCombo.Enabled = true;
                kanbanCombo.DataSource = user.Kanbans.ToList();
            }
            else
            {
                kanbanCombo.Enabled = false;
                kanbanCombo.DataSource = defaultKanbans;
            }
        }

        public void GenerateKanban(List<Status> statuses)
        {
            flowKanbanPanel.Controls.Clear();

            foreach(Status status in statuses)
            {
                StatusColumn statusColumn = new StatusColumn(status);
                flowKanbanPanel.Controls.Add(statusColumn);
            }
        }

        private void kanbanAdd_Click(object sender, EventArgs e)
        {
            FormAddChangeKanban form = new FormAddChangeKanban(user);

            if(form.ShowDialog() == DialogResult.OK)
            {
                DataBaseContext.SaveDatabase();
                UpdateComboBox();
            }
        }

        private void kanbanEdit_Click(object sender, EventArgs e)
        {
            if (selectedKanban == null)
            {
                return;
            }

            FormAddChangeKanban form = new FormAddChangeKanban(user, selectedKanban);

            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateComboBox();
            }
        }

        private void kanbanDelete_Click(object sender, EventArgs e)
        {
            if(selectedKanban == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить канбан {selectedKanban.name}?\n" +
                $"Это действие невозможно отменить!", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                List<Task> tasks = selectedKanban.Tasks.ToList();
                List<Tool> tools = selectedKanban.Tools.ToList();
                List<Status> statuses = selectedKanban.Status.ToList();

                foreach (Task task in tasks)
                {
                    DataBaseContext.Database.Tasks.Remove(task);
                }
                foreach (Tool tool in tools)
                {
                    DataBaseContext.Database.Tools.Remove(tool);
                }
                foreach (Status status in statuses)
                {
                    DataBaseContext.Database.Status.Remove(status);
                }

                DataBaseContext.Database.Kanbans.Remove(selectedKanban);
                DataBaseContext.SaveDatabase();
                UpdateComboBox();
            }
        }

        private void statusAdd_Click(object sender, EventArgs e)
        {
            if(selectedKanban == null)
            {
                MessageBox.Show("Добавьте канбан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormAddChangeStatus form = new FormAddChangeStatus(selectedKanban);

            if (form.ShowDialog() == DialogResult.OK)
            {
                DataBaseContext.SaveDatabase();
            }
        }

        private void showTools_Click(object sender, EventArgs e)
        {
            if (selectedKanban == null)
            {
                MessageBox.Show("Добавьте канбан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormTools form = new FormTools(selectedKanban);
            form.ShowDialog();
            DataBaseContext.SaveDatabase();
        }

        private void TaskAdd_Click(object sender, EventArgs e)
        {
            if (selectedKanban == null)
            {
                MessageBox.Show("Добавьте канбан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void kanbanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedKanban = (Kanban)kanbanCombo.SelectedItem;
            UpdateData();
        }
    }
}
