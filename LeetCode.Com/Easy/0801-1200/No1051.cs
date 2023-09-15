using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Height Checker
    /// </summary>
    public class No1051
    {
        /*
         *  身高排序，问需要移动的最小人数。
            解题思路：先将顺序排好，再用原来数组和排序过的数组遍历对比，如果人位置不同，说明这个人需要移动，计数+1
            
            1 <= heights.length <= 100
            1 <= heights[i] <= 100
         */
        public int HeightChecker(int[] heights)
        {
            //复制数组
            int[] sortArray = new int[heights.Length];
            Array.Copy(heights, sortArray, heights.Length);
            //排序
            Array.Sort(sortArray);

            int count = 0;
            for (int i = 0; i < sortArray.Length; i++)
            {
                if (heights[i] != sortArray[i]) count++;
            }

            return count;
        }
    }
}
