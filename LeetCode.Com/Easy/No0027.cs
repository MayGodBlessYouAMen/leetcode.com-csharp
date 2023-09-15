namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Remove Element
    /// </summary>
    public class No0027
    {
        public int RemoveElement(int[] nums, int val)
        {
            int len = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    len++;
                    nums[len - 1] = nums[i];
                }
            }
            return len;
        }
    }
}
