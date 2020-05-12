using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Path Sum
    /// </summary>
    public class No0112
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null && root.val == sum)
            {
                return true;
            }
            //简单递归
            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
    }
}
