namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Final Prices With a Special Discount in a Shop
    /// </summary>
    public class No1475
    {
        /*
            解题思路：遍历数组，找到每个数字后面最近的，小于等于它的数字，就是优惠金额
         */
        public int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {

                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        prices[i] -= prices[j];
                        break;
                    }
                }
            }

            return prices;
        }
    }
}
