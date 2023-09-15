using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Sorting the Sentence
    /// </summary>
    public class No1859
    {
        /*
            解题思路：句子分割成单词，根据单词最后一位，将单词放在对应位置即可。
         */
        public string SortSentence(string s)
        {
            string[] words = s.Split(' ');
            string[] newWords = new string[words.Length];
            foreach (var word in words)
            {
                int index = int.Parse(word.Substring(word.Length - 1)) - 1;
                newWords[index] = word.Substring(0, word.Length - 1);
            }

            return String.Join(" ", newWords);
        }
    }
}
