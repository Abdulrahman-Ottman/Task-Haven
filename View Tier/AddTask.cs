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
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            dtpEnd_date.Format = DateTimePickerFormat.Custom;
        }

        private void btnSubmitAddTask_Click(object sender, EventArgs e)
        {
            if(TaskController.AddTask(tbTaskName.Text , tbTaskDescription.Text , dtpEnd_date.Value , DateTime.Now))
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
    }
}
