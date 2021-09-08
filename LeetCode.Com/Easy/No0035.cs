using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Search Insert Position
    /// </summary>
    public class No0035
    {
        public int SearchInsert(int[] nums, int target)
        {
            #region 遍历 o(n);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == target) return i;
            //    if (nums[i] > target) return i;
            //}

            //return nums.Length;
            #endregion

            #region 二分查找
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] > target)
                {
                    right = mid - 1;
                    continue;
                }

                if (nums[mid] < target)
                {
                    left = mid + 1;
                    continue;
                }

                return mid;
            }

            //此处应该有left==right
            if (nums[left] >= target)
            {
                return left;
            }
            else
            {
                return right + 1;
            }
            #endregion 
        }
    }
}
