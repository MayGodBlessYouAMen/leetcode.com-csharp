using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [1022]  Sum of Root To Leaf Binary Numbers
    /// </summary>
    public class No1022
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

        public int SumRootToLeaf(TreeNode root)
        {
            /*由题目示例可知，给的input是一个前序遍历的二叉树
             *题意是想列举所有从根节点到子节点的路径，然后求和
            */

            if (root == null) return 0;

            //用于记录所有路径
            List<List<int>> allroad = new List<List<int>>();

            //初始化根节点
            List<int> oneroad = new List<int>();
            allroad.Add(oneroad);

            GetRoadList(root, allroad, oneroad);

            //计算所有路径之和
            int sum = 0;
            foreach (var road in allroad)
            {
                sum += SumBinaryList(road);
            }
            return sum;
        }

        /// <summary>
        /// 递归记录所有路径
        /// </summary>
        /// <param name="node"></param>
        /// <param name="allroad"></param>
        /// <param name="oneroad"></param>
        private void GetRoadList(TreeNode node, List<List<int>> allroad, List<int> oneroad)
        {
            //添加根节点值
            oneroad.Add(node.val);

            if (node.left != null || node.right != null)
            {
                //移除之前的路径，因为要分左右树了
                allroad.Remove(oneroad);
            }

            if (node.left != null)
            {
                //根据前路径复制出来给左子树用
                List<int> left = new List<int>(oneroad);
                allroad.Add(left);
                GetRoadList(node.left, allroad, left);
            }

            if (node.right != null)
            {
                //根据前路径复制出来给右子树用
                List<int> right = new List<int>(oneroad);
                allroad.Add(right);
                GetRoadList(node.right, allroad, right);
            }
        }

        private int SumBinaryList(List<int> binarylist)
        {
            int sum = 0;
            for (int i = 0; i < binarylist.Count; i++)
            {
                sum += binarylist[i] * (int)Math.Pow(2, binarylist.Count - 1 - i);
            }
            return sum;
        }
    }
}
