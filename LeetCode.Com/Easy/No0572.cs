using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Subtree of Another Tree
    /// </summary>
    internal class No0572
    {

        /*
            求一棵二叉树是否为另外一棵的子树；
            示例2可以看出子树必须从叶子节点开始；
            可以这样比较：从某个节点开始，两棵树是否完全相同
            简单的树递归
         */
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null)
            {
                return false;
            }

            if (IsSame(root, subRoot))
            {
                return true;
            }

            return IsSubtree(root.left, subRoot) ||
                    IsSubtree(root.right, subRoot);
        }

        private bool IsSame(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null)
            {
                return true;
            }

            if (root == null || subRoot == null)
            {
                return false;
            }

            if (root.val != subRoot.val)
            {
                return false;
            }

            return IsSame(root.left, subRoot.left) &&
                    IsSame(root.right, subRoot.right);
        }
    }
}
