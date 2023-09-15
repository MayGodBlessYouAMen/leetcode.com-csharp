using LeetCode.Com.Com;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Maximum Depth of Binary Tree
    /// </summary>
    public class No0104
    {
        public int MaxDepth(TreeNode root)
        {
            int leftDepth = 1;
            int rightDepth = 1;

            if (root == null)
            {
                return 0;
            }

            if (root.left != null)
            {
                leftDepth = MaxDepth(root.left) + 1;
            }

            if (root.right != null)
            {
                rightDepth = MaxDepth(root.right) + 1;
            }

            return leftDepth >= rightDepth ? leftDepth : rightDepth;
        }
    }
}
