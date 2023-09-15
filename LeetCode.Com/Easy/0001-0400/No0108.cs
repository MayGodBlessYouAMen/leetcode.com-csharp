using LeetCode.Com.Com;
using System.Linq;

namespace LeetCode.Com.Easy
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
     *         this.val = val;
     *         this.left = left;
     *         this.right = right;
     *     }
     * }
     */

    public class No0108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return null;
            }

            int midIndex = nums.Length / 2;

            int val = nums[midIndex];
            var arrleft = nums.Skip(0).Take(midIndex).ToArray();
            var arrright = nums.Skip(midIndex + 1).ToArray();

            var left = SortedArrayToBST(arrleft);
            var right = SortedArrayToBST(arrright);

            TreeNode treeNode = new TreeNode(val, left, right);

            return treeNode;

        }
    }
}
