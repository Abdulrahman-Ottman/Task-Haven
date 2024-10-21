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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.TaskList = new System.Windows.Forms.DataGridView();
            this.TasksMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateSelector = new System.Windows.Forms.DateTimePicker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.rbCompletedTasks = new System.Windows.Forms.RadioButton();
            this.rbInCompletedTasks = new System.Windows.Forms.RadioButton();
            this.rbTdIncompletedTasks = new System.Windows.Forms.RadioButton();
            this.rbTdCompletedTasks = new System.Windows.Forms.RadioButton();
            this.rbTdAllTasks = new System.Windows.Forms.RadioButton();
            this.rbAllTasks = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TaskList)).BeginInit();
            this.TasksMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.gbFilters.SuspendLayout();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskList.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.DateSelector.Location = new System.Drawing.Point(562, 72);
            this.DateSelector.Name = "DateSelector";
            this.DateSelector.Size = new System.Drawing.Size(200, 20);
            this.DateSelector.TabIndex = 4;
            this.DateSelector.ValueChanged += new System.EventHandler(this.DateSelector_ValueChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // gbFilters
            // 
            this.gbFilters.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbFilters.Controls.Add(this.rbAllTasks);
            this.gbFilters.Controls.Add(this.rbTdCompletedTasks);
            this.gbFilters.Controls.Add(this.rbTdIncompletedTasks);
            this.gbFilters.Controls.Add(this.rbCompletedTasks);
            this.gbFilters.Controls.Add(this.rbInCompletedTasks);
            this.gbFilters.Controls.Add(this.rbTdAllTasks);
            this.gbFilters.Location = new System.Drawing.Point(562, 124);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(200, 207);
            this.gbFilters.TabIndex = 6;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // rbCompletedTasks
            // 
            this.rbCompletedTasks.AutoSize = true;
            this.rbCompletedTasks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbCompletedTasks.Location = new System.Drawing.Point(11, 173);
            this.rbCompletedTasks.Name = "rbCompletedTasks";
            this.rbCompletedTasks.Size = new System.Drawing.Size(120, 17);
            this.rbCompletedTasks.TabIndex = 2;
            this.rbCompletedTasks.TabStop = true;
            this.rbCompletedTasks.Text = "All Completed Tasks";
            this.rbCompletedTasks.UseVisualStyleBackColor = true;
            this.rbCompletedTasks.CheckedChanged += new System.EventHandler(this.filters_StatusChanged);
            // 
            // rbInCompletedTasks
            // 
            this.rbInCompletedTasks.AutoSize = true;
            this.rbInCompletedTasks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbInCompletedTasks.Location = new System.Drawing.Point(11, 144);
            this.rbInCompletedTasks.Name = "rbInCompletedTasks";
            this.rbInCompletedTasks.Size = new System.Drawing.Size(128, 17);
            this.rbInCompletedTasks.TabIndex = 1;
            this.rbInCompletedTasks.TabStop = true;
            this.rbInCompletedTasks.Text = "All Incompleted Tasks";
            this.rbInCompletedTasks.UseVisualStyleBackColor = true;
            this.rbInCompletedTasks.CheckedChanged += new System.EventHandler(this.filters_StatusChanged);
            // 
            // rbTdIncompletedTasks
            // 
            this.rbTdIncompletedTasks.AutoSize = true;
            this.rbTdIncompletedTasks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTdIncompletedTasks.Location = new System.Drawing.Point(11, 57);
            this.rbTdIncompletedTasks.Name = "rbTdIncompletedTasks";
            this.rbTdIncompletedTasks.Size = new System.Drawing.Size(147, 17);
            this.rbTdIncompletedTasks.TabIndex = 3;
            this.rbTdIncompletedTasks.TabStop = true;
            this.rbTdIncompletedTasks.Text = "Today Incompleted Tasks";
            this.rbTdIncompletedTasks.UseVisualStyleBackColor = true;
            this.rbTdIncompletedTasks.CheckedChanged += new System.EventHandler(this.filters_StatusChanged);
            // 
            // rbTdCompletedTasks
            // 
            this.rbTdCompletedTasks.AutoSize = true;
            this.rbTdCompletedTasks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTdCompletedTasks.Location = new System.Drawing.Point(11, 86);
            this.rbTdCompletedTasks.Name = "rbTdCompletedTasks";
            this.rbTdCompletedTasks.Size = new System.Drawing.Size(139, 17);
            this.rbTdCompletedTasks.TabIndex = 4;
            this.rbTdCompletedTasks.TabStop = true;
            this.rbTdCompletedTasks.Text = "Today Completed Tasks";
            this.rbTdCompletedTasks.UseVisualStyleBackColor = true;
            this.rbTdCompletedTasks.CheckedChanged += new System.EventHandler(this.filters_StatusChanged);
            // 
            // rbTdAllTasks
            // 
            this.rbTdAllTasks.AutoSize = true;
            this.rbTdAllTasks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTdAllTasks.Location = new System.Drawing.Point(11, 28);
            this.rbTdAllTasks.Name = "rbTdAllTasks";
            this.rbTdAllTasks.Size = new System.Drawing.Size(99, 17);
            this.rbTdAllTasks.TabIndex = 0;
            this.rbTdAllTasks.TabStop = true;
            this.rbTdAllTasks.Text = "Today All Tasks";
            this.rbTdAllTasks.UseVisualStyleBackColor = true;
            this.rbTdAllTasks.CheckedChanged += new System.EventHandler(this.filters_StatusChanged);
            // 
            // rbAllTasks
            // 
            this.rbAllTasks.AutoSize = true;
            this.rbAllTasks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbAllTasks.Location = new System.Drawing.Point(11, 115);
            this.rbAllTasks.Name = "rbAllTasks";
            this.rbAllTasks.Size = new System.Drawing.Size(66, 17);
            this.rbAllTasks.TabIndex = 5;
            this.rbAllTasks.TabStop = true;
            this.rbAllTasks.Text = "All Tasks";
            this.rbAllTasks.UseVisualStyleBackColor = true;
            this.rbAllTasks.CheckedChanged += new System.EventHandler(this.filters_StatusChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.DateSelector);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.btnAddTask);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskList)).EndInit();
            this.TasksMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DataGridView TaskList;
        private System.Windows.Forms.ContextMenuStrip TasksMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker DateSelector;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.RadioButton rbCompletedTasks;
        private System.Windows.Forms.RadioButton rbInCompletedTasks;
        private System.Windows.Forms.RadioButton rbTdCompletedTasks;
        private System.Windows.Forms.RadioButton rbTdIncompletedTasks;
        private System.Windows.Forms.RadioButton rbTdAllTasks;
        private System.Windows.Forms.RadioButton rbAllTasks;
    }
}

