using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Com
{
    /// <summary>
    /// 工具类
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// 根据前序遍历数组创建二叉树
        /// [1,2,2,3,4,4,3]
        /// [1,2,2,null,3,null,3]
        /// </summary>
        /// <param name="numberlist"></param>
        /// <returns></returns>
        public static TreeNode CreateTreeNode(List<string> numberlist)
        {
            TreeNode root = null;
            root = CreateTreeNode(root, numberlist, 0);
            return root;
        }

        private static TreeNode CreateTreeNode(TreeNode node, List<string> numberlist, int index)
        {
            if (index >= numberlist.Count)
            {
                return null;
            }

            if (numberlist[index].Equals("null", StringComparison.InvariantCultureIgnoreCase))
            {
                node = null;
                return null;
            }

            node = new TreeNode(int.Parse(numberlist[index]));
            node.left = CreateTreeNode(node.left, numberlist, 2 * index + 1);
            node.right = CreateTreeNode(node.right, numberlist, 2 * index + 2);

            return node;
        }

        public static TreeNode CreateTreeNode(List<int> numberlist)
        {
            TreeNode root = null;
            root = CreateTreeNode(root, numberlist, 0);
            return root;
        }

        private static TreeNode CreateTreeNode(TreeNode node, List<int> numberlist, int index)
        {
            if (index >= numberlist.Count)
            {
                return null;
            }

            node = new TreeNode(numberlist[index]);
            node.left = CreateTreeNode(node.left, numberlist, 2 * index + 1);
            node.right = CreateTreeNode(node.right, numberlist, 2 * index + 2);

            return node;
        }
    }
}
