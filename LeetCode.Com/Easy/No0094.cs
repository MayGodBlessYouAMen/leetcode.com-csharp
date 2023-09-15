using LeetCode.Com.Com;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
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

    /// <summary>
    /// Binary Tree Inorder Traversal
    /// </summary>
    public class No0094
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();

            if (root != null)
            {
                if (root.left != null)
                {
                    JustDoIt(root.left, list);
                }

                list.Add(root.val);

                if (root.right != null)
                {
                    JustDoIt(root.right, list);
                }
            }

            return list;
        }

        public void JustDoIt(TreeNode node, IList<int> list)
        {
            if (node != null)
            {
                if (node.left != null)
                {
                    JustDoIt(node.left, list);
                }

                list.Add(node.val);

                if (node.right != null)
                {
                    JustDoIt(node.right, list);
                }
            }
        }
    }
}
