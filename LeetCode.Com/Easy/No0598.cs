using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Range Addition II
    /// </summary>
    public class No0598
    {
        public int MaxCount(int m, int n, int[][] ops)
        {
            //所有矩阵都是0,0为起点，所以最大整数，其实就是所有矩阵都覆盖的范围内的数字。

            if (ops == null)
            {
                return 0;
            }

            if (ops.Length == 0)
            {
                //全为0
                return m * n;
            }

            int[] point = new int[2] { 0, 0 };
            for (int i = 0; i < ops.Length; i++)
            {
                if (i == 0)
                {
                    point[0] = ops[i][0];
                    point[1] = ops[i][1];
                    continue;
                }

                //缩小范围
                if (ops[i][0] < point[0])
                {
                    point[0] = ops[i][0];
                }
                if (ops[i][1] < point[1])
                {
                    point[1] = ops[i][1];
                }
            }

            return point[0] * point[1];
        }
    }
}
