namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Best Time to Buy and Sell Stock II
    /// </summary>
    public class No0122
    {
        public int MaxProfit(int[] prices)
        {
            //贪心,所有正价格增长相加。
            int sum = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                int pricesdiff = prices[i] - prices[i - 1];
                if (pricesdiff > 0)
                {
                    sum += pricesdiff;
                }
            }
            return sum;
        }
    }
}
