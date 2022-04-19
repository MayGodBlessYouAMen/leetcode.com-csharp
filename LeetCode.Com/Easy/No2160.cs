using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Minimum Sum of Four Digit Number After Splitting Digits
    /// </summary>
    public class No2160
    {
        /*
            解题思路：四位数拆分为2个数字，求最小和。那么必定是拆分成2个2位数。
                        将所有数字从小到大排序，前两位分别给2个数字的十位，后两个数字分别给2个数字的各位。

            1000 <= num <= 9999
         */
        public int MinimumSum(int num)
        {
            int[] digits = new int[4];

            for (int i = 3; i >= 0; i--)
            {
                digits[i] = (int)(num / Math.Pow(10, i));
                num = (int)(num % Math.Pow(10, i));
            }

            Array.Sort(digits);

            return digits[0] * 10 + digits[1] * 10 + digits[2] + digits[3];
        }
    }
}
