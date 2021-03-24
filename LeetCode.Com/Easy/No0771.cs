using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [771]  Jewels and Stones
    /// </summary>
    public class No0771
    {
        public int NumJewelsInStones(string J, string S)
        {
            if (string.IsNullOrWhiteSpace(J) || string.IsNullOrWhiteSpace(S)) return 0;
            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (J.Contains(S[i])) count++;
            }
            return count;
        }
    }
}
