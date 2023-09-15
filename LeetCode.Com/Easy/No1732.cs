namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Find the Highest Altitude
    /// </summary>
    public class No1732
    {
        /*
            解题思路：初始点为0，给的数列为每次移动的高度。遍历累加，保留最大高度即可

            n == gain.length
            1 <= n <= 100
            -100 <= gain[i] <= 100
         */
        public int LargestAltitude(int[] gain)
        {
            int highest = 0;
            int currentHigh = 0;
            foreach (var item in gain)
            {
                currentHigh += item;
                if (currentHigh > highest)
                {
                    highest = currentHigh;
                }
            }
            return highest;
        }
    }
}
