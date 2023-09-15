using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [415]  Add Strings
    /// </summary>
    public class No0415
    {
        /*
         * @lc app=leetcode id=415 lang=csharp
         *
         * [415] Add Strings
         *
         * https://leetcode.com/problems/add-strings/description/
         *
         * algorithms
         * Easy (43.23%)
         * Total Accepted:    90.9K
         * Total Submissions: 209.2K
         * Testcase Example:  '"0"\n"0"'
         *
         * Given two non-negative integers num1 and num2 represented as string, return
         * the sum of num1 and num2.
         * 
         * Note:
         * 
         * The length of both num1 and num2 is < 5100.
         * Both num1 and num2 contains only digits 0-9.
         * Both num1 and num2 does not contain any leading zero.
         * You must not use any built-in BigInteger library or convert the inputs to
         * integer directly.
         * 
         * 
         */

        public string AddStrings(string num1, string num2)
        {
            //大数相加，按位计算即可。

            int len1 = num1.Length;
            int len2 = num2.Length;
            int bigLen = len1 > len2 ? len1 : len2;
            int[] sums = new int[bigLen + 1];

            int n1, n2, sum, carry = 0;
            while (bigLen >= 0)
            {
                n1 = 0;
                if (len1 > 0)
                {
                    n1 = int.Parse(num1[len1 - 1].ToString());
                    len1--;
                }

                n2 = 0;
                if (len2 > 0)
                {
                    n2 = int.Parse(num2[len2 - 1].ToString());
                    len2--;
                }

                sum = n1 + n2 + carry;
                sums[bigLen] = sum % 10;
                carry = sum / 10;

                bigLen--;
            }

            if (carry == 1)
            {
                sums[0] = 1;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sums.Length; i++)
            {
                if (i == 0 && sums[0] == 0) continue;

                sb.Append(sums[i]);
            }

            return sb.ToString();
        }
    }
}