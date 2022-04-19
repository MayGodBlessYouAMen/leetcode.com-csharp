using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Richest Customer Wealth
    /// </summary>
    public class No1672
    {
        /*
            解题思路：按行求和，比较即可
         */
        public int MaximumWealth(int[][] accounts)
        {
            int m = accounts.Length;
            int n = accounts[0].Length;
            int max = 0;
            for (int i = 0; i < m; i++)
            {
                int temp = 0;
                for (int j = 0; j < n; j++)
                {
                    temp += accounts[i][j];
                }
                if (temp > max)
                {
                    max = temp;
                }
            }
            return max;
        }
    }
}
