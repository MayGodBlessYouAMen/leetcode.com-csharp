namespace LeetCode.Com.Easy
{
    /// <summary>
    /// XOR Operation in an Array
    /// </summary>
    public class No1486
    {
        /*
            解题思路：从0遍历到n-1，按公式nums[i] = start + 2 * i计算nums[i]，并求异或

            1 <= n <= 1000
            0 <= start <= 1000
            n == nums.length
         */
        public int XorOperation(int n, int start)
        {
            //i=0时单独给初始值，方便后续遍历计算
            int result = start + 2 * 0;

            //跳过0开始遍历
            for (int i = 1; i < n; i++)
            {
                int numi = start + 2 * i;
                result = result ^ numi;
            }

            return result;
        }
    }
}
