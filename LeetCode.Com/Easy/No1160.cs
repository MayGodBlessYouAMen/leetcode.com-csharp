using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// 1160. Find Words That Can Be Formed by Characters
    /// </summary>
    public class No1160
    {
        public int CountCharacters(string[] words, string chars)
        {
            if (words == null || words.Length == 0)
            {
                return 0;
            }

            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (IsMatch(words[i], chars)) count += words[i].Length;
            }
            return count;
        }

        private bool IsMatch(string word, string chars)
        {
            //判断word中的字符在chars中存在且数量足够
            int len  = 0;
            while ((len = word.Length) > 0)
            {
                string c = word[0].ToString();
                word = word.Replace(c,"");
                if ((len - word.Length) > (chars.Length - chars.Replace(c, "").Length)) return false;
            }

            return true;
        }
    }
}
