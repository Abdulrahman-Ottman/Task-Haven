using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Tier;


namespace View_Tier
{
    public partial class MainScreen : Form
    {
        DataTable tasks = TaskController.GetAllTasks();
        static DataColumn[] keyColumns = new DataColumn[1];

        public MainScreen()
        {
            InitializeComponent();
        }

        private void LoadDataFromTasksDataTable()
        {

            keyColumns[0] = tasks.Columns["id"];
            tasks.PrimaryKey = keyColumns;
            // Set up the DataGridView and bind the DataTable
            TaskList.DataSource = tasks;

            TaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Optional: Customize the columns further if needed
            TaskList.Columns[0].Width = 40;  // Set checkbox column width
            TaskList.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format End Date
            TaskList.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format Created At        }

            TaskList.Columns["ID"].DefaultCellStyle.ForeColor = Color.Black;
            TaskList.Columns["Title"].DefaultCellStyle.ForeColor = Color.Black;
            TaskList.Columns["Description"].DefaultCellStyle.ForeColor = Color.Black;
            TaskList.Columns["End Date"].DefaultCellStyle.ForeColor = Color.Black;
            TaskList.Columns["Created At"].DefaultCellStyle.ForeColor = Color.Black;
        }
        private void UpdateDataInTasksDataTable()
        {
            RadioButton checkedFilter = new RadioButton();
            if (rbAllTasks.Checked)
            {
                checkedFilter = rbAllTasks;
            }
            else if (rbCompletedTasks.Checked)
            {
                checkedFilter = rbCompletedTasks;
            }
            else if (rbInCompletedTasks.Checked)
            {
                checkedFilter = rbInCompletedTasks;
            }
            else if (rbTdAllTasks.Checked)
            {
                checkedFilter = rbTdAllTasks;
            }
            else if (rbTdCompletedTasks.Checked)
            {
                checkedFilter = rbTdCompletedTasks;
            }
            else if (rbTdIncompletedTasks.Checked)
            {
                checkedFilter = rbTdIncompletedTasks;
            }

            filters_StatusChanged(checkedFilter, new EventArgs());
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            rbTdAllTasks.Checked = true;
            LoadDataFromTasksDataTable();

        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddEditTask addTask = new AddEditTask();
            addTask.ShowDialog();

            UpdateDataInTasksDataTable();
        }

        private void TaskList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (TaskList.Columns[e.ColumnIndex].Name != "Done")
            {
                // Cancel editing for all columns except "Done"
                e.Cancel = true;
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)(TaskList.CurrentRow.Cells[0].Value);
                AddEditTask EditScreen = new AddEditTask(id);
                EditScreen.ShowDialog();
                UpdateDataInTasksDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : No Task Selected");
            }
        }

        private void TaskList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get the row index of the row that was clicked
                var hitTestInfo = TaskList.HitTest(e.X, e.Y);

                // Check if the click was on a row
                if (hitTestInfo.RowIndex >= 0)
                {
                    // Select the clicked row
                    TaskList.ClearSelection();
                    TaskList.Rows[hitTestInfo.RowIndex].Selected = true;

                    // Optionally, set the current cell if needed
                    TaskList.CurrentCell = TaskList.Rows[hitTestInfo.RowIndex].Cells[0];
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)(TaskList.CurrentRow.Cells[0].Value);
                if (TaskController.DeleteTasks(id))
                {
                    MessageBox.Show("Task Deleted Succesfully");
                    UpdateDataInTasksDataTable();
                    LoadDataFromTasksDataTable();
                }
                else
                {
                    MessageBox.Show("Error: Faild To Delete Task");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No Task selected");

            }
        }

        private void TaskList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)(TaskList.CurrentRow.Cells[0].Value);

            if (e.ColumnIndex == TaskList.Columns["Done"].Index)
            {
                bool isDone = (bool)TaskList.Rows[e.RowIndex].Cells["Done"].Value;


                if (TaskController.UpdateTaskStatus(id, isDone))
                {
                    if (isDone)
                    {
                        MessageBox.Show("Task completed!");
                    }
                    else
                    {
                        MessageBox.Show("Task unChecked!");
                    }

                    UpdateDataInTasksDataTable();
                }
                else
                {
                    MessageBox.Show("Error : Task status hasn't updated");
                }




            }
        }

        private void TaskList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (TaskList.IsCurrentCellDirty && TaskList.CurrentCell is DataGridViewCheckBoxCell)
            {
                TaskList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DateSelector_ValueChanged(object sender, EventArgs e)
        {
            tasks = TaskController.GetTasksByDate(DateSelector.Value);
            LoadDataFromTasksDataTable();
        }


        private void filters_StatusChanged(object sender, EventArgs e)
        {

            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                switch (selectedRadioButton.Name)
                {
                    case "rbAllTasks":
                        tasks = TaskController.GetAllTasks();
                        break;
                    case "rbInCompletedTasks":
                        tasks = TaskController.GetTasksByStatus(false);
                        break;
                    case "rbCompletedTasks":
                        tasks = TaskController.GetTasksByStatus(true);
                        break;
                    case "rbTdAllTasks":
                        tasks = TaskController.GetTasksByDate(DateSelector.Value);
                        break;
                    case "rbTdIncompletedTasks":
                        tasks = TaskController.GetTasksByStatusAndDate(false, DateSelector.Value);
                        break;
                    case "rbTdCompletedTasks":
                        tasks = TaskController.GetTasksByStatusAndDate(true, DateSelector.Value);
                        break;
                }
                LoadDataFromTasksDataTable();
            }
        }
    }
}
