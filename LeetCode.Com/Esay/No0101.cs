using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Symmetric Tree
    /// </summary>
    public class No0101
    {
        /**
        * Definition for a binary tree node.
        * public class TreeNode {
        *     public int val;
        *     public TreeNode left;
        *     public TreeNode right;
        *     public TreeNode(int x) { val = x; }
        * }
        */

        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSymmetric(root.left, root.right);
        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if ((left == null && right != null) || (left != null && right == null) )
            {
                return false;
            }

            if (left.val != right.val)
            {
                return false;
            }

            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
    }
}
