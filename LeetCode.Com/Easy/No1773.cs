using System;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Count Items Matching a Rule
    /// </summary>
    public class No1773
    {
        /*
            解题思路："type","color","name"分别对应矩阵的第1，2，3列。那么根据ruleKey，遍历对应的列，计数即可。
         */
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;

            int keyIndex = (int)Enum.Parse(typeof(Types), ruleKey);
            foreach (var item in items)
            {
                if (item[keyIndex] == ruleValue)
                {
                    count++;
                }
            }
            return count;
        }

        enum Types : int
        {
            type = 0,
            color = 1,
            name = 2
        }
    }
}
