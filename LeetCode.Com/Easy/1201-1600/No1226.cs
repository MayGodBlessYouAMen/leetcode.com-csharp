using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Minimum Time Visiting All Points
    /// </summary>
    public class No1226
    {
        /*
         *  只能按顺序访问点。1秒钟可以横向走一格、或者纵向走一格、或者对角线走一格。
            解题思路：按贪心走法，优先按对角线走。然后再按横向或者纵向走
         */
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int totalTime = 0;
            for (int i = 1; i < points.Length; i++)
            {
                totalTime += MinTimeToVisitTwoPoints(points[i], points[i - 1]);
            }

            return totalTime;
        }

        /// <summary>
        /// 计算访问两个点最短时间
        /// </summary>
        /// <returns></returns>
        public int MinTimeToVisitTwoPoints(int[] point1, int[] point2)
        {
            //x方向距离绝对值
            int distanceX = Math.Abs(point1[0] - point2[0]);

            //y方向距离绝对值
            int distanceY = Math.Abs(point1[1] - point2[1]);

            int time = 0;
            while (distanceX > 0 || distanceY > 0)
            {
                if (distanceX > 0)
                {
                    distanceX--;
                }

                if (distanceY > 0)
                {
                    distanceY--;
                }

                time++;
            }

            return time;
        }
    }
}
