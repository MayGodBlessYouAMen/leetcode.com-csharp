using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Maximum Product of Two Elements in an Array
    /// </summary>
    public class No1464
    {
        /*
            解题思路：排序，找出最大的两个数字即可。

            2 <= nums.length <= 500
            1 <= nums[i] <= 10^3
         */
        public int MaxProduct(int[] nums)
        {
            Array.Sort(nums);

            int len = nums.Length;
            return (nums[len - 1] - 1) * (nums[len - 2] - 1);
        }
    }
}
