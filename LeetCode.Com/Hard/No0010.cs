using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Hard
{
    /// <summary>
    /// Regular Expression Matching
    /// </summary>
    public class No0010
    {
        public bool IsMatch(string s, string p)
        {
            //if (s.Length < p.Length)
            //{
            //    return false;
            //}

            int i = 0;
            int j = 0;
            char temp = ' ';
            while (i < s.Length && j < p.Length)
            {
                //单次匹配
                if (s[i] == p[j] || p[j] == '.')
                {
                    temp = s[i];  //记录最近一次匹配的字符串
                    i++;
                    j++;
                    continue;
                }

                //多次重复匹配
                if (p[j] == '*')
                {
                    if (s[i] == temp || p[j - 1] == '.')
                    {
                        if (i == s.Length - 1)
                        {
                            j++;  //如果i匹配到s最后一个,j++
                        }
                        i++;
                        continue;
                    }
                    else
                    {
                        j++;
                        continue;
                    }
                }

                if (s[i] != p[j] && j + 1 < p.Length && p[i + 1] == '*')
                {
                    j += 2;
                    continue;
                }

                return false;
            }

            if (i > s.Length - 1 && (j > p.Length - 1 || (j == p.Length - 1 && p[j] == '*')))
            {
                return true;
            }
            return false;
        }
    }
}
