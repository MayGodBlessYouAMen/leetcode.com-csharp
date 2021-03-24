using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// [189]Rotate Array
    /// </summary>
    public class No0189
    {
        /*
         * @lc app=leetcode id=189 lang=csharp
         *
         * [189] Rotate Array
         *
         * https://leetcode.com/problems/rotate-array/description/
         *
         * algorithms
         * Easy (29.12%)
         * Total Accepted:    274.2K
         * Total Submissions: 938.6K
         * Testcase Example:  '[1,2,3,4,5,6,7]\n3'
         *
         * Given an array, rotate the array to the right by k steps, where k is
         * non-negative.
         * 
         * Example 1:
         * 
         * 
         * Input: [1,2,3,4,5,6,7] and k = 3
         * Output: [5,6,7,1,2,3,4]
         * Explanation:
         * rotate 1 steps to the right: [7,1,2,3,4,5,6]
         * rotate 2 steps to the right: [6,7,1,2,3,4,5]
         * rotate 3 steps to the right: [5,6,7,1,2,3,4]
         * 
         * 
         * Example 2:
         * 
         * 
         * Input: [-1,-100,3,99] and k = 2
         * Output: [3,99,-1,-100]
         * Explanation: 
         * rotate 1 steps to the right: [99,-1,-100,3]
         * rotate 2 steps to the right: [3,99,-1,-100]
         * 
         * 
         * Note:
         * 
         * 
         * Try to come up as many solutions as you can, there are at least 3 different
         * ways to solve this problem.
         * Could you do it in-place with O(1) extra space?
         * 
         */

        public void Rotate(int[] nums, int k)
        {
            if (nums == null) return;
            int n = nums.Length;
            k = k % n;
            if (k == 0) return;  //如果是整数倍，数组会被还原

            #region 按照题目提供的算法移动。 × Time Limit Exceeded
            //while (k > 0)
            //{
            //    //先保存最后一位，然后把其他所有位往后移动一位
            //    int last = nums[n - 1];
            //    for (int i = n - 1; i >= 1; i--)
            //    {
            //        nums[i] = nums[i - 1];
            //    }
            //    nums[0] = last;
            //    k--;
            //}
            #endregion

            //先把翻转前n-k个数字，再翻转后k个数字，最后翻转整个数组
            Array.Reverse(nums, 0, n - k);
            Array.Reverse(nums, n - k, k);
            Array.Reverse(nums, 0, n);
        }
    }
}
