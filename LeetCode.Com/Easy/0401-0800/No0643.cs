using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Maximum Average Subarray I
    /// </summary>
    internal class No0643
    {
        /*
            解题思路：长度为k的滑动窗口，从数组n的头滑尾，计算长度k的数组和，保留最大值。
         */
        public double FindMaxAverage(int[] nums, int k)
        {
            int n = nums.Length;
            double sum = 0;

            //计算0位置的和
            for (int i = 0; i <= k - 1; i++)
            {
                sum += nums[i];
            }

            //记录当前位置滑动窗口的和
            double current = sum;

            //从1开始滑动
            for (int i = 1; i <= n - k; i++)
            {
                //滑动后当前范围： i到i+k-1

                //更新当前位置滑动窗口的和。（头部出去一个，尾部进来一个）
                current = current - nums[i - 1] + nums[i + k - 1];
                if (current > sum)
                {
                    sum = current;
                }
            }

            //计算平均值
            return Math.Round(sum / k, 5);
        }
    }
}
