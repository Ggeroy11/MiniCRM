using MiniCRM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCRM
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            Enabled = false;
            TaskForm task = new TaskForm();
            task.ShowDialog();
            Visible = true;
            Enabled = true;
        }

        private void Employee_Load(object sender, EventArgs e)
        {

            modelUser user = new modelUser();
            user.ID = 1;
            user.login = "Admom";
            user.password = "passsword";
            user.position = "admin";
               
                
           dataGridView1.Rows.Add(user.ToString());
                
            
        }
    }
}
