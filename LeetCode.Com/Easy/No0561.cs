using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [561]  Array Partition I
    /// </summary>
    public class No0561
    {
        public int ArrayPairSum(int[] nums)
        {
            //排序后取相邻2个两两为一组，取最小值之后相加。
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length / 2; i++)
            {
                sum += nums[i * 2];
            }
            return sum;
        }
    }
}
