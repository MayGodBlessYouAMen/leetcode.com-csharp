using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Best Time to Buy and Sell Stock    
    /// </summary>
    public class No0121
    {
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > profit)
                    {
                        profit = prices[j] - prices[i];
                    }
                }
            }
            return profit;
        }
    }
}
