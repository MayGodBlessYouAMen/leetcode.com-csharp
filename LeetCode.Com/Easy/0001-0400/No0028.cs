﻿namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Implement strStr()
    /// </summary>
    public class No0028
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(needle))
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(haystack))
            {
                return -1;
            }

            return haystack.IndexOf(needle);
        }
    }
}
