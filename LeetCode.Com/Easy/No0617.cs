using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [617]  Merge Two Binary Trees
    /// </summary>
    public class No0617
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

        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return null;
            TreeNode t3 = new TreeNode(0);
            MergeTrees(t1, t2, t3);
            return t3;
        }

        /// <summary>
        /// 递归合并
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        private void MergeTrees(TreeNode t1, TreeNode t2, TreeNode t3)
        {
            //先合并根节点
            if (t1 != null) t3.val += t1.val;
            if (t2 != null) t3.val += t2.val;

            //递归左子树
            if ((t1 != null && t1.left != null) || (t2 != null && t2.left != null))
            {
                t3.left = new TreeNode(0);
                MergeTrees(t1 == null ? null : t1.left, t2 == null ? null : t2.left, t3.left);
            }

            //递归右子树
            if ((t1 != null && t1.right != null) || (t2 != null && t2.right != null))
            {
                t3.right = new TreeNode(0);
                MergeTrees(t1 == null ? null : t1.right, t2 == null ? null : t2.right, t3.right);
            }
        }
    }
}
