using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Check if All Characters Have Equal Number of Occurrences
    /// </summary>
    public class No1941
    {
        /*
            解题思路：用字典存储每个字符并统计出现次数。最后比较

            1 <= s.length <= 1000
            s consists of lowercase English letters.
         */
        public bool AreOccurrencesEqual(string s)
        {
            Dictionary<char, int> charDic = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (!charDic.ContainsKey(item))
                {
                    charDic.Add(item, 1);
                }
                else
                {
                    charDic[item]++;
                }
            }

            int count = -1;
            foreach (var value in charDic.Values)
            {
                if (count == -1)
                {
                    count = value;
                }

                if (count != value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
