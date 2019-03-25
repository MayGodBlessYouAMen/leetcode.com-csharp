using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Palindrome Number
    /// </summary>
    public class No0009
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            if (x < 10)
            {
                return true;
            }

            int a = x;
            int b = 0;
            //a倒序放入中
            while (a > 0)
            {
                b = b * 10 + a % 10;
                a = a / 10;
            }

            if (x == b)
            {
                return true;
            }

            return false;
        }
    }
}
