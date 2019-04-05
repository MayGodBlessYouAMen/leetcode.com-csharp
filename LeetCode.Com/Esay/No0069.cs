using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Sqrt(x)
    /// </summary>
    public class No0069
    {
        public int MySqrt(int x)
        {
            if (x == 1) return 1;
            int n = (int)x / 2;
            decimal i = 1;   //有个坑，i如果用int型，i*i结果不对
            for (i = 1; i <= n; i++)
            {
                if (i * i > x)
                {
                    break;
                }
            }
            return (int)i - 1;
        }
    }
}
