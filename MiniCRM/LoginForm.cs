using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCRM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void canceButton_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            FileRead(loginTextBox.Text,passwordTextBox.Text);
        }
        public void FileRead(string login,string password)
        {
            string loginst="";
            string passwordst = "";
            string path = @"C:\Users\UE\source\repos\MiniCRM\MiniCRM\login.txt";
            using (StreamReader stream = new StreamReader(path,System.Text.Encoding.Default))
            {
                loginst = stream.ReadLine();
                passwordst = stream.ReadLine();
            }
            if (login.Equals(loginst) && password.Equals(passwordst))
            {
                Visible = false;
                Enabled = false;
                Employee employee = new Employee();
                employee.Owner = this;
                employee.ShowDialog();
                Visible = true;
                Enabled = true;
            }
            else
            {
                MessageBox.Show("Логин или пароль не верны");
            }

        }
    }
}
