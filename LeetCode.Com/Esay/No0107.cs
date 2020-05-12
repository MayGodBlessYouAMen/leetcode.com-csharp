using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Binary Tree Level Order Traversal II
    /// </summary>
    public class No0107
    {
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
