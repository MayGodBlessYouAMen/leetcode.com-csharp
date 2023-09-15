using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Count the Number of Consistent Strings
    /// </summary>
    public class No1684
    {
        /*
            解题思路:将allowed的字符放入字典。word过来去字典里找

            1 <= words.length <= 104
            1 <= allowed.length <= 26
            1 <= words[i].length <= 10
            The characters in allowed are distinct.
            words[i] and allowed contain only lowercase English letters.
         */
        public int CountConsistentStrings(string allowed, string[] words)
        {
            Dictionary<char, int> charDic = new Dictionary<char, int>();

            foreach (var item in allowed)
            {
                charDic.Add(item, 1);
            }

            int count = 0;
            foreach (var word in words)
            {
                bool isConsistent = true;
                foreach (var item in word)
                {
                    if (!charDic.ContainsKey(item))
                    {
                        isConsistent = false;
                        break;
                    }
                }
                if (isConsistent)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
