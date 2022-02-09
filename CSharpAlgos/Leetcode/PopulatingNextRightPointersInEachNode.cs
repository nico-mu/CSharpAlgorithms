using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    internal class PopulatingNextRightPointersInEachNode
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }
            if (root.left == null || root.right == null)
            {
                return root;
            }
            ConnectHelper(root);
            return root;
        }

        public void ConnectHelper(Node root)
        {
            if (root.left == null || root.right == null) return;
            root.left.next = root.right;
            if (root.next != null) root.right.next = root.next.left;
            Connect(root.right);
            Connect(root.left);
        }
    }
}
