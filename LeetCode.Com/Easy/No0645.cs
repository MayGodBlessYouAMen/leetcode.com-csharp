using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Set Mismatch
    /// </summary>
    public class No0645
    {

        /// <summary>
        /// AC 耗时 1892ms 太长了
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        //public int[] FindErrorNums(int[] nums)
        //{
        //    int[] arr = new int[2];

        //    //初始化list 1-n
        //    List<int> listn = new List<int>();
        //    for (int i = 1; i <= nums.Length; i++)
        //    {
        //        listn.Add(i);
        //    }

        //    //遍历移除。移除时不存在的就是多的，最后剩下的就是缺失的。
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (listn.Contains(nums[i]))
        //        {
        //            listn.Remove(nums[i]);
        //        }
        //        else
        //        {
        //            arr[0] = nums[i];
        //        }
        //    }
        //    arr[1] = listn[0];

        //    return arr;
        //}

        /// <summary>
        /// 空间换时间，减少遍历  AC 耗时 272ms 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] FindErrorNums(int[] nums)
        {
            int[] arr = new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.Keys.Contains(nums[i]))
                {
                    dic[nums[i]] = 1;
                }
                else
                {
                    //重复数字
                    dic[nums[i]] += 1;
                    arr[0] = nums[i];
                }
                sum += nums[i];
            }

            //求缺失的数字: 重复数字- ( sum - (1+n)*n/2)
            arr[1] = arr[0] - (sum - (1 + nums.Length) * nums.Length / 2);

            return arr;
        }
    }
}
