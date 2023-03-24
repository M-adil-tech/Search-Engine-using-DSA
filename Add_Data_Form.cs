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
    public partial class Add_Data_Form : Form
    {
        public Add_Data_Form()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\wa075\source\repos\WindowsFormsApp1\Search data.txt";
            StreamWriter file = new StreamWriter(path, true);
            if (textBox1.Text!="" && textBox2.Text!="")
            {
                file.WriteLine(textBox1.Text);
                file.WriteLine(textBox2.Text);
                file.Dispose();
                MessageBox.Show("Add Successfully");
            }
            else
            {
                MessageBox.Show("Please Add The Address and Key correctly");
            }
            textBox1.Text = "Address"; textBox2.Text = "keyword";
            file.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_engine_form form = new Search_engine_form();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
