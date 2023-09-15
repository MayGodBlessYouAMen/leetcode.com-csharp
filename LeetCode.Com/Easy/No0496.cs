namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [496]  Next Greater Element I
    /// </summary>
    public class No0496
    {
        public int[] NextGreaterElement(int[] findNums, int[] nums)
        {

            //find num1[i] in num2,if num2[j]==num1[i],then j++ and find num2[j] if num2[j]>num1[i]

            int[] nextNums = new int[findNums.Length];

            for (int i = 0; i < findNums.Length; i++)
            {
                int nextnum = -1;
                for (int j = nums.Length - 1; j >= 0; j--)
                {
                    if (nums[j] == findNums[i])
                    {
                        break;
                    }
                    if (nums[j] > findNums[i])
                    {
                        nextnum = nums[j];
                    }
                }

                nextNums[i] = nextnum;
            }

            return nextNums;
        }
    }
}
