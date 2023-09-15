using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [628]  Maximum Product of Three Numbers
    /// </summary>
    public class No0628
    {
        public int MaximumProduct(int[] nums)
        {
            //注意考虑负数相乘的情况。
            Array.Sort(nums);
            int n = nums.Length;
            return Math.Max(nums[0] * nums[1] * nums[n - 1], nums[n - 3] * nums[n - 2] * nums[n - 1]);
        }
    }
}
