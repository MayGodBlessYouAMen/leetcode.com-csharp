using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Sum of Digits in Base K
    /// </summary>
    public class No1837
    {
        /*
            解题思路：先把十进制数n，转换为k进制数，然后计算每位数字和

            1 <= n <= 100
            2 <= k <= 10
         */
        public int SumBase(int n, int k)
        {
            List<int> list = new List<int>();
            while (n > 0)
            {
                list.Add(n % k);
                n = n / k;
            }
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }
    }
}
