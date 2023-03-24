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
    public partial class Most_Clicked : Form
    {
        Max_Heap obj = new Max_Heap();
        public Most_Clicked()
        {
            InitializeComponent();
        }

        private void m_search_TextChanged(object sender, EventArgs e)
        {
        }

        private void show_Click(object sender, EventArgs e)
        {
            string path1 = @"C:\Users\wa075\source\repos\WindowsFormsApp1\Priority data.txt";
            StreamReader p = new StreamReader(path1);
            string priority_data = "";
            int key1;
            while ((priority_data = p.ReadLine()) != null)
            {
                key1 = int.Parse(p.ReadLine());
                obj.Enqueue(priority_data, key1);
            }
            p.Close();
            node curr = obj.front;
            m_search.Text = "Keyword " + "          " + "Most Searched" + "\r\n";
            while (curr != null)
            {
                m_search.Text += curr.data +"\t\t\t"+curr.priority + "\r\n";
                curr = curr.next;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_select log = new admin_select();
            log.Show();
        }
    }
}
