using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Search in a Binary Search Tree
    /// </summary>
    internal class No0700
    {
        /*
            解题思路: BST是排序好的树。所以每次和根节点的值比较之后，可以放弃其中一侧的节点。
         */
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root.val == val)
            {
                return root;
            }

            //val比根节点大，那么去左子树找
            if (root.val > val && root.left != null)
            {
                return SearchBST(root.left,val);
            }

            //val比根节点小，那么去右子树找
            if (root.val < val && root.right != null)
            {
                return SearchBST(root.right, val);
            }

            //没有找到，返回null
            return null;
        }
    }
}
