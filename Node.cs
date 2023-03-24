using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class node
    {
         public int height,count,priority;
         public string username, password, webpage,keyword,data;
         public node next, left_Child, right_Child;
        public node()
        {
            height = 0;
            username = null;
            password = null;
            webpage = null;
            keyword = null;
            next = null;
            left_Child = null;
            right_Child = null;
            priority = 0;
            data = null;
        }
        public node(string user, string pass)
        {
            this.username = user;
            this.password = pass;
            this.next = null;
        }
        public node(string web,string key,int k)
        {
            this.webpage = web;
            this.keyword = key;
            this.count = k;
            this.left_Child = null;
            this.right_Child = null;
            this.height = 1;
        }
        public node(string d,int p)
        {
            this.data = d;
            this.priority = p;
            this.next = null;
        }
    }
}
