using LeetCode.Com.Com;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Increasing Order Search Tree
    /// </summary>
    internal class No0897
    {
        /*
            题意：将BST二叉查找树，转换为没有左子树的树，新树递增

            解题思路：BST中序遍历能得到一个升序数组。插入新树右节点即可。
         */
        public TreeNode IncreasingBST(TreeNode root)
        {
            //记录根节点
            TreeNode newRoot = null;

            //计算右子树
            TreeNode tempRightNote = null;

            IncreasingBST(root, ref newRoot, ref tempRightNote);

            return newRoot;
        }

        private void IncreasingBST(TreeNode root, ref TreeNode newRoot, ref TreeNode tempRightNote)
        {
            if (root == null)
            {
                return;
            }

            //左
            if (root.left != null)
            {
                IncreasingBST(root.left, ref newRoot, ref tempRightNote);
            }

            //中
            if (newRoot == null)
            {
                //初始节点
                newRoot = new TreeNode(root.val);
                tempRightNote = newRoot;
            }
            else
            {
                tempRightNote.right = new TreeNode(root.val);
                tempRightNote = tempRightNote.right;
            }

            //右
            if (root.right != null)
            {
                IncreasingBST(root.right, ref newRoot, ref tempRightNote);
            }
        }
    }
}
