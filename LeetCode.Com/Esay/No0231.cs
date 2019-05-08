using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Power of Two
    /// </summary>
    public class No0231
    {
        /*n            二进制
         *
         *1   2^0      0001
         *2   2^1      0010
         *4   2^2      0100
         *8   2^3      1000
         *16  2^4     10000
         *....
         *....2^x    10...0  
         *
         *  2进制只有一个1
         */

        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            //暴力解法
            while (n % 2 == 0)
            {
                n = n / 2;
            }
            if (n == 1) return true;
            return false;
        }
    }
}
