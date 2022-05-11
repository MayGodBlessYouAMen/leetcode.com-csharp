using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Generate a String With Characters That Have Odd Counts
    /// </summary>
    public class No1374
    {
        /*
         *  题意：生成长度为n的字符串，其中每种字符的个数为奇数。
            解题思路：n为奇数，则全用a；n为偶数，则前面用a，最后一个用b
            
            1 <= n <= 500
         */
        public string GenerateTheString(int n)
        {
            if (n % 2 != 0)
            {
                //奇数
                return new String('a', n);
            }

            //偶数
            return new String('a', n - 1) + "b";
        }
    }
}
