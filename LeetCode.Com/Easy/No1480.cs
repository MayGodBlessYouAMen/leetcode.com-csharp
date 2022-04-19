using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Running Sum of 1d Array
    /// </summary>
    public class No1480
    {
        /*
         * 解题思路：水题
         
            1 <= nums.length <= 1000
            -10^6 <= nums[i] <= 10^6
         */
        public int[] RunningSum(int[] nums)
        {
            //初始化数组
            int[] runningSum = new int[nums.Length];

            runningSum[0] = nums[0];

            //遍历累加。S[i]=S[i-1]+nums[i]
            for (int i = 1; i < nums.Length; i++)
            {
                runningSum[i] = runningSum[i-1] + nums[i];
            }

            return runningSum;
        }
    }
}
