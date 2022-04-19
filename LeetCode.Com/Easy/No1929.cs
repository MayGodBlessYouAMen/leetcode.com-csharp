using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Concatenation of Array
    /// </summary>
    public class No1929
    {
        /*
            解题思路：水题，直接写
         */
        public int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];
            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + nums.Length] = nums[i];
            }

            return ans;
        }
    }
}
