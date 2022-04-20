using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Shuffle String
    /// </summary>
    public class No1528
    {
        /*
            解题思路：定义新数组，按索引位置放入字符即可
         */
        public string RestoreString(string s, int[] indices)
        {
            char[] chars = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                chars[indices[i]] = s[i];
            }
            return new string(chars);
        }
    }
}
