using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Fair Candy Swap
    /// </summary>
    internal class No0888
    {
        /*  
         *  题意：alice和bob糖果总数不相等。题目至少有一个解。只交换一个糖果罐。
            解题思路：先计算alice和bob的糖果总数，计算差得到c。
                      将alice的糖果罐存入字典。
                      遍历bob的糖果罐，用当前糖果罐数量加上c/2，如果能在alice糖果罐字典中找到相应的值，那么这就是要交换的两个罐子。
         */
        public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
        {
            Dictionary<int, int> aliceDic = new Dictionary<int, int>();

            int aliceCount = 0;
            for (int i = 0; i < aliceSizes.Length; i++)
            {
                aliceCount += aliceSizes[i];

                if (!aliceDic.ContainsKey(aliceSizes[i]))
                {
                    aliceDic.Add(aliceSizes[i], 1);
                }
            }

            int bobCount = 0;
            for (int i = 0; i < bobSizes.Length; i++)
            {
                bobCount += bobSizes[i];
            }

            //因为题目有解，所以aliceCount - bobCount必定是偶数。此处除法不用担心整除。
            int diff = (aliceCount - bobCount) / 2;

            int[] res = new int[2];
            for (int i = 0; i < bobSizes.Length; i++)
            {
                if (aliceDic.ContainsKey(bobSizes[i] + diff))
                {
                    res = new int[] { bobSizes[i] + diff, bobSizes[i] };
                    break;
                }
            }

            return res;
        }
    }
}
