using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Reverse String
    /// </summary>
    public class No0344
    {
        public void ReverseString(char[] s)
        {
            //思路:char[]从0遍历到中间，首尾交换。
            //0~(s.Lentgh/2)-1,对奇偶都适用
            for (int i = 0; i < s.Length / 2; i++)
            {
                char a = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = a;
            }
        }
    }
}
