using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Find Center of Star Graph
    /// </summary>
    public class No1791
    {
        /*
            解题思路：中心点必定是x和y其中的一个，我们先假设是x，然后遍历，如果所有的包含x，那么，返回x，否则返回y

            3 <= n <= 105
            edges.length == n - 1
            edges[i].length == 2
            1 <= ui, vi <= n
            ui != vi
            The given edges represent a valid star graph.

         */
        public int FindCenter(int[][] edges)
        {
            int n = edges[0].Length;

            int x = edges[0][0];
            int y = edges[0][1];

            for (int i = 1; i < n; i++)
            {
                if (edges[i][0] == x || edges[i][1] == x)
                {
                    continue;
                }

                return y;
            }

            return x;
        }
    }
}
