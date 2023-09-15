using LeetCode.Com.Com;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// N-ary Tree Postorder Traversal
    /// </summary>
    internal class No0590
    {
        /*
            n叉树的后续遍历
            参考no0589,使用递归
         */
        public IList<int> Postorder(Node root)
        {
            IList<int> list = new List<int>();

            Postorder(root, ref list);

            return list;
        }

        private void Postorder(Node root, ref IList<int> list)
        {
            if (root == null)
            {
                return;
            }

            if (root.children?.Count > 0)
            {
                foreach (Node child in root.children)
                {
                    Postorder(child, ref list);
                }
            }

            list.Add(root.val);
        }
    }
}
