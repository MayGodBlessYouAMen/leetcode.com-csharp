using System;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Minimum Absolute Difference
    /// </summary>
    public class No1200
    {
        /*
            解题思路：先从小到大排序。最小差一定发生在相邻两个数之间。
                     遍历排序后的数组，用字典保存所有相邻数的差。并记录最小的差。最后返回最小差的数列。

                2 <= arr.length <= 105
                -106 <= arr[i] <= 106
         */
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            //排序
            Array.Sort(arr);

            //最小差
            int minDiff = arr[1] - arr[0]; //初始值

            //所有差的字典
            Dictionary<int, List<List<int>>> dicDiff = new Dictionary<int, List<List<int>>>();

            for (int i = 1; i < arr.Length; i++)
            {
                //计算当前差
                int diff = arr[i] - arr[i - 1];

                //比较最小差
                if (diff < minDiff)
                {
                    minDiff = diff;
                }

                //选择保存
                if (diff > minDiff)
                {
                    continue;
                }

                //字典保存
                var tempList = new List<int>() { arr[i - 1], arr[i] };
                if (dicDiff.ContainsKey(diff))
                {
                    dicDiff[diff].Add(tempList);
                }
                else
                {
                    dicDiff.Add(diff, new List<List<int>>() { tempList });
                }
            }

            return dicDiff[minDiff].ToArray();
        }
    }
}
