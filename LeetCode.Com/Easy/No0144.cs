using LeetCode.Com.Com;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// 前序遍历
    /// </summary>
    public class No0144
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

        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();

            if (root != null)
            {
                list.Add(root.val);

                if (root.left != null)
                {
                    PreorderTraversal(list, root.left);
                }

                if (root.right != null)
                {
                    PreorderTraversal(list, root.right);
                }
            }

            return list;
        }

        private void PreorderTraversal(IList<int> list, TreeNode node)
        {
            if (node != null)
            {
                list.Add(node.val);

                if (node.left != null)
                {
                    PreorderTraversal(list, node.left);
                }

                if (node.right != null)
                {
                    PreorderTraversal(list, node.right);
                }
            }
        }
    }
}
