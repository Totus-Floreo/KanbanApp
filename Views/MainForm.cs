using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KanbanApp.Model;

namespace KanbanApp.Views
{
    public partial class MainForm : Form
    {
        List<Status> allStatuses = new List<Status>(DataBaseContext.Database.Status.ToList());
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

            List<Status> needStatuses = allStatuses.Where(s => s.Kanban == selectedKanban).OrderBy(s => s.ordinal).ThenBy(s => s.name).ToList();

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
                StatusColumn statusColumn = new StatusColumn();
                statusColumn.GenerateStatusColumnData(status);
                flowKanbanPanel.Controls.Add(statusColumn);
            }
        }

        private void kanbanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void kanbanAdd_Click(object sender, EventArgs e)
        {
            FormAddChangeKanban form = new FormAddChangeKanban(user);

            if(form.ShowDialog() == DialogResult.OK)
            {
                UpdateComboBox();
                UpdateData();
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
                UpdateData();
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
                DataBaseContext.Database.Kanbans.Remove(selectedKanban);
                DataBaseContext.SaveDatabase();
                UpdateComboBox();
                UpdateData();
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

            if (form.ShowDialog() == DialogResult.Yes)
            {
                UpdateComboBox();
                UpdateData();
            }
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            if (selectedKanban == null)
            {
                MessageBox.Show("Добавьте канбан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void TaskAdd_Click(object sender, EventArgs e)
        {
            if (selectedKanban == null)
            {
                MessageBox.Show("Добавьте канбан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
