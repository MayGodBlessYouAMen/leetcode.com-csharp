using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Minimum Operations to Make the Array Increasing
    /// </summary>
    public class No1827
    {
        /*
            解题思路：通过最小的操作，将数组变成一个严格递增数列。 遍历，不满足情况时，将后一个数改成比前一个数大1即可。
                       注意，每次操作只能加1。所以增加n需要操作n次。

            1 <= nums.length <= 5000
            1 <= nums[i] <= 104
         */
        public int MinOperations(int[] nums)
        {
            //计算需要的步骤
            int count = 0;

            //下一个值的最小期望值。
            int next = nums[0] + 1;

            //从第2个数开始遍历
            for (int i = 1; i < nums.Length; i++)
            {
                //满足递增，不操作
                if (nums[i] >= next)
                {
                    //计算下一个值的最小期望值
                    next = nums[i] + 1;
                    continue;
                }

                //不满足递增
                {
                    //累计需要操作的步骤
                    count += next - nums[i];

                    //计算下一个值的最小期望值
                    next += 1;
                }
            }

            return count;
        }
    }
}
