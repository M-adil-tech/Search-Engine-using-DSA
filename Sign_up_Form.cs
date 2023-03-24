using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
            username_box.Text = "Username"; textBox2.Text = "Password";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\wa075\source\repos\WindowsFormsApp1\User data.txt";
            StreamWriter file = new StreamWriter(path,true);
            if(username_box.Text!="" && textBox2.Text!="")
            {
                file.WriteLine(username_box.Text);
                file.WriteLine(textBox2.Text);
                file.Dispose();
                MessageBox.Show("Sign Up Successfully");
                this.Hide();
                var form2 = new Select_User();
                //form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("UserName Or Password Fill Correctly");
                username_box.Text = ""; textBox2.Text = "";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
        }

        private void signup_Click(object sender, EventArgs e)
        {

        }
    }
}
