using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Longest Continuous Increasing Subsequence
    /// </summary>
    internal class No0674
    {
        /*
            解题思路：未排序的数组。子序列严格递增。只需要计算子序列长度。那么用双指针遍历即可。
         */

        public int FindLengthOfLCIS(int[] nums)
        {
            int i = 0, j = 0;
            int longestLength = 0;
            while (i < nums.Length && j < nums.Length)
            {
                if (j + 1 < nums.Length)
                {
                    //判断下个数字是否递增
                    if (nums[j] < nums[j + 1])
                    {
                        //如果递增，j后移
                        j++;
                    }
                    else
                    {
                        //计算长度
                        if (longestLength < j - i + 1)
                        {
                            longestLength = j - i + 1;
                        }

                        //下个数字不递增，将i,j移动到j+1
                        i = j + 1;
                        j = j + 1;
                    }
                }
                else
                {
                    //计算长度
                    if (longestLength < j - i + 1)
                    {
                        longestLength = j - i + 1;
                    }
                    j++;
                }
            }

            return longestLength;
        }
    }
}
