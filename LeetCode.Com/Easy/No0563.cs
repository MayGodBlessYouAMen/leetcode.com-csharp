using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// 563. Binary Tree Tilt
    /// </summary>
    internal class No0563
    {
        public int FindTilt(TreeNode root)
        {
            /*此题适合后序遍历*/

            int res = 0;

            SumNode(root, ref res);

            return res;
        }

        private int SumNode(TreeNode root, ref int res)
        {
            if (root == null)
            {
                return 0;
            }

            int left = SumNode(root.left, ref res);
            int right = SumNode(root.right, ref res);
            int abs = Math.Abs(left - right);

            res += abs;

            return root.val + left + right;
        }
    }
}
