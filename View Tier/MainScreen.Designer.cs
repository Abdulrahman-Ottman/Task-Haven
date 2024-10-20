namespace View_Tier
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.TaskList = new System.Windows.Forms.DataGridView();
            this.TasksMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateSelector = new System.Windows.Forms.DateTimePicker();
            this.btnShowAllTasks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TaskList)).BeginInit();
            this.TasksMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddTask.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAddTask.Location = new System.Drawing.Point(562, 12);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(200, 40);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // TaskList
            // 
            this.TaskList.AllowUserToAddRows = false;
            this.TaskList.AllowUserToDeleteRows = false;
            this.TaskList.AllowUserToOrderColumns = true;
            this.TaskList.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.TaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskList.ContextMenuStrip = this.TasksMenuStrip;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskList.DefaultCellStyle = dataGridViewCellStyle1;
            this.TaskList.Location = new System.Drawing.Point(12, 12);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(534, 319);
            this.TaskList.TabIndex = 3;
            this.TaskList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.TaskList_CellBeginEdit);
            this.TaskList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskList_CellValueChanged);
            this.TaskList.CurrentCellDirtyStateChanged += new System.EventHandler(this.TaskList_CurrentCellDirtyStateChanged);
            this.TaskList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskList_MouseDown);
            // 
            // TasksMenuStrip
            // 
            this.TasksMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.TasksMenuStrip.Name = "TasksMenuStrip";
            this.TasksMenuStrip.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // DateSelector
            // 
            this.DateSelector.Location = new System.Drawing.Point(562, 130);
            this.DateSelector.Name = "DateSelector";
            this.DateSelector.Size = new System.Drawing.Size(200, 20);
            this.DateSelector.TabIndex = 4;
            this.DateSelector.ValueChanged += new System.EventHandler(this.DateSelector_ValueChanged);
            // 
            // btnShowAllTasks
            // 
            this.btnShowAllTasks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowAllTasks.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnShowAllTasks.Location = new System.Drawing.Point(562, 69);
            this.btnShowAllTasks.Name = "btnShowAllTasks";
            this.btnShowAllTasks.Size = new System.Drawing.Size(200, 40);
            this.btnShowAllTasks.TabIndex = 5;
            this.btnShowAllTasks.Text = "Show All Tasks";
            this.btnShowAllTasks.UseVisualStyleBackColor = false;
            this.btnShowAllTasks.Click += new System.EventHandler(this.btnShowAllTasks_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.btnShowAllTasks);
            this.Controls.Add(this.DateSelector);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.btnAddTask);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskList)).EndInit();
            this.TasksMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DataGridView TaskList;
        private System.Windows.Forms.ContextMenuStrip TasksMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker DateSelector;
        private System.Windows.Forms.Button btnShowAllTasks;
    }
}

