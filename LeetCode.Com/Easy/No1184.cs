using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Distance Between Bus Stops
    /// </summary>
    public class No1184
    {
        /*
            解题思路：分别计算顺时针和逆时针的距离，比较返回较小的值。
                     要注意start和end不一定谁大谁小
         */
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            if (start == destination)
            {
                return 0;
            }

            //比较起点和终点大小
            int min = Math.Min(start, destination);
            int max = Math.Max(start, destination);

            //顺时针距离
            int clockwiseDistance = 0;

            //逆时针距离
            int counterclockwiseDistance = 0;

            for (int i = 0; i < distance.Length; i++)
            {
                if (i >= min && i < max)
                {
                    clockwiseDistance += distance[i];
                }
                else
                {
                    counterclockwiseDistance += distance[i];
                }
            }

            return Math.Min(clockwiseDistance, counterclockwiseDistance);
        }
    }
}
