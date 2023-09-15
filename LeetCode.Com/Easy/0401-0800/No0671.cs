using LeetCode.Com.Com;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Second Minimum Node In a Binary Tree
    /// </summary>
    internal class No0671
    {
        /*
            解题思路：按题目意思，根节点一点是最小值。遍历整个树。找到大于根节点的最小值即可。
         */
        public int FindSecondMinimumValue(TreeNode root)
        {
            int secondMinimumValue = -1;
            int rootValue = root.val;

            FindSecondMinimumValue(root, ref secondMinimumValue, rootValue);

            return secondMinimumValue;
        }

        private void FindSecondMinimumValue(TreeNode node, ref int secondMinimumValue, int rootValue)
        {

            if (node == null)
            {
                return;
            }

            if (secondMinimumValue == -1)
            {
                if (node.val > rootValue)
                {
                    secondMinimumValue = node.val;
                }
            }
            else
            {
                if (node.val > rootValue && node.val < secondMinimumValue)
                {
                    secondMinimumValue = node.val;
                }
            }

            FindSecondMinimumValue(node.left, ref secondMinimumValue, rootValue);

            FindSecondMinimumValue(node.right, ref secondMinimumValue, rootValue);

        }
    }
}
