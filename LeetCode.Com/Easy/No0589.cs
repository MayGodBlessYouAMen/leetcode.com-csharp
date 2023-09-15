using LeetCode.Com.Com;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// N-ary Tree Preorder Traversal
    /// </summary>
    internal class No0589
    {
        /*
            n叉树的前序遍历。首先想到的是递归
         */
        public IList<int> Preorder(Node root)
        {
            IList<int> list = new List<int>();

            Preorder(root, ref list);

            return list;
        }

        private void Preorder(Node root, ref IList<int> list)
        {
            if (root == null)
            {
                return;
            }

            list.Add(root.val);

            if (root.children?.Count > 0)
            {
                foreach (Node child in root.children)
                {
                    Preorder(child, ref list);
                }
            }
        }
    }
}
