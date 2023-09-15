using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Relative Sort Array
    /// </summary>
    public class No1122
    {
        /*
            解题思路：定义一个容量为1001的数组，对应index上存放arr1中1-1000的数字的个数。
                      然后遍历arr2，取出对应index位置的数字放入新数组中。
                      最后再遍历一边1001数组，取出剩下的数字。

            1 <= arr1.length, arr2.length <= 1000
            0 <= arr1[i], arr2[i] <= 1000
            All the elements of arr2 are distinct.
            Each arr2[i] is in arr1.
         */
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {

            //定义范围数组，用于存放数组1数字个数
            int[] arrRange = new int[1001];

            //遍历数组1并计数
            foreach (var num in arr1)
            {
                arrRange[num]++;
            }

            //定义输出数组
            List<int> outputList = new List<int>();

            //遍历数组2，拿出对应的元素
            foreach (var num in arr2)
            {
                while (arrRange[num] > 0)
                {
                    outputList.Add(num);

                    //计数-1，直到0为止
                    arrRange[num]--;
                }
            }

            //遍历拿出剩下的数字
            for (int num = 0; num < arrRange.Length; num++)
            {
                while (arrRange[num] > 0)
                {
                    outputList.Add(num);
                    arrRange[num]--;
                }
            }

            return outputList.ToArray();
        }
    }
}
