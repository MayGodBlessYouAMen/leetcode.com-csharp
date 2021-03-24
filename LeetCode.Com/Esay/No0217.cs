using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Contains Duplicate
    /// </summary>
    public class No0217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length <= 1) return false;

            //先排序
            Array.Sort(nums);

            #region 超时写法
            //直接的遍历，超时
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            return true;
            //        }
            //    }
            //}
            #endregion

            #region 正确写法
            //因为排序过，所以相等的两个数字肯定是挨着的，只需要遍历一遍即可
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return true;
                }
            }
            #endregion

            return false;

        }
    }
}
