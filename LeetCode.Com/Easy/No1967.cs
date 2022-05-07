using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Number of Strings That Appear as Substrings in Word
    /// </summary>
    public class No1967
    {
        /*
            解题思路：找出数组中所有是给定字符串的子串的数量。遍历比较即可

            1 <= patterns.length <= 100
            1 <= patterns[i].length <= 100
            1 <= word.length <= 100
            patterns[i] and word consist of lowercase English letters.
         */
        public int NumOfStrings(string[] patterns, string word)
        {
            int count = 0;
            foreach (var item in patterns)
            {
                if (item.Length > word.Length)
                {
                    continue;
                }

                if (word.Contains(item))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
