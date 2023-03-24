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
    public partial class admin_select : Form
    {
        node temp1 = null, temp2 = null, temp3 = null, temp4 = null;
        bool ch = false;
        AVL obj = new AVL();
        int count = 1;
        // check used for only one condition
        // using for adding fisrt keyword in the priority queue
        bool check_c = false;
        // count1 used for unique key of webpages for storing in the AVL
        // count 2 used for giving priority of keywords for searching 
        static int count1 = 0, count2 = 0, count4 = 0;
        Linked_list l1 = new Linked_list();
        Max_Heap m1 = new Max_Heap();
        Max_Heap m2 = new Max_Heap();
        public admin_select()
        {
            obj.Root = null;
            InitializeComponent();
        }

        private void Read_Priority_file()
        {
            string path1 = @"C:\Users\wa075\source\repos\WindowsFormsApp1\Priority data.txt";
            StreamReader p = new StreamReader(path1);
            string priority_data = "";
            int key1;
            while ((priority_data = p.ReadLine()) != null)
            {
                key1 = int.Parse(p.ReadLine());
                m1.Enqueue(priority_data, key1);
                check_c = true;
            }
            p.Close();
            if (check_c == false)
            {
                count2++;
                m1.Enqueue(textBox1.Text, count2);
                count2 = 0;
                check_c = true;
            }
            else
            {
                temp3 = m1.Searching_By_Data(textBox1.Text);
                if (temp3 != null)
                {
                    temp3.priority++;
                    //MessageBox.Show("greater input " + temp3.priority);
                }
                else
                {
                    count2++;
                    m1.Enqueue(textBox1.Text, count2);
                    //MessageBox.Show("least input " + count2);
                    count2 = 0;
                }
            }
        }
        private void Read_Search_file()
        {
            string path = @"C:\Users\wa075\source\repos\WindowsFormsApp1\Search data.txt";
            StreamReader file = new StreamReader(path);
            string web, key;
            while ((web = file.ReadLine()) != null)
            {
                key = file.ReadLine();
                count1++;
                obj.insert(web, key, count1);
            }
            file.Close();
        }
        private void Write_in_Priority_file()
        {
            // storing data into the file
            string priority = @"C:\Users\wa075\source\repos\WindowsFormsApp1\Priority data.txt";
            StreamWriter file1 = new StreamWriter(priority);
            node curr = m1.front;
            while (curr != null)
            {
                file1.WriteLine(curr.data);
                file1.WriteLine(curr.priority);
                curr = curr.next;
            }
            file1.Close();
            m1.front = null;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select_User log = new Select_User();
            log.Show();
        }

        private void most_searched_Click(object sender, EventArgs e)
        {
            this.Hide();
            Most_Clicked f = new Most_Clicked();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Read_Priority_file();
            count1 = 0;
            obj.Root = null;
            l1.head = null;
            display.Text = "";
            Read_Search_file();
            if (obj.Get_Root() == null)
            {
                MessageBox.Show("Data Not Found in AVL");
            }
            else
            {
                int length;
                string str1, str2 = "";
                str1 = textBox1.Text + " ";
                length = str1.Length;
                for (int i = 0; i < length; i++)
                {
                    if (str1[i] == ' ')
                    {
                        Inorder(obj.Get_Root(), str2);
                        str2 = "";
                    }
                    else
                    {
                        str2 += str1[i];
                    }
                }
                node temp3 = l1.head;
                if (temp3 == null)
                {
                    MessageBox.Show("Keyword Not Found");
                }
                else
                {
                    node curr = m2.front;
                    display.Text = "Webpages " + "\t\t\t" + "Match Keyword" + "\r\n";
                    while (curr != null)
                    {
                        display.Text += curr.data + "\t\t\t" + curr.priority + "\r\n";
                        curr = curr.next;
                    }
                }
            }
            textBox1.Text = "";
            Write_in_Priority_file();
        }
        public void Inorder(node Root, string key)
        {
            if (Root != null)
            {
                Inorder(Root.left_Child, key);
                temp1 = search_node(Root, key);
                if (temp1 != null)
                {
                    //MessageBox.Show("linkedlist");
                    l1.Add_Node(temp1.webpage, temp1.keyword);
                    if (count==1)
                    {
                        count4++;
                        m2.Enqueue(temp1.webpage, count4);
                        count2 = 0;
                        count1 = 0;
                    }
                    else
                    {
                        temp4 = m2.Searching_By_Data(temp1.webpage);
                        if (temp4 != null)
                        {
                            temp4.priority++;
                            //MessageBox.Show("greater input " + temp3.priority);
                        }
                        else
                        {
                            count4++;
                            m2.Enqueue(temp1.webpage, count4);
                            //MessageBox.Show("least input " + count2);
                            count4 = 0;
                        }
                    }
                    temp2 = null;
                }
                Inorder(Root.right_Child, key);
            }
        }
        public bool check(string ptr_key, string key)
        {
            int l1, l2;
            l1 = ptr_key.Length;
            l2 = key.Length;
            if (l1 == l2)
            {
                for (int i = 0; i < ptr_key.Length; i++)
                {
                    if (ptr_key[i] == key[i])
                    {
                        ch = true;
                    }
                    else
                    {
                        ch = false;
                        break;
                    }
                }
            }
            else
            {
                ch = false;
            }
            return ch;
        }

        public node search_node(node ptr, string key)
        {
            if (ptr == null)
                return null;
            else if (ptr.keyword == key)
            {
                ch = check(ptr.keyword, key);
            }
            if (ch == true)
            {
                temp2 = ptr;
                ch = false;
            }
            return temp2;
        }
    }
}
