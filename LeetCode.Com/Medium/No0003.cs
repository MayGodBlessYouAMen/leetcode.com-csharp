using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// Longest Substring Without Repeating Characters
    /// </summary>
    public class No0003
    {
        public int LengthOfLongestSubstring(string s)
        {
            int left = 0;
            int right = 0;
            List<char> list = new List<char>();
            int maxLength = 0;
            while (left < s.Length && right < s.Length)
            {
                if (!list.Contains(s[right]))
                {
                    list.Add(s[right]);
                    right++;
                    maxLength = Math.Max(maxLength, list.Count);
                }
                else
                {
                    list.Remove(s[left]);
                    left++;
                }
            }

            return maxLength;
        }
    }
}
