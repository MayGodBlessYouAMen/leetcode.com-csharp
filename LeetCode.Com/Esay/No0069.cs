using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Sqrt(x)
    /// </summary>
    public class No0069
    {
        public int MySqrt(int x)
        {
            if (x == 0 || x == 1) return x;

            #region 超时
            //int n = (int)x / 2;
            //decimal i = 1;   //有个坑，i如果用int型，i*i结果不对
            //for (i = 1; i <= n; i++)
            //{
            //    if (i * i > x)
            //    {
            //        break;
            //    }
            //}
            //return (int)i - 1;
            #endregion

            #region 二分思路
            int left = 1;
            int right = x;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (x / mid >= mid && x / (mid + 1) < (mid + 1))
                {
                    return mid;
                }
                else if (x / mid < mid)
                {
                    right = mid ;
                }
                else
                {
                    left = mid ;
                }
            }
            return 0;
            #endregion
        }
    }
}
