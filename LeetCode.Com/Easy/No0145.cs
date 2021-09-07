using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// 后序遍历
    /// </summary>
    public class No0145
    {
        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         *         this.val = val;
         *         this.left = left;
         *         this.right = right;
         *     }
         * }
         */

        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();

            if (root != null)
            {
                if (root.left != null)
                {
                    PostorderTraversal(list, root.left);
                }

                if (root.right != null)
                {
                    PostorderTraversal(list, root.right);
                }

                list.Add(root.val);
            }

            return list;
        }

        private void PostorderTraversal(IList<int> list, TreeNode node)
        {
            if (node != null)
            {
                if (node.left != null)
                {
                    PostorderTraversal(list, node.left);
                }

                if (node.right != null)
                {
                    PostorderTraversal(list, node.right);
                }

                list.Add(node.val);
            }
        }
    }
}
