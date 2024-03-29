﻿namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Length of Last Word
    /// </summary>
    public class No0058
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            string[] arr = s.Trim().Split(' ');
            return arr[arr.Length - 1].Length;
        }
    }
}
