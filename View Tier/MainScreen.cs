using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Tier;


namespace View_Tier
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

         private void LoadTasks()
        {

            DataTable tasks = TaskController.GetAllTasks();

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
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            LoadTasks();

        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddEditTask addTask = new AddEditTask();
            addTask.ShowDialog();
            LoadTasks();
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
            int id = (int)(TaskList.CurrentRow.Cells[0].Value);
            AddEditTask EditScreen = new AddEditTask(id);
            EditScreen.ShowDialog();
            LoadTasks();
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
            int id = (int)(TaskList.CurrentRow.Cells[0].Value);
            if (TaskController.DeleteTasks(id))
            {
                MessageBox.Show("Task Deleted Succesfully");
                LoadTasks();
            }
            else
            {
                MessageBox.Show("Error: Faild To Delete Task");
            }
        }
    }
}
