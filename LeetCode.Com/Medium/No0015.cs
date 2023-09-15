using System;
using System.Collections.Generic;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// 3Sum
    /// </summary>
    public class No0015
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();

            //不合法参数过滤
            if (nums == null || nums.Length < 3)
            {
                return list;
            }

            //先排序
            Array.Sort(nums);

            //不存在的情况
            if (nums[0] > 0 || nums[nums.Length - 1] < 0)
            {
                return list;
            }

            //3sum转换成2sum问题：对于任意nums[i]，在nums[i+1]~nums[nums.Length-1]之间找两个数使它们的和为-nums[i]
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //去重复
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                if (nums[i] > 0)
                {
                    break;
                }

                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0)
                    {
                        list.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        j++;                //此处j++或者k--都可以，固定一个即可。目的是吧j和k之间的数据遍历完。注意去重复
                        //去重复
                        while (j < k && nums[j] == nums[j - 1])
                        {
                            j++;
                        }
                        continue;
                    }
                    if (sum > 0)
                    {
                        k--;
                        continue;
                    }
                    if (sum < 0)
                    {
                        j++;
                        continue;
                    }
                }

            }

            return list;
        }
    }
}
