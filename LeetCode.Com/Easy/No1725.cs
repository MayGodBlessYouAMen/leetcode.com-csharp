using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Number Of Rectangles That Can Form The Largest Square
    /// </summary>
    public class No1725
    {
        /*
            解题思路：长方形中截取最大的正方形，取较小的那条边长即可。用字典保存所有的正方形边长并计数。最后返回最大边长的数量
         */
        public int CountGoodRectangles(int[][] rectangles)
        {
            Dictionary<int, int> squareDic = new Dictionary<int, int>();
            int maxLen = 0;
            foreach (var rectangle in rectangles)
            {
                int len = rectangle[0] > rectangle[1] ? rectangle[1] : rectangle[0];
                if (len > maxLen)
                {
                    maxLen = len;
                }
                if (squareDic.ContainsKey(len))
                {
                    squareDic[len]++;
                }
                else
                {
                    squareDic.Add(len, 1);
                }
            }

            return squareDic[maxLen];

        }
    }
}
