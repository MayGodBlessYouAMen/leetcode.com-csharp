using LeetCode.Com.Com;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Minimum Distance Between BST Nodes
    /// </summary>
    internal class No0783
    {
        /*
            解体思路：
                利用BST的有序特性。中序遍历能得到一个升序数组。
                有序数组最小差值一定会在相邻两个元素直间产生，遍历一边求差即可。

                给定树的节点范围[2,100]
         */
        public int MinDiffInBST(TreeNode root)
        {
            //获取有序数组
            List<int> list = new List<int>();

            InOrderTraversal(root, ref list);

            int minDiff = -1;

            for (int i = 1; i < list.Count; i++)
            {
                if (minDiff == -1)
                {
                    minDiff = list[i] - list[i - 1];
                    continue;
                }

                if (list[i] - list[i - 1] < minDiff)
                {
                    minDiff = list[i] - list[i - 1];
                }
            }

            return minDiff;
        }

        private void InOrderTraversal(TreeNode root, ref List<int> list)
        {
            if (root == null)
            {
                return;
            }

            //左
            InOrderTraversal(root.left, ref list);

            //根
            list.Add(root.val);

            //右
            InOrderTraversal(root.right, ref list);

        }
    }
}
