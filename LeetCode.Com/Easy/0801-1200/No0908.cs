using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Smallest Range I
    /// </summary>
    internal class No0908
    {
        /*
            解题思路：
                计算数组中最大值和最小值的差，如果差值在2*k范围内，则能通过加减使差值等于0.

                1 <= nums.length <= 104
                0 <= nums[i] <= 104
                0 <= k <= 104
         */
        public int SmallestRangeI(int[] nums, int k)
        {
            //排序
            Array.Sort(nums);

            //最大差值
            int temp = nums[nums.Length - 1] - nums[0];

            //计算通过[-k,k]调整过之后的最小差值
            if (temp <= 2 * k)
            {
                return 0;
            }
            return temp - 2 * k;
        }
    }
}
