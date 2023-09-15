using System;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// 3Sum Closest
    /// </summary>
    public class No0016
    {
        /// <summary>
        /// Given an array nums of n integers and an integer target, find three integers in nums such that the sum is closest to target. 
        /// Return the sum of the three integers. 
        /// You may assume that each input would have exactly one solution.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int ThreeSumClosest(int[] nums, int target)
        {
            //前三个相加作为初始值
            int res = nums[0] + nums[1] + nums[2];

            //先排序
            Array.Sort(nums);

            //参考3sum问题
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //去重复
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == target)
                    {
                        return sum;   //找到target直接返回。
                    }

                    if (Math.Abs(sum - target) < Math.Abs(res - target))
                    {
                        res = sum;
                    }

                    if (sum - target > 0)
                    {
                        k--;
                        continue;
                    }
                    if (sum - target < 0)
                    {
                        j++;
                        continue;
                    }
                }
            }

            return res;
        }
    }
}