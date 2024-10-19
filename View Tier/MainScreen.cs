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

            //DataTable tasks = new DataTable();

            // Set up the DataGridView and bind the DataTable
            //TaskList.DataSource = tasks;

            DataGridViewCheckBoxColumn doneColumn = new DataGridViewCheckBoxColumn();
            doneColumn.HeaderText = "Done";
            doneColumn.Name = "Done";
            doneColumn.Width = 50;
            TaskList.Columns.Add(doneColumn);

            TaskList.Columns.Add("Name", "Name");    
            TaskList.Columns.Add("Description", "Description"); 
            TaskList.Columns.Add("End Date", "End Date");    
            TaskList.Columns.Add("Created At", "Created At");

            TaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            TaskList.Rows.Add(false, "Finish project", "Complete the final report", DateTime.Now.AddDays(3), DateTime.Now);
            // Optional: Customize the columns further if needed
            TaskList.Columns[0].Width = 40;  // Set checkbox column width
            TaskList.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format End Date
            TaskList.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format Created At        }

            TaskList.Columns["Name"].DefaultCellStyle.ForeColor = Color.Black;
            TaskList.Columns["Description"].DefaultCellStyle.ForeColor = Color.Black;
            TaskList.Columns["End Date"].DefaultCellStyle.ForeColor = Color.Black;
            TaskList.Columns["Created At"].DefaultCellStyle.ForeColor = Color.Black;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            LoadTasks();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.ShowDialog();
        }

        private void TaskList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (TaskList.Columns[e.ColumnIndex].Name != "Done")
            {
                // Cancel editing for all columns except "Done"
                e.Cancel = true;
            }
        }
    }
}
