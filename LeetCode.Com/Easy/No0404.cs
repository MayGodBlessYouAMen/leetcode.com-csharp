using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [404]  Sum of Left Leaves
    /// </summary>
    public class No0404
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

        public int SumOfLeftLeaves(TreeNode root)
        {

            //1.1 若root左孩子为叶子，则sum left.val。
            //1.2 若root左孩子为树，则继续递归
            //2.1 右孩子继续递归

            if (root == null)
            {
                return 0;
            }

            int left = 0;
            int right = 0;
            if (root.left != null && root.left.left == null && root.left.right == null)
            {
                left = root.left.val;
            }
            else
            {
                //左子树递归
                left = SumOfLeftLeaves(root.left);
            }

            //右子树递归
            right = SumOfLeftLeaves(root.right);

            return left + right;
        }
    }
}
