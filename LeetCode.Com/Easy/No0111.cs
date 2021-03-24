using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Minimum Depth of Binary Tree
    /// 
    /// 借鉴了No0107的广度遍历
    /// </summary>
    public class No0111
    {
        public int MinDepth(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null)
            {
                return 0;
            }

            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            Queue<TreeNode> currentqueue = queue1;
            int depth = 0;
            bool findleaf = false;

            currentqueue.Enqueue(root);
            while (currentqueue.Count > 0)
            {
                depth++;
                var tempqueue = currentqueue;
                currentqueue = queue1.Count == 0 ? queue1 : queue2;

                while (tempqueue.Count > 0)
                {
                    var treenode = tempqueue.Dequeue();
                    if (treenode.left == null && treenode.right == null)
                    {
                        //找到叶子（左右都是null），跳出循环
                        findleaf = true;
                        break;
                    }
                    if (treenode.left!= null)
                    {
                        currentqueue.Enqueue(treenode.left);    
                    }
                    if (treenode.right != null)
                    {
                        currentqueue.Enqueue(treenode.right);
                    }
                }
                if (findleaf)
                {
                    break;
                }
            }

            return depth;
        }

    }
}
