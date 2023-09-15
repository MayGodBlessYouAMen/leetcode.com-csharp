namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Subtract the Product and Sum of Digits of an Integer
    /// </summary>
    public class No1281
    {
        /*
         *  题意：给一个数字，返回其各位之积与各位之和的差。
            解题思路：直接计算即可

            1 <= n <= 10^5
         */
        public int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;

            while (n > 0)
            {
                int num = n % 10;
                product *= num;
                sum += num;

                n /= 10;
            }

            return product - sum;
        }
    }
}
