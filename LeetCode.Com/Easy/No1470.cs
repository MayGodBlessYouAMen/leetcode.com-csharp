using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Shuffle the Array
    /// </summary>
    public class No1470
    {
        /*
            解题思路：水题，略    

            1 <= n <= 500
            nums.length == 2n
            1 <= nums[i] <= 10^3         
         */
        public int[] Shuffle(int[] nums, int n)
        {
            int[] res = new int[2 * n];

            for (int i = 0; i < n; i++)
            {
                res[2 * i] = nums[i];
                res[2 * i + 1] = nums[i + n];
            }

            return res;
        }
    }
}
