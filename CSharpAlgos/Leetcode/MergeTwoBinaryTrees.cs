using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return null;
            int val = (root1 == null ? 0 : root1.val) + (root2 == null ? 0 : root2.val);
            TreeNode root = new TreeNode(val);
            root.left = MergeTrees(root1?.left, root2?.left);
            root.right = MergeTrees(root1?.right, root2?.right);
            return root;
        }
    }
}
