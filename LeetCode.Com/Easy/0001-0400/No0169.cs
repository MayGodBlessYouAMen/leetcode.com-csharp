using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Majority Element
    /// </summary>
    public class No0169
    {
        public int MajorityElement(int[] nums)
        {
            /*题目给定数组非空，且要找的多数元素始终存在。可以先排序，然后返回 n/2位置的值 */

            Array.Sort(nums);

            return nums[nums.Length / 2];
        }
    }
}
