using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Maximum Subarray
    /// </summary>
    public class No0053
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int max = nums[0]; //基准
            foreach (var num in nums)
            {
                sum = num + (sum > 0 ? sum : 0);
                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}
