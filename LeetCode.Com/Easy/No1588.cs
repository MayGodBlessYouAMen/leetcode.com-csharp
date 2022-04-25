using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Sum of All Odd Length Subarrays
    /// </summary>
    public class No1588
    {
        /*
            解题思路：返回数组所有奇数长度子数组的元素之和，子数组元素是原数组中的连续元素。

            遍历，计算奇数长度子数组。

            1 <= arr.length <= 100
            1 <= arr[i] <= 1000
         */
        public int SumOddLengthSubarrays(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int subSum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    subSum += arr[j];

                    //判断子数组长度是否为奇数
                    if ((j - i + 1) %2 !=0)
                    {
                        sum += subSum;
                    }
                }
            }

            return sum;
        }
    }
}
