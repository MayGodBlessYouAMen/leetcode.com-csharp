using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Backspace String Compare
    /// </summary>
    internal class No0844
    {
        /*
         *  题目大意：给两个字符串,判断他们输出的字符串是否相同.'#'表示回退删除一个字符。对于空字符串，输入'#'之后还是空字符串。
            解体思路: 遍历，得到最后的输出字符串，比较即可。
            
            1 <= s.length, t.length <= 200
            s and t only contain lowercase letters and '#' characters.

            题目要求o(n)的时间和o(1)的空间，那就不定义新变量了。
         */
        public bool BackspaceCompare(string s, string t)
        {
            s = GetInput(s);
            Console.WriteLine(s);
            t = GetInput(t);
            Console.WriteLine(t);

            return s == t;
        }

        private string GetInput(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != '#')
                {
                    continue;
                }

                //移除#
                s = s.Remove(i, 1);

                //移除前一个不为#的字符。这里需要注意，如果只是简单的移除i-1位置的字符那就错了
                if (i - 1 >= 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (s[j] != '#')
                        {
                            s = s.Remove(j, 1);
                            i--;
                            break;
                        }
                    }
                }
            }

            return s;
        }
    }
}
