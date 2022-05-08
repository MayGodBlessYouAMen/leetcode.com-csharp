using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Find Target Indices After Sorting Array
    /// </summary>
    public class No2089
    {
        /*
         * 解题思路：数组先排序，然后遍历记录等于target的index
         * 
            1 <= nums.length <= 100
            1 <= nums[i], target <= 100
         */
        public IList<int> TargetIndices(int[] nums, int target)
        {
            List<int> result = new List<int>();

            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
