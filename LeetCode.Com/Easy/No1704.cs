using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Determine if String Halves Are Alike
    /// </summary>
    public class No1704
    {
        /*
            解题思路：遍历一遍，分别计算前半段和后半段的元音数量。比较即可

                2 <= s.length <= 1000
                s.length is even.
                s consists of uppercase and lowercase letters.
         */
        public bool HalvesAreAlike(string s)
        {
            //元音列表
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int countOfFirstHalf = 0;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    countOfFirstHalf++;
                }
            }

            int countOfSecondHalf = 0;
            for (int i = s.Length / 2; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    countOfSecondHalf++;
                }
            }

            return countOfFirstHalf == countOfSecondHalf;
        }
    }
}
