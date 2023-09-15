using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Maximum Number of Balloons
    /// </summary>
    public class No1189
    {
        /*
            解题思路：遍历字符串，根据balloon单词字母计数。最后返回能组成多少个balloon

            1 <= text.length <= 104
            text consists of lower case English letters only.
         */
        public int MaxNumberOfBalloons(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            Dictionary<char, int> charDic = new Dictionary<char, int>();
            charDic.Add('b', 0);
            charDic.Add('a', 0);
            charDic.Add('l', 0);
            charDic.Add('o', 0);
            charDic.Add('n', 0);

            foreach (var item in text)
            {
                if (charDic.ContainsKey(item))
                {
                    charDic[item]++;
                }
            }

            charDic['o'] = charDic['o'] / 2;
            charDic['l'] = charDic['l'] / 2;

            int min = -1;
            foreach (var item in charDic.Values)
            {
                if (min == -1)
                {
                    min = item;
                    continue;
                }

                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }
    }
}
