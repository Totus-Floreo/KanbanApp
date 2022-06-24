using KanbanApp.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KanbanApp.Views
{
    public partial class FormAddChangeStatus : Form
    {
        private Kanban _kanban;
        private Status _status;

        public FormAddChangeStatus(Kanban kanban)
        {
            InitializeComponent();
            _kanban = kanban;
            this.Text = "Добавление статуса";
        }

        public FormAddChangeStatus(Kanban kanban, Status status)
        {
            InitializeComponent();
            _kanban = kanban;
            _status = status;
            nameBox.Text = status.name;
            orderBox.Text = status.ordinal.ToString();
            this.Text = "Изменение статуса";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_status != null && _status.name == nameBox.Text && _status.ordinal == int.Parse(orderBox.Text))
            {
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            int order;
            bool orderConverted = int.TryParse(orderBox.Text, out order);

            if (!orderConverted)
            {
                MessageBox.Show("Порядковый номер статуса должен содержать только целые числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StatusNameExists())
            {
                MessageBox.Show("Данное имя уже принадлежит одному из статусов данного канбана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StatusOrdinalExists(order))
            {
                MessageBox.Show("Порядковый номер уже присвоен одному из статусов данного канбана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.Text == "Добавление статуса")
            {
                _status = new Status()
                {
                    name = nameBox.Text,
                    ordinal = int.Parse(orderBox.Text),
                    kanbanID = _kanban.kanbanID
                };

                DataBaseContext.Database.Status.Add(_status);
            }
            else
            {
                _status.name = nameBox.Text;
                _status.ordinal = order;
            }

            this.DialogResult = DialogResult.OK;
        }

        private bool StatusNameExists()
        {
            if (this.Text == "Добавление статуса")
            {
                return DataBaseContext.Database.Status.ToList()
                .Exists(s =>
                s.Kanban == _kanban &&
                s.name == nameBox.Text);
            }
            else
            {
                return DataBaseContext.Database.Status.Where(s => s.name != nameBox.Text)
                .ToList()
                .Exists(s =>
                s.Kanban == _kanban &&
                s.name == nameBox.Text);
            }
        }

        private bool StatusOrdinalExists(int order)
        {
            return DataBaseContext.Database.Status.ToList().Exists(s =>
            s.Kanban == _kanban &&
            s.ordinal == order);
        }
    }
}
