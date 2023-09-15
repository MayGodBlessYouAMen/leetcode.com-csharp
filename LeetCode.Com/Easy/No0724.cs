namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Find Pivot Index
    /// </summary>
    internal class No0724
    {
        /*
            解题思路：
            从左到右遍历，对比左右和，相等时跳出
         */

        public int PivotIndex(int[] nums)
        {
            //先求所有元素和
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }

            //从左往右遍历
            int leftSum = 0;
            int rightSum = sum;

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (i > 0)
                {
                    leftSum += nums[i - 1];
                }

                rightSum -= nums[i];

                if (leftSum == rightSum)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
