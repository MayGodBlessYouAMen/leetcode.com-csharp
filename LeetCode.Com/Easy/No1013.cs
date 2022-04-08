using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Partition Array Into Three Parts With Equal Sum
    /// </summary>
    internal class No1013
    {
        /*
            解题思路：将数组分为三部分，这三部分元素各自相加的和相等。
                    先遍历整个数组求和sum，除以3，得到商m，能整除再继续。
                    重新遍历数组，累加到和为m，将和清零继续累加到m，剩下的数字相加也等于m。则符合条件

                    3 <= arr.length <= 5 * 104
                    -104 <= arr[i] <= 104
         */
        public bool CanThreePartsEqualSum(int[] arr)
        {
            //求和
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            if (sum % 3 != 0)
            {
                return false;
            }

            //部分和
            int part = sum / 3;

            //分部计数
            int partCount = 0;
            int partSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                partSum += arr[i];

                if (partSum == part)
                {
                    partCount++;
                    partSum = 0;
                }

                if (partCount == 3)
                {
                    //剩下的和应该为0
                    int lastSum = 0;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        lastSum += arr[j];
                    }

                    if (lastSum != 0)
                    {
                        return false;
                    }

                    break;
                }
            }

            return partCount == 3;
        }
    }
}
