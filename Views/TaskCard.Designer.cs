namespace KanbanApp.Views
{
    partial class TaskCard
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
            this.labeltaskID = new System.Windows.Forms.Label();
            this.suplabeltool = new System.Windows.Forms.Label();
            this.labeltool = new System.Windows.Forms.Label();
            this.labeltask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeltaskID
            // 
            this.labeltaskID.AutoSize = true;
            this.labeltaskID.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeltaskID.Location = new System.Drawing.Point(0, 0);
            this.labeltaskID.Name = "labeltaskID";
            this.labeltaskID.Size = new System.Drawing.Size(90, 25);
            this.labeltaskID.TabIndex = 0;
            this.labeltaskID.Text = "task 9999";
            // 
            // suplabeltool
            // 
            this.suplabeltool.AutoSize = true;
            this.suplabeltool.Location = new System.Drawing.Point(0, 93);
            this.suplabeltool.Name = "suplabeltool";
            this.suplabeltool.Size = new System.Drawing.Size(135, 25);
            this.suplabeltool.TabIndex = 1;
            this.suplabeltool.Text = "Исполнитель:";
            // 
            // labeltool
            // 
            this.labeltool.AutoSize = true;
            this.labeltool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labeltool.Location = new System.Drawing.Point(0, 118);
            this.labeltool.Name = "labeltool";
            this.labeltool.Size = new System.Drawing.Size(82, 25);
            this.labeltool.TabIndex = 2;
            this.labeltool.Text = "tool one";
            // 
            // labeltask
            // 
            this.labeltask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeltask.Location = new System.Drawing.Point(0, 25);
            this.labeltask.Name = "labeltask";
            this.labeltask.Size = new System.Drawing.Size(143, 93);
            this.labeltask.TabIndex = 3;
            this.labeltask.Text = "create program";
            // 
            // TaskCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labeltask);
            this.Controls.Add(this.labeltool);
            this.Controls.Add(this.suplabeltool);
            this.Controls.Add(this.labeltaskID);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(143, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltaskID;
        private System.Windows.Forms.Label suplabeltool;
        private System.Windows.Forms.Label labeltool;
        private System.Windows.Forms.Label labeltask;
    }
}
