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
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.flowKanbanPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.sublabelKanban);
            this.panelTop.Controls.Add(this.kanbanCombo);
            this.panelTop.Controls.Add(this.labelHello);
            this.panelTop.Controls.Add(this.logoBox);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 76);
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
            // flowKanbanPanel
            // 
            this.flowKanbanPanel.AutoScroll = true;
            this.flowKanbanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowKanbanPanel.Location = new System.Drawing.Point(0, 76);
            this.flowKanbanPanel.Name = "flowKanbanPanel";
            this.flowKanbanPanel.Size = new System.Drawing.Size(984, 485);
            this.flowKanbanPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.flowKanbanPanel);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Канбан";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
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
    }
}