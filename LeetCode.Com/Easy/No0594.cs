using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Longest Harmonious Subsequence
    /// </summary>
    internal class No0594
    {
        /*
           最长和谐子序列

           题目只要求计算数量,没要求输出序列。可以先排序，再计算每个数字出现的次数，并保存。
           最后遍历计算相邻两个相差为1的数量和，并比较，输出最大值。
         */
        public int FindLHS(int[] nums)
        {
            if (nums?.Length <= 0)
            {
                return 0;
            }

            //排序
            Array.Sort(nums);

            //计算并保存次数
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 1);
                }
                else
                {
                    dic[nums[i]] += 1;
                }
            }

            var list = dic.Keys.ToList();

            int count = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] - list[i - 1] != 1)
                {
                    continue;
                }

                //相差为1的两个数字出现次数相加，与之前的做比较
                if (dic[list[i]] + dic[list[i-1]] > count)
                {
                    count = dic[list[i]] + dic[list[i - 1]];
                }
            }

            return count;
        }
    }
}
