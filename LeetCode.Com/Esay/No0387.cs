using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// First Unique Character in a String
    /// </summary>
    public class No0387
    {
        public int FirstUniqChar(string s)
        {

            //从前往后遍历，找到的第一个和最后一个位置相同，则为唯一字符
            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]) && s.IndexOf(s[i]) > -1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
