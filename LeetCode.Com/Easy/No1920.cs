namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Build Array from Permutation
    /// </summary>
    public class No1920
    {
        /*
            解题思路：水题
         */
        public int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }
            return ans;
        }
    }
}
