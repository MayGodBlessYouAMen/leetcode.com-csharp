using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    public class No0409
    {
        public int LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            Dictionary<char, int> dic = new Dictionary<char, int>();
            int longestcount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.Keys.Contains(s[i]))
                {
                    dic.Add(s[i], 1);
                }
                else
                {
                    dic.Remove(s[i]);   //成对移除，并计数
                    longestcount += 2;
                }
            }

            if (dic.Keys.Count > 0)
            {
                longestcount += 1;
            }

            return longestcount;
        }
    }
}
