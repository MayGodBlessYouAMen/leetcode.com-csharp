using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// 521. Longest Uncommon Subsequence I
    /// </summary>
    internal class No0521
    {

        public int FindLUSlength(string a, string b)
        {
            /*
             * a和b的子序列中，不相同，且最长的子序列。
             * 
             * 最长非共同子序列。如果ab相等，则一定没有非共同子序列。
             * 如果ab不相等，那较长的字符串就是最长的非共同子序列

             * 脑筋急转弯。。。
             */

            if (a == b)
            {
                return -1;
            }

            if (a.Length > b.Length)
            {
                return a.Length;
            }

            return b.Length;
        }
    }
}
