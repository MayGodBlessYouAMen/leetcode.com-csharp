using LeetCode.Com.Com;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [938]  Range Sum of BST
    /// </summary>
    public class No0938
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;
            if (root != null) sum = MidSearch(root, L, R);

            return sum;
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <param name="L"></param>
        /// <param name="R"></param>
        /// <returns></returns>
        private int MidSearch(TreeNode root, int L, int R)
        {
            int sum = 0;
            if (root.left != null) sum += MidSearch(root.left, L, R);
            if (root.val >= L && root.val <= R) sum += root.val;
            if (root.right != null) sum += MidSearch(root.right, L, R);
            return sum;
        }
    }
}
