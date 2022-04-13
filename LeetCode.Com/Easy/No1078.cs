using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Occurrences After Bigram
    /// </summary>
    public class No1078
    {
        /*
            解题思路：返回所有第三个单词。遍历单词，每当找到first，如果下一个是second，那么再下一个就是third。
                      用list保存third，最后输出

            1 <= text.length <= 1000
            text consists of lowercase English letters and spaces.
            All the words in text a separated by a single space.
            1 <= first.length, second.length <= 10
            first and second consist of lowercase English letters.
         */
        public string[] FindOcurrences(string text, string first, string second)
        {
            string[] words = text.Split(' ');

            List<string> thirdList = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == first 
                    && (i + 1 < words.Length && words[i + 1] == second)
                    && (i + 2 < words.Length))
                {
                    thirdList.Add(words[i+2]);
                }
            }

            return thirdList.ToArray();
        }
    }
}
