using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Count Number of Pairs With Absolute Difference K
    /// </summary>
    public class No2006
    {
        /*
            解题思路：遍历比较即可

            1 <= nums.length <= 200
            1 <= nums[i] <= 100
            1 <= k <= 99
         */
        public int CountKDifference(int[] nums, int k)
        {
            if (nums.Length == 1)
            {
                return 0;
            }

            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
