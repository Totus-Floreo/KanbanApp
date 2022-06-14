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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.sublabelKanban = new System.Windows.Forms.Label();
            this.kanbanCombo = new System.Windows.Forms.ComboBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.flowKanbanPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lewdPanel = new System.Windows.Forms.Panel();
            this.kanbanEdit = new System.Windows.Forms.Button();
            this.statusAdd = new System.Windows.Forms.PictureBox();
            this.toolAdd = new System.Windows.Forms.PictureBox();
            this.TaskAdd = new System.Windows.Forms.PictureBox();
            this.kanbanDelete = new System.Windows.Forms.PictureBox();
            this.kanbanAdd = new System.Windows.Forms.PictureBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.lewdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
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
            this.panelTop.Size = new System.Drawing.Size(1193, 76);
            this.panelTop.TabIndex = 0;
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
            this.kanbanCombo.FormattingEnabled = true;
            this.kanbanCombo.Location = new System.Drawing.Point(251, 40);
            this.kanbanCombo.Name = "kanbanCombo";
            this.kanbanCombo.Size = new System.Drawing.Size(215, 33);
            this.kanbanCombo.TabIndex = 2;
            this.kanbanCombo.SelectedIndexChanged += new System.EventHandler(this.kanbanCombo_SelectedIndexChanged);
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
            // flowKanbanPanel
            // 
            this.flowKanbanPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowKanbanPanel.AutoScroll = true;
            this.flowKanbanPanel.Location = new System.Drawing.Point(77, 76);
            this.flowKanbanPanel.Name = "flowKanbanPanel";
            this.flowKanbanPanel.Size = new System.Drawing.Size(1116, 485);
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
            this.lewdPanel.Size = new System.Drawing.Size(78, 485);
            this.lewdPanel.TabIndex = 2;
            // 
            // kanbanEdit
            // 
            this.kanbanEdit.Location = new System.Drawing.Point(510, 40);
            this.kanbanEdit.Name = "kanbanEdit";
            this.kanbanEdit.Size = new System.Drawing.Size(144, 33);
            this.kanbanEdit.TabIndex = 5;
            this.kanbanEdit.Text = "Изменить";
            this.kanbanEdit.UseVisualStyleBackColor = true;
            // 
            // statusAdd
            // 
            this.statusAdd.Image = global::KanbanApp.Properties.Resources.status;
            this.statusAdd.Location = new System.Drawing.Point(8, 137);
            this.statusAdd.Name = "statusAdd";
            this.statusAdd.Size = new System.Drawing.Size(62, 60);
            this.statusAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statusAdd.TabIndex = 2;
            this.statusAdd.TabStop = false;
            // 
            // toolAdd
            // 
            this.toolAdd.Image = global::KanbanApp.Properties.Resources.tool;
            this.toolAdd.Location = new System.Drawing.Point(8, 71);
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(62, 60);
            this.toolAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toolAdd.TabIndex = 1;
            this.toolAdd.TabStop = false;
            // 
            // TaskAdd
            // 
            this.TaskAdd.Image = global::KanbanApp.Properties.Resources.taskadd;
            this.TaskAdd.Location = new System.Drawing.Point(8, 5);
            this.TaskAdd.Name = "TaskAdd";
            this.TaskAdd.Size = new System.Drawing.Size(62, 60);
            this.TaskAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TaskAdd.TabIndex = 0;
            this.TaskAdd.TabStop = false;
            // 
            // kanbanDelete
            // 
            this.kanbanDelete.Image = global::KanbanApp.Properties.Resources.cross;
            this.kanbanDelete.Location = new System.Drawing.Point(660, 40);
            this.kanbanDelete.Name = "kanbanDelete";
            this.kanbanDelete.Size = new System.Drawing.Size(32, 33);
            this.kanbanDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kanbanDelete.TabIndex = 4;
            this.kanbanDelete.TabStop = false;
            // 
            // kanbanAdd
            // 
            this.kanbanAdd.Image = global::KanbanApp.Properties.Resources.add;
            this.kanbanAdd.Location = new System.Drawing.Point(472, 40);
            this.kanbanAdd.Name = "kanbanAdd";
            this.kanbanAdd.Size = new System.Drawing.Size(32, 33);
            this.kanbanAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kanbanAdd.TabIndex = 3;
            this.kanbanAdd.TabStop = false;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::KanbanApp.Properties.Resources.logo;
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(78, 74);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1193, 561);
            this.Controls.Add(this.lewdPanel);
            this.Controls.Add(this.flowKanbanPanel);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Канбан";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.lewdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
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
    }
}