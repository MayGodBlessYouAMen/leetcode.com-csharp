namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [485]  Max Consecutive Ones
    /// </summary>
    public class No0485
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxLen = 0;
            int currentLen = 0;

            //遍历计数，遇到0比较计数大小后清0，注意最后一条记录时比较计数结果
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                    }
                    currentLen = 0;
                    continue;
                }

                currentLen++;

                //last one
                if (i == nums.Length - 1)
                {
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        currentLen = 0;
                    }
                }
            }

            return maxLen;
        }
    }
}
