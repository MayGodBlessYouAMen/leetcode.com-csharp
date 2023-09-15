using LeetCode.Com.Com;
using System;

namespace LeetCode.Com.Easy
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

    public class No0110
    {
        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int leftDepth = Depth(root.left);
            int rigthDepth = Depth(root.right);

            if (Math.Abs(leftDepth - rigthDepth) <= 1 &&
                IsBalanced(root.left) &&
                IsBalanced(root.right))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 计算树高度（递归）
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int Depth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return Math.Max(Depth(node.left), Depth(node.right)) + 1;
        }
    }
}
