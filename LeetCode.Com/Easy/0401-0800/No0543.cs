/**************************************************************
 * 创建时间：2023-09-15 11:23:15
 * 创建人：  akalin
 * 创建说明：
***************************************************************/

using LeetCode.Com.Com;
using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Diameter of Binary Tree
    /// </summary>
    public class No0543
    {
        /// <summary>
        /// 遍历所有路径，返回最大长度
        /// </summary>
        public int DiameterOfBinaryTree(TreeNode root)
        {
            int depth = 0;
            MaxDepth(root, ref depth);
            return depth;
        }

        private int MaxDepth(TreeNode root, ref int depth)
        {
            if (root == null)
            {
                return 0;
            }
            int left = MaxDepth(root.left, ref depth);
            int right = MaxDepth(root.right, ref depth);
            depth = Math.Max(depth, left + right);
            return Math.Max(left, right) + 1;
        }
    }
}
