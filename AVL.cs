using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    public class AVL
    {
        public 
            node Root;
        public
    AVL()
        {
            this.Root = null;
        }
        public node Get_Root()
        {
            return Root;
        }
        public int Get_Height_Of_Node(node Root)
        {
            if (Root == null)
                return 0;
            else
                return Root.height;
        }
        public int Get_Max_Height(int left_Child_Height, int right_Child_Height)
        {
            if (left_Child_Height > right_Child_Height)
                return left_Child_Height;
            else
                return right_Child_Height;
        }
        public int Balance_The_Node(node Root)
        {
            if (Root == null)
                return 0;
            else
                return Get_Height_Of_Node(Root.left_Child) - Get_Height_Of_Node(Root.right_Child);
        }
        public node Rotate_Right(node Root)
        {
            node newroot = Root.left_Child;
            node temp = newroot.right_Child;
            newroot.right_Child = Root;
            Root.left_Child = temp;
            Root.height = Get_Max_Height(Get_Height_Of_Node(Root.left_Child), Get_Height_Of_Node(Root.right_Child)) + 1;
            newroot.height = Get_Max_Height(Get_Height_Of_Node(newroot.left_Child), Get_Height_Of_Node(newroot.right_Child)) + 1;
            return newroot;
        }

        public node Rotate_Left(node Root)
        {

            node newroot = Root.right_Child;
            node temp = newroot.left_Child;
            newroot.left_Child = Root;
            Root.right_Child = temp;
            Root.height = Get_Max_Height(Get_Height_Of_Node(Root.left_Child), Get_Height_Of_Node(Root.right_Child)) + 1;
            newroot.height = Get_Max_Height(Get_Height_Of_Node(newroot.left_Child), Get_Height_Of_Node(newroot.right_Child)) + 1;
            return newroot;
        }
        public void insert(string web, string key,int count)
        {
            Root = Add_Node(Root, web, key,count);
        }
        public node Add_Node(node Root, string web, string key,int count)
        {
            if (Root == null)
            {
                node New_Node = new node(web, key, count);
                return New_Node;
            }
            else if (count > Root.count)
            {
                Root.right_Child = Add_Node(Root.right_Child, web, key,count);
            }
            else if (count < Root.count)
            {
                Root.left_Child = Add_Node(Root.left_Child, web, key,count);
            }

            Root.height = Get_Max_Height(Get_Height_Of_Node(Root.left_Child), Get_Height_Of_Node(Root.right_Child)) + 1;

            // Get balance of both left and right child
            // by method of (Height of left subtree - Height of right subtree)

            int Node_Balance = Balance_The_Node(Root);

            // In this condition rotate the AVL
            // in right side

            if (Node_Balance > 1 && count < Root.left_Child.count)
            {
                return Rotate_Right(Root);
            }

            // In this condition rotate the AVL
            // in left side

            if (Node_Balance < -1 && count > Root.right_Child.count)
            {
                return Rotate_Left(Root);
            }

            // In this condition rotate the AVL
            // in firstly left then right 

            if (Node_Balance > 1 && count > Root.left_Child.count)
            {
                Root.left_Child = Rotate_Left(Root.left_Child);
                return Rotate_Right(Root);
            }

            // In this condition rotate the AVL
            // in firstly right then left 

            if (Node_Balance < -1 && count < Root.right_Child.count)
            {
                Root.right_Child = Rotate_Right(Root.right_Child);
                return Rotate_Left(Root);
            }

            return Root;
        }
    }
}
