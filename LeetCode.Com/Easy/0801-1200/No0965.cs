using LeetCode.Com.Com;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Univalued Binary Tree
    /// </summary>
    internal class No0965
    {
        /*
         *  Univalued二叉树的定义：所有node的值相等。
         *  
            解题思路：遍历所有节点，和root值比较即可
                
         */
        public bool IsUnivalTree(TreeNode root)
        {
            int rootVal = root.val;

            bool isUnival = true;

            IsUnivalTree(root, rootVal, ref isUnival);

            return isUnival;
        }

        private void IsUnivalTree(TreeNode node, int rootVal, ref bool isUnival)
        {
            //只要有一个节点不相等，比较结束
            if (!isUnival)
            {
                return;
            }

            if (node.val != rootVal)
            {
                isUnival = false;
                return;
            }

            if (node.left != null)
            {
                IsUnivalTree(node.left, rootVal, ref isUnival);
            }

            if (node.right != null)
            {
                IsUnivalTree(node.right, rootVal, ref isUnival);
            }

        }
    }
}
