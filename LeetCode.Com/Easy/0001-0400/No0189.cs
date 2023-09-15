using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [189] Rotate Array
    /// </summary>
    public class No0189
    {
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

            #region AC
            //先把翻转前n-k个数字，再翻转后k个数字，最后翻转整个数组
            Array.Reverse(nums, 0, n - k);
            Array.Reverse(nums, n - k, k);
            Array.Reverse(nums, 0, n);
            #endregion
        }

    }
}
