namespace KanbanApp.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.kanbanEdit = new System.Windows.Forms.Button();
            this.kanbanDelete = new System.Windows.Forms.PictureBox();
            this.kanbanAdd = new System.Windows.Forms.PictureBox();
            this.sublabelKanban = new System.Windows.Forms.Label();
            this.kanbanCombo = new System.Windows.Forms.ComboBox();
            this.kanbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelHello = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.flowKanbanPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lewdPanel = new System.Windows.Forms.Panel();
            this.statusAdd = new System.Windows.Forms.PictureBox();
            this.toolAdd = new System.Windows.Forms.PictureBox();
            this.TaskAdd = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.lewdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.panelTop.Controls.Add(this.kanbanEdit);
            this.panelTop.Controls.Add(this.kanbanDelete);
            this.panelTop.Controls.Add(this.kanbanAdd);
            this.panelTop.Controls.Add(this.sublabelKanban);
            this.panelTop.Controls.Add(this.kanbanCombo);
            this.panelTop.Controls.Add(this.labelHello);
            this.panelTop.Controls.Add(this.logoBox);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1332, 76);
            this.panelTop.TabIndex = 0;
            // 
            // kanbanEdit
            // 
            this.kanbanEdit.Location = new System.Drawing.Point(569, 40);
            this.kanbanEdit.Name = "kanbanEdit";
            this.kanbanEdit.Size = new System.Drawing.Size(144, 33);
            this.kanbanEdit.TabIndex = 5;
            this.kanbanEdit.Text = "Изменить";
            this.kanbanEdit.UseVisualStyleBackColor = true;
            this.kanbanEdit.Click += new System.EventHandler(this.kanbanEdit_Click);
            // 
            // kanbanDelete
            // 
            this.kanbanDelete.Image = global::KanbanApp.Properties.Resources.cross;
            this.kanbanDelete.Location = new System.Drawing.Point(719, 40);
            this.kanbanDelete.Name = "kanbanDelete";
            this.kanbanDelete.Size = new System.Drawing.Size(32, 33);
            this.kanbanDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kanbanDelete.TabIndex = 4;
            this.kanbanDelete.TabStop = false;
            this.kanbanDelete.Click += new System.EventHandler(this.kanbanDelete_Click);
            // 
            // kanbanAdd
            // 
            this.kanbanAdd.Image = global::KanbanApp.Properties.Resources.add;
            this.kanbanAdd.Location = new System.Drawing.Point(531, 40);
            this.kanbanAdd.Name = "kanbanAdd";
            this.kanbanAdd.Size = new System.Drawing.Size(32, 33);
            this.kanbanAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kanbanAdd.TabIndex = 3;
            this.kanbanAdd.TabStop = false;
            this.kanbanAdd.Click += new System.EventHandler(this.kanbanAdd_Click);
            // 
            // sublabelKanban
            // 
            this.sublabelKanban.AutoSize = true;
            this.sublabelKanban.Location = new System.Drawing.Point(84, 43);
            this.sublabelKanban.Name = "sublabelKanban";
            this.sublabelKanban.Size = new System.Drawing.Size(161, 25);
            this.sublabelKanban.TabIndex = 3;
            this.sublabelKanban.Text = "Выбрать канбан:";
            // 
            // kanbanCombo
            // 
            this.kanbanCombo.DataSource = this.kanbanBindingSource;
            this.kanbanCombo.DisplayMember = "name";
            this.kanbanCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kanbanCombo.Enabled = false;
            this.kanbanCombo.FormattingEnabled = true;
            this.kanbanCombo.Location = new System.Drawing.Point(251, 40);
            this.kanbanCombo.Name = "kanbanCombo";
            this.kanbanCombo.Size = new System.Drawing.Size(274, 33);
            this.kanbanCombo.TabIndex = 2;
            this.kanbanCombo.ValueMember = "kanbanID";
            this.kanbanCombo.SelectedIndexChanged += new System.EventHandler(this.kanbanCombo_SelectedIndexChanged);
            // 
            // kanbanBindingSource
            // 
            this.kanbanBindingSource.DataSource = typeof(KanbanApp.Model.Kanban);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(84, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(186, 25);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "Добрый день, имя !";
            // 
            // logoBox
            // 
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoBox.Image = global::KanbanApp.Properties.Resources.logo;
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(78, 76);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // flowKanbanPanel
            // 
            this.flowKanbanPanel.AutoScroll = true;
            this.flowKanbanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowKanbanPanel.Location = new System.Drawing.Point(78, 76);
            this.flowKanbanPanel.Name = "flowKanbanPanel";
            this.flowKanbanPanel.Size = new System.Drawing.Size(1254, 651);
            this.flowKanbanPanel.TabIndex = 1;
            // 
            // lewdPanel
            // 
            this.lewdPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lewdPanel.Controls.Add(this.statusAdd);
            this.lewdPanel.Controls.Add(this.toolAdd);
            this.lewdPanel.Controls.Add(this.TaskAdd);
            this.lewdPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lewdPanel.Location = new System.Drawing.Point(0, 76);
            this.lewdPanel.Name = "lewdPanel";
            this.lewdPanel.Size = new System.Drawing.Size(78, 651);
            this.lewdPanel.TabIndex = 2;
            // 
            // statusAdd
            // 
            this.statusAdd.Image = global::KanbanApp.Properties.Resources.status;
            this.statusAdd.Location = new System.Drawing.Point(8, 137);
            this.statusAdd.Name = "statusAdd";
            this.statusAdd.Size = new System.Drawing.Size(62, 60);
            this.statusAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusAdd.TabIndex = 2;
            this.statusAdd.TabStop = false;
            this.statusAdd.Click += new System.EventHandler(this.statusAdd_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = global::KanbanApp.Properties.Resources.tool;
            this.toolAdd.Location = new System.Drawing.Point(8, 71);
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(62, 60);
            this.toolAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toolAdd.TabIndex = 1;
            this.toolAdd.TabStop = false;
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // TaskAdd
            // 
            this.TaskAdd.Image = global::KanbanApp.Properties.Resources.taskadd;
            this.TaskAdd.Location = new System.Drawing.Point(8, 5);
            this.TaskAdd.Name = "TaskAdd";
            this.TaskAdd.Size = new System.Drawing.Size(62, 60);
            this.TaskAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TaskAdd.TabIndex = 0;
            this.TaskAdd.TabStop = false;
            this.TaskAdd.Click += new System.EventHandler(this.TaskAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1332, 727);
            this.Controls.Add(this.flowKanbanPanel);
            this.Controls.Add(this.lewdPanel);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Канбан";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.lewdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.ComboBox kanbanCombo;
        private System.Windows.Forms.Label sublabelKanban;
        private System.Windows.Forms.FlowLayoutPanel flowKanbanPanel;
        private System.Windows.Forms.Panel lewdPanel;
        private System.Windows.Forms.Button kanbanEdit;
        private System.Windows.Forms.PictureBox kanbanDelete;
        private System.Windows.Forms.PictureBox kanbanAdd;
        private System.Windows.Forms.PictureBox statusAdd;
        private System.Windows.Forms.PictureBox toolAdd;
        private System.Windows.Forms.PictureBox TaskAdd;
        private System.Windows.Forms.BindingSource kanbanBindingSource;
    }
}