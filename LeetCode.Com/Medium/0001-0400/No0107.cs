using LeetCode.Com.Com;
using System.Collections.Generic;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// [107]Binary Tree Level Order Traversal II
    /// </summary>
    public class No0107
    {
        /*
         * @lc app=leetcode id=107 lang=csharp
         *
         * [107] Binary Tree Level Order Traversal II
         *
         * https://leetcode.com/problems/binary-tree-level-order-traversal-ii/description/
         *
         * algorithms
         * Easy (45.74%)
         * Total Accepted:    211.6K
         * Total Submissions: 462.2K
         * Testcase Example:  '[3,9,20,null,null,15,7]'
         *
         * Given a binary tree, return the bottom-up level order traversal of its
         * nodes' values. (ie, from left to right, level by level from leaf to root).
         * 
         * 
         * For example:
         * Given binary tree [3,9,20,null,null,15,7],
         * 
         * ⁠   3
         * ⁠  / \
         * ⁠ 9  20
         * ⁠   /  \
         * ⁠  15   7
         * 
         * 
         * 
         * return its bottom-up level order traversal as:
         * 
         * [
         * ⁠ [15,7],
         * ⁠ [9,20],
         * ⁠ [3]
         * ]
         * 
         * 
         */

        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int x) { val = x; }
         * }
         */

        Queue<TreeNode> queue1 = new Queue<TreeNode>();
        Queue<TreeNode> queue2 = new Queue<TreeNode>();

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null)
            {
                return list;
            }
            //广度优先遍历，用队列存储下一层的节点
            Queue<TreeNode> currentqueue = queue1;

            currentqueue.Enqueue(root);
            while (currentqueue.Count > 0)
            {
                IList<int> sublist = DoSome(ref currentqueue);
                //倒序添加
                list.Insert(0, sublist);
            }

            return list;
        }

        private IList<int> DoSome(ref Queue<TreeNode> currentqueue)
        {
            IList<int> sublist = new List<int>();
            var tempqueue = currentqueue;
            currentqueue = queue1.Count == 0 ? queue1 : queue2;
            while (tempqueue.Count > 0)
            {
                var treenode = tempqueue.Dequeue();
                sublist.Add(treenode.val);
                if (treenode.left != null)
                {
                    currentqueue.Enqueue(treenode.left);
                }
                if (treenode.right != null)
                {
                    currentqueue.Enqueue(treenode.right);
                }
            }
            return sublist;
        }
    }
}
