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
    public partial class admin_login_form : Form
    {
        Linked_list obj = new Linked_list();
        public admin_login_form()
        {
            InitializeComponent();
        }

        private void admin_login_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\wa075\source\repos\WindowsFormsApp1\Admin data.txt";
            StreamReader file = new StreamReader(path);
            string user, pass;
            while ((user = file.ReadLine()) != null)
            {
                pass = file.ReadLine();
                obj.Add_Node(user, pass);
            }
            file.Close();
            bool flag = false;
            flag = obj.Search_Data(admin_user.Text, admin_pass.Text);
            if (!flag)
                MessageBox.Show(" UserName or Password incorrect ");
            else
            {
                MessageBox.Show(" Login succesfully");
                this.Hide();
                admin_select form = new admin_select();
                form.Show();
            }
        }
    }
}
