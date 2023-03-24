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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(2);
            if (progressBar2.Value == 100)
            {
                this.Hide();
                Form log = new Select_User();
                log.Show();
                timer1.Enabled = false;
            }
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar2.Increment(2);
            if (progressBar2.Value == 100)
            {
                this.Hide();
                Form log = new Select_User();
                log.Show();
                timer1.Enabled = false;
            }
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_2(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
