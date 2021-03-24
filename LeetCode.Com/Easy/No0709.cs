using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [709]  To Lower Case
    /// </summary>
    public class No0709
    {
        //利用ascll码计算即可 (A-Z 65-90)  (a-z 97-122)
        public string ToLowerCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(ToLower(str[i]));
            }
            return sb.ToString();
        }

        private char ToLower(char character)
        {
            //只需要处理大写字母。其他字符保持不变
            if (character >= 65 && character <= 90)
            {
                character = (char)(character + 32);
            }
            return character;
        }
    }
}
