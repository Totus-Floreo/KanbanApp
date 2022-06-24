namespace KanbanApp.Views
{
    partial class StatusColumn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.statusBox = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.PictureBox();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(298, 555);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.statusBox);
            this.panelStatus.Controls.Add(this.buttonChange);
            this.panelStatus.Controls.Add(this.buttonDelete);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(298, 34);
            this.panelStatus.TabIndex = 2;
            // 
            // statusBox
            // 
            this.statusBox.AutoSize = true;
            this.statusBox.Location = new System.Drawing.Point(3, 4);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(63, 25);
            this.statusBox.TabIndex = 6;
            this.statusBox.Text = "label1";
            // 
            // buttonChange
            // 
            this.buttonChange.Image = global::KanbanApp.Properties.Resources.change;
            this.buttonChange.Location = new System.Drawing.Point(234, 1);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(32, 33);
            this.buttonChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonChange.TabIndex = 5;
            this.buttonChange.TabStop = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::KanbanApp.Properties.Resources.cross;
            this.buttonDelete.Location = new System.Drawing.Point(266, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(32, 33);
            this.buttonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // StatusColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.flowLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StatusColumn";
            this.Size = new System.Drawing.Size(298, 598);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.PictureBox buttonDelete;
        private System.Windows.Forms.PictureBox buttonChange;
        private System.Windows.Forms.Label statusBox;
    }
}
