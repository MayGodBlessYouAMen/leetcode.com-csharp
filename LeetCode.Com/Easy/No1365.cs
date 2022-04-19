using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// How Many Numbers Are Smaller Than the Current Number
    /// </summary>
    public class No1365
    {
        /*
            解题思路：将数组去重，排序。那么当前数字左边的所有数字都是比它小的。
         */
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            //去重。并计算重复数字个数
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!dic.ContainsKey(num))
                {
                    dic.Add(num, 1);
                }
                else
                {
                    dic[num]++;
                }
            }

            //去重后的数组
            var arr = dic.Keys.ToArray();

            //排序
            Array.Sort(arr);

            //将数字和左侧数字个数用字典保存
            Dictionary<int, int> numIndexDic = new Dictionary<int, int>();
            int leftCount = 0;  //左侧数字个数
            for (int i = 0; i < arr.Length; i++)
            {
                numIndexDic.Add(arr[i], leftCount);
                leftCount += dic[arr[i]];
            }

            //定义输出数组
            int[] outputnums = new int[nums.Length];

            //遍历计算
            for (int i = 0; i < nums.Length; i++)
            {
                outputnums[i] = numIndexDic[nums[i]];
            }

            return outputnums;
        }
    }
}
