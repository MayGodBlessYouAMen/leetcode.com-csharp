using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Valid Palindrome
    /// </summary>
    public class No0125
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            /*两头查找 字母 数字*/

            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (!IsAlphanumeric(s[i]))
                {
                    i++;
                    continue;
                }

                if (!IsAlphanumeric(s[j]))
                {
                    j--;
                    continue;
                }

                if (!Equal(s[i], s[j]))
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }

        /*0-9 a-z(97-122)  A-Z(65-90)   int可以和char比大小*/
        public bool IsAlphanumeric(int c)
        {
            return IsNum(c) || IsChar(c);
        }

        public  bool IsChar(int c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return true;
            }

            if (c >= 'A' && c <= 'Z')
            {
                return true;
            }

            return false;
        }

        public  bool IsNum(int c)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }
            return false;
        }

        //比较字符相等(忽略大小写) 也可以用toupper或tolower方法
        public bool Equal(int a, int b)
        {
            if (!IsAlphanumeric(a)) return false;
            if (!IsAlphanumeric(b)) return false;
            if (a == b) return true;
            if ((IsChar(a) && IsChar(b)) && (a - b == 32 || b - a == 32)) return true;
            return false;
        }
    }
}
