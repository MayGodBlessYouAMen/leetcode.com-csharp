using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Check If It Is a Straight Line
    /// </summary>
    public class No1232
    {
        /*
            解题思路：计算所有点是否在一条直线上。只需要两两比较直线斜率是否相等即可。
                    注意要把等式的除法变为交叉相乘，防止除数为0 。

            2 <= coordinates.length <= 1000
            coordinates[i].length == 2
            -10^4 <= coordinates[i][0], coordinates[i][1] <= 10^4
            coordinates contains no duplicate point.
         */
        public bool CheckStraightLine(int[][] coordinates)
        {
            //两点必在一条直线上
            if (coordinates.Length == 2)
            {
                return true;
            }

            //后面所有点的斜率和点1和点2的直线斜率做比较
            for (int i = 2; i < coordinates.Length; i++)
            {
                ////i,i-1
                //var sloptei = (coordinates[i][1] - coordinates[i - 1][1]) / (coordinates[i][0] - coordinates[i - 1][0]);

                ////2,1
                //var slopte1 = (coordinates[1][1] - coordinates[0][1]) / (coordinates[1][0] - coordinates[0][0]);

                if ((coordinates[i][1] - coordinates[i - 1][1]) * (coordinates[1][0] - coordinates[0][0]) 
                    != (coordinates[1][1] - coordinates[0][1]) * (coordinates[i][0] - coordinates[i - 1][0]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
