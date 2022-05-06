using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Check if the Sentence Is Pangram
    /// </summary>
    public class No1832
    {
        /*
            解题思路：用字典保存字母。遍历结束后判断26个字母是否齐全。

            1 <= sentence.length <= 1000
            sentence consists of lowercase English letters.

         */
        public bool CheckIfPangram(string sentence)
        {
            if (sentence.Length < 26)
            {
                return false;
            }

            Dictionary<char,int> charDic = new Dictionary<char,int>();

            foreach (var item in sentence)
            {
                if (!charDic.ContainsKey(item))
                {
                    charDic.Add(item, 1);
                }

                if (charDic.Keys.Count == 26)
                {
                    //提前结束
                    return true;
                }
            }


            if (charDic.Keys.Count == 26)
            {
                return true;
            }

            return false;
        }
    }
}
