using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Check If Two String Arrays are Equivalent
    /// </summary>
    public class No1662
    {
        /*
            解题思路：连接字符串，对比
         */
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string s1 = string.Join("", word1);
            string s2 = string.Join("", word2);
            return s1 == s2;
        }
    }
}
