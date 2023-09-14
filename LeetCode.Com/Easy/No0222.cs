/**************************************************************
 * 创建时间：2023-09-14 17:04:08
 * 创建人：  akalin
 * 创建说明：
***************************************************************/

using LeetCode.Com.Com;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Count Complete Tree Nodes
    /// </summary>
    public class No0222
    {
        //递归
        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + CountNodes(root.left) + CountNodes(root.right);
        }
    }
}
