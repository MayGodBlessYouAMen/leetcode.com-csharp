using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Same Tree
    /// </summary>
    public class No0100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {

            //递归
            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null || q == null)
            {
                return false;
            }
            else
            {
                if (p.val == q.val)
                {
                    return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
