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
            this.statusBox = new System.Windows.Forms.TextBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.buttomDelete = new System.Windows.Forms.PictureBox();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttomDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(300, 557);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // statusBox
            // 
            this.statusBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusBox.Location = new System.Drawing.Point(0, 0);
            this.statusBox.Margin = new System.Windows.Forms.Padding(6);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(263, 33);
            this.statusBox.TabIndex = 1;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.buttomDelete);
            this.panelStatus.Controls.Add(this.statusBox);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(300, 34);
            this.panelStatus.TabIndex = 2;
            // 
            // buttomDelete
            // 
            this.buttomDelete.Image = global::KanbanApp.Properties.Resources.cross;
            this.buttomDelete.Location = new System.Drawing.Point(265, 0);
            this.buttomDelete.Name = "buttomDelete";
            this.buttomDelete.Size = new System.Drawing.Size(32, 33);
            this.buttomDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttomDelete.TabIndex = 5;
            this.buttomDelete.TabStop = false;
            // 
            // StatusColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.flowLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StatusColumn";
            this.Size = new System.Drawing.Size(300, 600);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttomDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.PictureBox buttomDelete;
    }
}
