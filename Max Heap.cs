using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Max_Heap
    {
		public
			node front, find = null;
		public
	Max_Heap()
		{
			front = null;
		}
		public void Enqueue(string str, int priority)
		{
			node ptr = new node(str, priority);
			if (isEmpty() == true)
			{
				front = ptr;
			}
			else if (front.priority < priority)
			{
				ptr.next = front;
				front = ptr;
			}
			else
			{
				node temp = front;
				while (temp.next != null && temp.next.priority >= priority)
				{
					temp = temp.next;
				}
				ptr.next = temp.next;
				temp.next = ptr;
			}
		}
		public void Dequeue()
		{
			if (isEmpty() == true)
			{
				return;
			}
			else
			{
				node temp = front;
				front = front.next;
				temp = null;
			}
		}
		public bool isEmpty()
		{
			if (front == null)
				return true;
			else
				return false;
		}
		public string peek()
		{
			return front.data;
		}
		public node Searching_By_Data(string x)
		{
			node temp = front;
			Max_Heap obj = new Max_Heap();
			while (temp != null)
			{
				if (temp.data == x)
					break;
				else
				{
					obj.Enqueue(temp.data, temp.priority);
					this.Dequeue();
					temp = temp.next;
				}
			}
			if (temp == null)
			{
				find = null;//cout << "Data Not Found" << endl;
			}
			else if (temp.data == x)
			{
				find = temp;
				//cout << "Data Is = " << temp->data << endl;
			}
			temp = obj.front;
			while (temp != null)
			{
				this.Enqueue(temp.data, temp.priority);
				obj.Dequeue();
				temp = temp.next;
			}
			return find;
		}
		public void Searching_By_Priority(int x)
		{
			node temp = front;
			Max_Heap obj = null;
			while (temp != null)
			{
				if (temp.priority == x)
					break;
				else
				{
					obj.Enqueue(temp.data, temp.priority);
					this.Dequeue();
					temp = temp.next;
				}
			}
			if (temp == null)
			{
				//cout << "Data Not Found" << endl;
			}
			else if (temp.priority == x)
			{
				//cout << "Data Is = " << temp->data << endl;
			}
			temp = obj.front;
			while (temp != null)
			{
				this.Enqueue(temp.data, temp.priority);
				obj.Dequeue();
				temp = temp.next;
			}
		}
	}
}
