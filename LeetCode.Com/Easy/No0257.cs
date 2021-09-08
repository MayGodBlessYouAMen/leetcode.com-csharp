using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Binary Tree Paths
    /// </summary>
    public class No0257
    {
        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         *         this.val = val;
         *         this.left = left;
         *         this.right = right;
         *     }
         * }
         */

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> list = new List<string>();

            if (root == null)
            {
                return list;
            }

            string head = root.val.ToString();

            if (root.left == null && root.right == null)
            {
                list.Add(head);
                return list;
            }

            if (root.left != null)
            {
                BinaryTreePaths(root.left, head, list);
            }

            if (root.right != null)
            {
                BinaryTreePaths(root.right, head, list);
            }

            return list;
        }

        private void BinaryTreePaths(TreeNode node, string head, IList<string> list)
        {
            if (node == null)
            {
                return;
            }

            head = $"{head}->{node.val}";

            if (node.left == null && node.right == null)
            {
                list.Add(head);
                return;
            }

            if (node.left != null)
            {
                BinaryTreePaths(node.left, head, list);
            }

            if (node.right != null)
            {
                BinaryTreePaths(node.right, head, list);
            }
        }
    }
}
