namespace KanbanApp.Views
{
    partial class FormAddEditTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditTask));
            this.comboBoxTool = new System.Windows.Forms.ComboBox();
            this.toolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTool
            // 
            this.comboBoxTool.DataSource = this.toolBindingSource;
            this.comboBoxTool.DisplayMember = "name";
            this.comboBoxTool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTool.FormattingEnabled = true;
            this.comboBoxTool.Location = new System.Drawing.Point(151, 51);
            this.comboBoxTool.Name = "comboBoxTool";
            this.comboBoxTool.Size = new System.Drawing.Size(270, 33);
            this.comboBoxTool.TabIndex = 0;
            this.comboBoxTool.ValueMember = "toolID";
            // 
            // toolBindingSource
            // 
            this.toolBindingSource.DataSource = typeof(KanbanApp.Model.Tool);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DataSource = this.statusBindingSource;
            this.comboBoxStatus.DisplayMember = "name";
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(151, 90);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(270, 33);
            this.comboBoxStatus.TabIndex = 0;
            this.comboBoxStatus.ValueMember = "statusID";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(KanbanApp.Model.Status);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(151, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 33);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(103, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Исполнитель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Статус:";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(291, 129);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 35);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 129);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 35);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormAddEditTask
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(436, 173);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxTool);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddEditTask";
            this.Text = "НАЗВАНИЕ";
            ((System.ComponentModel.ISupportInitialize)(this.toolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTool;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource toolBindingSource;
        private System.Windows.Forms.BindingSource statusBindingSource;
    }
}