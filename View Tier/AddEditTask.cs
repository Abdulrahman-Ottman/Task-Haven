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
    public partial class AddEditTask : Form
    {
        enum enMode {Add=1 , Update=2 }
        enMode Mode = enMode.Add;
        int TaskId = -1;
        public AddEditTask()
        {
            InitializeComponent();
        }
        public AddEditTask(int id)
        {
            TaskId = id;
            InitializeComponent();
            Dictionary<string,string> taskData = TaskController.GetTaskDataById(id);
            lbAddTask.Text = $"Edit Task: {taskData["title"]}";
            tbTaskName.Text = $"{taskData["title"]}";
            tbTaskDescription.Text = $"{taskData["description"]}";
            dtpEnd_date.Value = DateTime.Parse(taskData["end_date"]);
            Mode = enMode.Update;
        }

        private void AddEditTask_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            dtpEnd_date.Format = DateTimePickerFormat.Custom;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (Mode == enMode.Add)
            {
                if (TaskController.AddTask(tbTaskName.Text, tbTaskDescription.Text, dtpEnd_date.Value, DateTime.Now))
                {
                    MessageBox.Show("Task Added Successfully");
                    tbTaskName.Clear();
                    tbTaskDescription.Clear();
                }
                else
                {
                    MessageBox.Show("Error: faild to add task");
                }
            }
            else
            {
                if (TaskController.UpdateTask(TaskId ,tbTaskName.Text, tbTaskDescription.Text, dtpEnd_date.Value, DateTime.Now))
                {
                    MessageBox.Show("Task Updated Successfully");
                    tbTaskName.Clear();
                    tbTaskDescription.Clear();
                }
                else
                {
                    MessageBox.Show("Error: faild to update task");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
