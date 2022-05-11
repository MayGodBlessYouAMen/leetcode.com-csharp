using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Counting Words With a Given Prefix
    /// </summary>
    public class No2185
    {
        /*
            解题思路：遍历words，比较每个单词是否有pref前缀，符合的计数

            1 <= words.length <= 100
            1 <= words[i].length, pref.length <= 100
            words[i] and pref consist of lowercase English letters.
         */
        public int PrefixCount(string[] words, string pref)
        {
            int count = 0;
            foreach (var word in words)
            {
                if (word.StartsWith(pref)) count++;
            }
            return count;
        }
    }
}
