using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Divide Array Into Equal Pairs
    /// </summary>
    public class No2206
    {
        /*
            解题思路：2n个数字分为n组，每组的两个数字相等。用字典统计数字出现次数，如果全为偶数，则true
         */
        public bool DivideArray(int[] nums)
        {
            Dictionary<int, int> numDic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!numDic.ContainsKey(num))
                {
                    numDic.Add(num, 1);
                }
                else
                {
                    numDic[num]++;
                }
            }

            foreach (var item in numDic.Values)
            {
                if (item %2 == 0)
                {
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
