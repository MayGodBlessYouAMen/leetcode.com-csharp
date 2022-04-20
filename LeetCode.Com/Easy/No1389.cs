using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Create Target Array in the Given Order
    /// </summary>
    public class No1389
    {
        /*
            解题思路：遍历数组，在index[i]的位置插入nums[i]。

            1 <= nums.length, index.length <= 100
            nums.length == index.length
            0 <= nums[i] <= 100
            0 <= index[i] <= i

            index[i] should be less or equal than i
         */
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            //使用List，方便插入
            List<int> targetList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                targetList.Insert(index[i], nums[i]);
            }
            
            return targetList.ToArray();
        }
    }
}
