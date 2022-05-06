using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Replace All Digits with Characters
    /// </summary>
    public class No1844
    {
        /*
            解题思路：偶数位是字母，奇数位是数字。
                    偶数位字母不变。
                    奇数位i数字执行下面操作：s[i] = shift(s[i-1], s[i]),
                                        将字母s[i-1]在26字母表上位移s[i]位，得到新的s[i]。
                                        题目说shift(s[i-1], s[i])不会超过z，所以不用判断越界情况
                 
                    1 <= s.length <= 100
                    s consists only of lowercase English letters and digits.
                    shift(s[i-1], s[i]) <= 'z' for all odd indices i.        
         */
        public string ReplaceDigits(string s)
        {
            var charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    charArray[i] = Shift(s[i - 1], int.Parse(s[i].ToString()));
                }
            }

            return new string(charArray);
        }

        private char Shift(char char1, int num)
        {
            return (char)(char1 + num);
        }
    }
}
