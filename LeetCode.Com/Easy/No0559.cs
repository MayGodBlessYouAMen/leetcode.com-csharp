using LeetCode.Com.Com;
using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Maximum Depth of N-ary Tree
    /// </summary>
    internal class No0559
    {
        /// <summary>
        /// 递归求解
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int res = 1;
            foreach (var child in root.children)
            {
                var maxDepthChild = MaxDepth(child) + 1; //因为是从root的下一层开始计算，所以实际层数要+1
                res = Math.Max(res, maxDepthChild);
            }

            return res;
        }
    }
}
