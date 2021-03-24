using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Range Sum Query - Immutable
    /// </summary>
    public class No0303
    {
        public class NumArray
        {
            private int[] nums;

            public NumArray(int[] nums)
            {
                this.nums = nums;
            }

            public int SumRange(int i, int j)
            {
                int sum = 0;
                for (int k = i; k <= j; k++)
                {
                    sum += this.nums[k];
                }
                return sum;
            }
        }

    }
}
