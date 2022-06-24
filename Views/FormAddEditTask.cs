using KanbanApp.Model;
using System.Linq;
using System.Windows.Forms;

namespace KanbanApp.Views
{
    public partial class FormAddEditTask : Form
    {
        private Task _task;
        private Kanban _kanban;

        public FormAddEditTask(Kanban kanban)
        {
            InitializeComponent();
            comboBoxTool.DataSource = kanban.Tools.ToList();
            comboBoxStatus.DataSource = kanban.Status.ToList();
            _kanban = kanban;
            this.Text = "Добавление задачи";
        }

        public FormAddEditTask(Kanban kanban, Task task)
        {
            InitializeComponent();
            comboBoxTool.DataSource = kanban.Tools.ToList();
            comboBoxStatus.DataSource = kanban.Status.ToList();
            _kanban = kanban;
            _task = task;
            textBoxName.Text = task.name;
            comboBoxTool.SelectedItem = task.Tool;
            comboBoxStatus.SelectedItem = task.Status;
            this.Text = "Изменение задачи";
        }

        private void buttonBack_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Введите имя задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxTool.SelectedItem == null)
            {
                MessageBox.Show("Выберите исполнителя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Выберите статус!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.Text == "Добавление задачи")
            {
                _task = new Task()
                {
                    name = textBoxName.Text,
                    Kanban = _kanban,
                    Tool = (Tool)comboBoxTool.SelectedItem,
                    Status = (Status)comboBoxStatus.SelectedItem
                };

                DataBaseContext.Database.Tasks.Add(_task);
            }
            else
            {
                _task.name = textBoxName.Text;
                _task.Kanban = _kanban;
                _task.Tool = (Tool)comboBoxTool.SelectedItem;
                _task.Status = (Status)comboBoxStatus.SelectedItem;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
