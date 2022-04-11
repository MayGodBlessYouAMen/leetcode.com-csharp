using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Valid Boomerang
    /// </summary>
    public class No1037
    {
        /*
            解体思路:判断三个点是否在一条直线，不在则能满足回旋镖。
                    通过判断三个点连成两条直线，直线斜率是否相等，判断三个点是否在同一直线上。

            points.length == 3
            points[i].length == 2
            0 <= xi, yi <= 100
         */

        public bool IsBoomerang(int[][] points)
        {
            var point1 = points[0];
            var point2 = points[1];
            var point3 = points[2];
            //因为斜率除法可能会有出数为0的问题，所以改为交叉相乘。 
            //return (point1[0] - point2[0]) / (point1[1] - point2[1]) != (point1[0] - point3[0]) / (point1[1] - point3[1]);
            return (point1[0] - point2[0]) * (point1[1] - point3[1]) != (point1[0] - point3[0]) * (point1[1] - point2[1]);
        }
    }
}
