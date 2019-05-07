using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Invert Binary Tree
    /// </summary>
    public class No0226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            //反转二叉树，可以用递归
            InvertBinaryTree(root);
            return root;
        }

        public void InvertBinaryTree(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            //交换当前节点的左右节点
            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;

            //递归
            InvertBinaryTree(node.left);
            InvertBinaryTree(node.right);
        }
    }
}
