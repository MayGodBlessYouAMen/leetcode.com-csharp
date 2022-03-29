using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Verifying an Alien Dictionary
    /// </summary>
    internal class No0953
    {
        /*
            解题思路：先用字典保存字母排序。然后遍历单词，比较对应位置字母顺序是否满足字典顺序要求。
         */
        public bool IsAlienSorted(string[] words, string order)
        {
            Dictionary<char, int> orderDic = new Dictionary<char, int>();

            orderDic.Add(' ', -1);
            for (int i = 0; i < order.Length; i++)
            {
                orderDic.Add(order[i], i);
            }

            for (int i = 1; i < words.Length; i++)
            {
                string word1 = words[i - 1];
                string word2 = words[i];

                //取长的那个长度
                int len = words[i - 1].Length > words[i].Length ? words[i - 1].Length : word1.Length;

                for (int j = 0; j < len; j++)
                {
                    char char1 = ' ';
                    if (j < word1.Length) char1 = word1[j];

                    char char2 = ' ';
                    if (j < word2.Length) char2 = word2[j];

                    //前面字符小于，直接符合条件
                    if (orderDic[char1] < orderDic[char2])
                    {
                        break;
                    }

                    //前面字符大于，直接不符合
                    if (orderDic[char1] > orderDic[char2])
                    {
                        return false;
                    }

                    //前面字符相等，继续比较后一个字符
                    if (orderDic[char1] == orderDic[char2])
                    {
                        continue;
                    }
                }
            }

            return true;

        }
    }
}
