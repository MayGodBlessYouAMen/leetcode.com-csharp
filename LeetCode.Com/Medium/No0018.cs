using System;
using System.Collections.Generic;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// 4Sum
    /// </summary>
    public class No0018
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            //参照2sum和3sum，将4sum转换成3sum问题，只是多了一层for循环。依旧要注意临界和去重的问题。

            IList<IList<int>> list = new List<IList<int>>();

            //不合法参数过滤
            if (nums == null || nums.Length < 4)
            {
                return list;
            }

            //先排序
            Array.Sort(nums);

            ////不存在的情况  -->负数不适用此判断
            //if (nums[0] > target)
            //{
            //    return list;
            //}

            //4sum转3sum：对于任意nums[m]，在nums[m+1]~nums[nums.Length-1]之间找三个数使它们的和为 target-nums[m]
            //3sum转2sum：对于任意nums[i]，在nums[i+1]~nums[nums.Length-1]之间找两个数使它们的和为 target-nums[m]-nums[i]
            for (int m = 0; m < nums.Length - 3; m++)
            {
                //去重复
                if (m > 0 && nums[m] == nums[m - 1])
                {
                    continue;
                }

                //  -->负数不适用此判断
                //if (nums[m] > target)
                //{
                //    break;
                //}

                for (int i = m + 1; i < nums.Length - 2; i++)
                {
                    //去重复
                    if (i > m + 1 && nums[i] == nums[i - 1])   //不要写成i>0
                    {
                        continue;
                    }

                    int j = i + 1;
                    int k = nums.Length - 1;
                    while (j < k)
                    {
                        int sum = nums[m] + nums[i] + nums[j] + nums[k];
                        if (sum == target)
                        {
                            list.Add(new List<int>() { nums[m], nums[i], nums[j], nums[k] });
                            j++;                //此处j++或者k--都可以，固定一个即可。目的是吧j和k之间的数据遍历完。注意去重复
                            //去重复
                            while (j < k && nums[j] == nums[j - 1])
                            {
                                j++;
                            }
                            continue;
                        }
                        if (sum > target)
                        {
                            k--;
                            continue;
                        }
                        if (sum < target)
                        {
                            j++;
                            continue;
                        }
                    }
                }
            }

            return list;
        }
    }
}
