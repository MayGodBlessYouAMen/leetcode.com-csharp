using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Leaf-Similar Trees
    /// </summary>
    internal class No0872
    {
        /*
            解题思路： 两棵树分别做中序遍历，保留叶子列表。然后比较两个列表是否相等

                注意:叶子节点序列的值和顺序都要相同才返回true
         */
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> list1 = new List<int>();
            GetLeaves(root1, ref list1);

            List<int> list2 = new List<int>();
            GetLeaves(root2, ref list2);

            return list1.ToArray().SequenceEqual(list2.ToArray());
        }

        private void GetLeaves(TreeNode root, ref List<int> list)
        {
            if (root == null)
            {
                return;
            }

            //左遍历
            if (root.left != null)
            {
                GetLeaves(root.left,ref list);
            }

            //中--叶子判断
            if (root.left == null && root.right == null)
            {
                list.Add(root.val);
            }

            //右遍历
            if (root.right != null)
            {
                GetLeaves(root.right, ref list);
            }
        }
    }
}
