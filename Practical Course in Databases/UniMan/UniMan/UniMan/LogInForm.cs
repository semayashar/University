using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniMan
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (usernameTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Enter both username and password");
            }
            else if (usernameTb.Text == "Admin" && passwordTb.Text == "admin")
            {
                Homes obj = new Homes();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
                usernameTb.Text = "";
                passwordTb.Text = "";
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            usernameTb.Text = "";
            passwordTb.Text = "";
        }
    }
}
