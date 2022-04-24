using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{

    /// <summary>
    /// Element Appearing More Than 25% In Sorted Array
    /// </summary>
    public class No1287
    {
        /*
            解题思路：因为排序数组，直接遍历计数，并计算该数字所占比例即可
         */
        public int FindSpecialInteger(int[] arr)
        {
            int n = arr.Length;

            int currentNum = arr[0];
            int currentNumCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == currentNum)
                {
                    currentNumCount++;
                }
                else
                {
                    //数字变化时，计算前一个数字所占比例
                    /*if (currentNumCount / n > 25 / 100)*/   //注意此处除法，会变成int计算。需要数字改成double，或者改成乘法
                    if (currentNumCount * 100  > 25 * n)
                    {
                        return currentNum;
                    }
                     
                    //改变计数的数字
                    currentNum = arr[i];
                    currentNumCount = 1;
                }
            }

            //计算最后一个数
            if (currentNumCount * 100 > 25 * n)
            {
                return currentNum;
            }

            return -1;
        }
    }
}
