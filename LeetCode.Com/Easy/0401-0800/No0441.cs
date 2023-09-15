namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [441]  Arranging Coins
    /// </summary>
    public class No0441
    {
        /*
         * @lc app=leetcode id=441 lang=csharp
         *
         * [441] Arranging Coins
         *
         * https://leetcode.com/problems/arranging-coins/description/
         *
         * algorithms
         * Easy (37.54%)
         * Total Accepted:    65K
         * Total Submissions: 172.9K
         * Testcase Example:  '5'
         *
         * You have a total of n coins that you want to form in a staircase shape,
         * where every k-th row must have exactly k coins.
         * ⁠
         * Given n, find the total number of full staircase rows that can be formed.
         * 
         * n is a non-negative integer and fits within the range of a 32-bit signed
         * integer.
         * 
         * Example 1:
         * 
         * n = 5
         * 
         * The coins can form the following rows:
         * ¤
         * ¤ ¤
         * ¤ ¤
         * 
         * Because the 3rd row is incomplete, we return 2.
         * 
         * 
         * 
         * Example 2:
         * 
         * n = 8
         * 
         * The coins can form the following rows:
         * ¤
         * ¤ ¤
         * ¤ ¤ ¤
         * ¤ ¤
         * 
         * Because the 4th row is incomplete, we return 3.
         * 
         * 
         */
        public int ArrangeCoins(int n)
        {
            int i = 1;
            // 2*n 和 i*(i+1)会超出int32
            for (i = 1; i / 2 * i < n; i++)
            {
                decimal a, b = 0;
                //用偶数除以2，防止丢失精度
                if (i % 2 == 0)
                {
                    a = i / 2;
                    b = 1 + i;
                }
                else
                {
                    a = i;
                    b = (i + 1) / 2;
                }
                decimal d2 = a * b;
                if (d2 == n) return i;
                if (d2 > n) return i - 1;
            }
            return i - 1;
        }
    }
}
