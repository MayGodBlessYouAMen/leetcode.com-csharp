using LeetCode.Com.Com;
using System;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Two Sum IV - Input is a BST
    /// </summary>
    internal class No0653
    {
        /*
            解题思路：
                二叉查找树，中序遍历能得到一个排序好的数组。
                然后通过双指针遍历求和
         */
        public bool FindTarget(TreeNode root, int k)
        {
            List<int> list = new List<int>();

            BSTToList(root, ref list);

            return FindTarget(list, k);
        }

        /// <summary>
        /// bst转list
        /// </summary>
        /// <param name="root"></param>
        /// <param name="list"></param>
        private void BSTToList(TreeNode root, ref List<int> list)
        {
            if (root == null)
            {
                return;
            }

            BSTToList(root.left, ref list);
            list.Add(root.val);
            BSTToList(root.right, ref list);
        }

        /// <summary>
        /// 判断list中是否有两个数之和等于k
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool FindTarget(List<int> list, int k)
        {
            for (int i = 0, j = list.Count - 1; i < j;)
            {
                if (list[i] + list[j] == k)
                {
                    return true;
                }

                if (list[i] + list[j] < k)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return false;
        }
    }
}
