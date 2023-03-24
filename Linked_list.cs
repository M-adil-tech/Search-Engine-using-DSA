using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Linked_list
    {
        public
           node head, tail;
           bool ch = false;
        public
            Linked_list()
        {
            head = tail = null;
        }
        // Add node in the linked list
        // when head is null
        public void Add_Node(string user,string pass)
        {
            node NewNode = new node(user,pass);
            if (head == null)
            {
                head = NewNode;
                tail = head;
            }
            else
            {
                tail.next = NewNode;
                tail = NewNode;
            }
        }
        // deletion from the linked list
        public bool Deletion(string user)
        {
            node temp4 =  head;
            while (temp4 != null)
            {
                if (temp4.username == user)
                {
                    break;
                }
                else
                    temp4 = temp4.next;
            }
            if(temp4==null)
            {
                ch = false;
            }
            else
            {
                if (temp4 == head)
                {
                    head = head.next;
                }
                else if (temp4 == tail)
                {
                    node temp2 = head;
                    while (temp2 != null)
                    {
                        if (temp2.next == temp4)
                            break;
                        else
                            temp2 = temp2.next;
                    }
                    tail = temp2;
                    tail.next = null;
                }
                else
                {
                    node temp3 = head;
                    while (temp3 != null)
                    {
                        if (temp3.next == temp4)
                            break;
                        else
                            temp3 = temp3.next;
                    }
                    temp3.next = temp4.next;
                }
                temp4 = null;
                ch = true;
            }
            return ch;
        }
       public bool Search_Data(string user,string pass)
        {
            node temp = head;
            while (temp != null)
            {
                if (temp.username == user && temp.password==pass)
                    break;
                else
                    temp = temp.next;
            }
            if(temp==null)
            {
                return false;
            }
            else
            {
                return true; 
            }
        }
    };
}
