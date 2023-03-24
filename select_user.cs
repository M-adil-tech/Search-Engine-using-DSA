using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Select_User : Form
    {
        public Select_User()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form obj = new Login_Form();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_login_form obj1 = new admin_login_form();
            obj1.Show();
        }
    }
}
