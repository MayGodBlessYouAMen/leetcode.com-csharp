using LeetCode.Com.Com;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Cousins in Binary Tree
    /// </summary>
    public class No0993
    {
        /*
         *   堂兄节点的定义：1.两个节点深度相同 2.两个节点父亲不同
             解题思路：遍历树，记录找到的x和y的层深和父节点，最后做比较。
                
             注意：每个节点的值都不想等
         */

        TreeNode xParent;
        TreeNode yParent;
        int xDeep = -1;
        int yDeep = -1;
        public bool IsCousins(TreeNode root, int x, int y)
        {
            Traversal(root, x, y, null, 0);
            return xDeep == yDeep && xParent != yParent;
        }

        private void Traversal(TreeNode root, int x, int y, TreeNode parent, int deep)
        {
            if (root == null)
            {
                return;
            }

            if (root.val == x)
            {
                xParent = parent;
                xDeep = deep;
            }

            if (root.val == y)
            {
                yParent = parent;
                yDeep = deep;
            }

            //已经找到x和y的位置，结束递归
            if (xDeep >= 0 && yDeep >= 0)
            {
                return;
            }

            Traversal(root.left, x, y, root, deep + 1);
            Traversal(root.right, x, y, root, deep + 1);
        }
    }
}
