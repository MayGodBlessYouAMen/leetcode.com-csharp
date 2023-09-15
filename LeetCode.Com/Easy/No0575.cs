using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [575]  Distribute Candies
    /// </summary>
    public class No0575
    {
        public int DistributeCandies(int[] candies)
        {
            #region Time Limit Exceeded
            //List<int> kindlist = new List<int>();
            //for (int i = 0; i < candies.Length; i++)
            //{
            //    if (kindlist.Count >= candies.Length / 2) break;

            //    if (!kindlist.Contains(candies[i]))
            //    {
            //        kindlist.Add(candies[i]);
            //    }
            //}
            //return kindlist.Count;
            #endregion

            //利用HashSet自带去重复功能
            HashSet<int> candiesHashSet = new HashSet<int>(candies);
            return candiesHashSet.Count <= candies.Length / 2 ? candiesHashSet.Count : candies.Length / 2;
        }
    }
}
