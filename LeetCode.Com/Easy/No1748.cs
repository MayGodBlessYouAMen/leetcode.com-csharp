using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Sum of Unique Elements
    /// </summary>
    public class No1748
    {
        /*
            解题思路：遍历数组将数字存入字典，并保存出现次数。最后遍历字典，把出现一次的数字相加

            1 <= nums.length <= 100
            1 <= nums[i] <= 100
         */
        public int SumOfUnique(int[] nums)
        {
            Dictionary<int, int> numDic = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (numDic.ContainsKey(num))
                {
                    numDic[num]++;
                    continue;
                }

                numDic.Add(num, 1);
            }

            int sum = 0;
            foreach (var kv in numDic)
            {
                if (kv.Value == 1)
                {
                    sum += kv.Key;
                }
            }

            return sum;
        }
    }
}
