using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Search Insert Position
    /// </summary>
    public class No0035
    {
        public int SearchInsert(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;
                if (nums[i] > target) return i;
            }

            return nums.Length;
        }
    }
}
