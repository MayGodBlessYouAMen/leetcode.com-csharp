using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Construct String from Binary Tree
    /// </summary>
    internal class No0606
    {
        /*
            解题思路:前序遍历，递归，子节点加上括号，即可
            注意:如果右子树为空,要省略右子树括号。但是只有左子树为空，左子树括号不能省略。
         */

        public string Tree2str(TreeNode root)
        {
            if (root == null)
            {
                return "";
            }

            if (root.left == null && root.right == null)
            {
                return root.val.ToString();
            }

            var left = $"({Tree2str(root.left)})";
            var right = "";
            if (root.right != null)
            {
                right = $"({Tree2str(root.right)})";
            }

            return $"{root.val}{left}{right}";
        }

    }
}
