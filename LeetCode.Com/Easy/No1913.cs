using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Maximum Product Difference Between Two Pairs
    /// </summary>
    public class No1913
    {
        /*
            解题思路：最大差必定是最大的两个数相乘，减去最小的两个数相乘。所以先排序，再求差，即可

            4 <= nums.length <= 104
            1 <= nums[i] <= 104
         */
        public int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);

            return nums[nums.Length - 2] * nums[nums.Length - 1] - nums[0] * nums[1];
        }
    }
}
