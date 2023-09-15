using LeetCode.Com.Com;
using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Minimum Absolute Difference in BST
    /// </summary>
    internal class No0530
    {
        /*
            因为BST性质：左<根<右。中序便利能得到一个有序数组。最小绝对差会在相邻的两个节点之间产生。
            
            题目规定了 0 <= Node.val <= 10^5 ，节点初始值可以设置为-1，表示未初始化
         */

        public int GetMinimumDifference(TreeNode root)
        {
            int pre = -1;
            int res = int.MaxValue;

            Find(root, ref pre, ref res);

            return res;
        }

        //中序遍历
        private void Find(TreeNode root, ref int pre, ref int res)
        {
            if (root == null)
            {
                return;
            }

            //左
            Find(root.left, ref pre, ref res);

            //根
            if (pre == -1)
            {
                //第一个节点，给初始值
                pre = root.val;
            }
            else
            {
                //当前节点和前一个节点求差，并和之前的差比较，取较小的值
                var temp = root.val - pre;
                res = Math.Min(res, temp);

                //更新
                pre = root.val;
            }

            //右
            Find(root.right, ref pre, ref res);
        }
    }
}
