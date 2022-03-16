using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Shortest Completing Word
    /// </summary>
    internal class No0748
    {

        /*
            解题思路：
                遍历licensePlate，剔除数字和空格，保留所有字母并转为小写。
                遍历单词数组。返回能包含所有遍历licensePlate中字母的单词（忽略大小写）。
                如果单词数组中有多个满足条件，优先返回最短的单词，如果有满足条件且长度相同的单词，返回靠前的那个。
                题目保证存在答案，所以不用担心返回空的情况。
         */
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            List<char> lettersInLicensePlate = new List<char>();
            for (int i = 0; i < licensePlate.Length; i++)
            {
                if (licensePlate[i] >= 'a' && licensePlate[i] <= 'z')
                {
                    lettersInLicensePlate.Add(licensePlate[i]);
                    continue;
                }

                if (licensePlate[i] >= 'A' && licensePlate[i] <= 'Z')
                {
                    var temp = licensePlate[i] + 32;
                    lettersInLicensePlate.Add((char)temp);
                    continue;
                }
            }

            string targetWord = "";

            foreach (var word in words)
            {
                if (!IsCompletingWord(word, lettersInLicensePlate))
                {
                    continue;
                }

                if (string.IsNullOrWhiteSpace(targetWord))
                {
                    targetWord = word;
                    continue;
                }

                if (word.Length < targetWord.Length)
                {
                    targetWord = word;
                }
            }


            return targetWord;
        }

        private bool IsCompletingWord(string word, List<char> lettersInLicensePlate)
        {
            foreach (var item in lettersInLicensePlate)
            {
                if (string.IsNullOrWhiteSpace(word))
                {
                    return false;
                }

                int index = word.LastIndexOf(item);
                if (index == -1)
                {
                    return false;
                }

                word = word.Remove(index, 1);
            }

            return true;
        }
    }
}
