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
    public partial class Login_Form : Form
    {
        Linked_list obj = new Linked_list();
        bool flag = false;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
           
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\wa075\source\repos\WindowsFormsApp1\User data.txt";
            StreamReader file = new StreamReader(path);
            string user, pass;
            while ((user = file.ReadLine()) != null)
            {
                pass = file.ReadLine();
                obj.Add_Node(user, pass);
            }
            file.Close();
            flag = obj.Search_Data(username_box.Text, textBox2.Text);
            if (!flag)
                MessageBox.Show("Username or Password incorrect");
            else
            {
                MessageBox.Show(" Login succesfully ");
                this.Hide();
                var form = new Search_engine_form();
                form.Show();
            }
            obj.head = null;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Sign_up();
            form3.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
        }
    }
}
