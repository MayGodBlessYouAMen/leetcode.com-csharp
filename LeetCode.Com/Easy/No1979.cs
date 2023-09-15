namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Find Greatest Common Divisor of Array
    /// </summary>
    public class No1979
    {
        /*
            解题思路:找出数组中最大和最小的两个数，返回这两个数的最大公约数

            2 <= nums.length <= 1000
            1 <= nums[i] <= 1000
         */
        public int FindGCD(int[] nums)
        {
            //找出最小值和最大值
            int min = 1000;
            int max = 1;
            foreach (var num in nums)
            {
                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }
            }

            //计算最大公约数并返回
            return GCD(min, max);
        }

        /// <summary>
        /// 计算两个整数的最大公约数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int GCD(int a, int b)
        {
            /*
             * 使用辗转相除法 ：
             * gcd(a,b) = gcd(b,a%b) 
                
             * 以除数和余数反复做除法运算，当余数为 0 时，取当前算式除数为最大公约数
             */

            while (a % b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return b;
        }
    }
}
