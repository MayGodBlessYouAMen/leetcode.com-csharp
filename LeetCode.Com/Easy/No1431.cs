using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Kids With the Greatest Number of Candies
    /// </summary>
    public class No1431
    {
        /*
            解题思路：先找出单个孩子拥有的最多糖果。然后遍历，加上额外的糖果，如果大于等于最多的那个，返回true，否则false
         */
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = 0;
            foreach (var candy in candies)
            {
                if (candy > max)
                {
                    max = candy;
                }
            }

            bool[] res = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    res[i] = true;
                }
            }

            return res;
        }
    }
}
