using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Find N Unique Integers Sum up to Zero
    /// </summary>
    public class No1304
    {
        /*
         *  题意：找出n个不同的数组，让他们之和为0
            解题思路：奇数先取个0。 偶数从1取到n/2，剩下的数字将用前面数字的乘以-1即可。
            
            1 <= n <= 1000
         */
        public int[] SumZero(int n)
        {
            List<int> res = new List<int>();

            if (n % 2 != 0)
            {
                res.Add(0);
                n--;
            }

            for (int i = 1; i <= n / 2; i++)
            {
                res.Add(i);
                res.Add(i * -1);
            }

            return res.ToArray();
        }
    }
}
