namespace View_Tier
{
    partial class AddEditTask
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
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.lbAddTask = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTaskDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTaskName
            // 
            this.tbTaskName.Location = new System.Drawing.Point(83, 87);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(171, 20);
            this.tbTaskName.TabIndex = 0;
            // 
            // lbAddTask
            // 
            this.lbAddTask.AutoSize = true;
            this.lbAddTask.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbAddTask.Location = new System.Drawing.Point(51, 25);
            this.lbAddTask.Name = "lbAddTask";
            this.lbAddTask.Size = new System.Drawing.Size(184, 33);
            this.lbAddTask.TabIndex = 1;
            this.lbAddTask.Text = "Add New Task";
            this.lbAddTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task name :";
            // 
            // tbTaskDescription
            // 
            this.tbTaskDescription.Location = new System.Drawing.Point(83, 139);
            this.tbTaskDescription.Multiline = true;
            this.tbTaskDescription.Name = "tbTaskDescription";
            this.tbTaskDescription.Size = new System.Drawing.Size(171, 103);
            this.tbTaskDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description :";
            // 
            // dtpEnd_date
            // 
            this.dtpEnd_date.Location = new System.Drawing.Point(83, 278);
            this.dtpEnd_date.Name = "dtpEnd_date";
            this.dtpEnd_date.Size = new System.Drawing.Size(171, 20);
            this.dtpEnd_date.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "End date :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSave.Location = new System.Drawing.Point(145, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(41, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 393);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEnd_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTaskDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAddTask);
            this.Controls.Add(this.tbTaskName);
            this.Name = "AddEditTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTask";
            this.Load += new System.EventHandler(this.AddEditTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.Label lbAddTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTaskDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}