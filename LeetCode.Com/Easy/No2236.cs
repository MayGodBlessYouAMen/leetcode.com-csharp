using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Root Equals Sum of Children
    /// </summary>
    public class No2236
    {
        /*
            解题思路：这题也太水了。。直接比较即可

            The tree consists only of the root, its left child, and its right child.
            -100 <= Node.val <= 100
         */
        public bool CheckTree(TreeNode root)
        {
            return root.val == (root.left.val + root.right.val);
        }
    }
}
