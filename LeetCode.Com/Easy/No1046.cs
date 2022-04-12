using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Last Stone Weight
    /// </summary>
    public class No1046
    {
        /*
            解题思路：排序，每次拿出最大重量的两个石头，x和y，且x<=y。
            如果x==y，摧毁x和y。
            如果x<y,摧毁x，然后从将y的重量变成y-x。这时要将这块石头重新排序进去。
            直到最多剩下一块石头。返回最后一块石头的重量。如果最后没有石头，返回0.

            1 <= stones.length <= 30
            1 <= stones[i] <= 1000
         */
        public int LastStoneWeight(int[] stones)
        {
            while (stones.Length > 1)
            {
                //先排序
                Array.Sort(stones);

                int len = stones.Length;
                int x = 0, y = 0; 
                if (stones[len - 1] <= stones[len - 2])
                {
                    x = stones[len - 1];
                    y = stones[len - 2];
                }
                else
                {
                    x = stones[len - 2];
                    y = stones[len - 1];
                }

                var list = new List<int>(stones);
                if (x == y)
                {
                    //移除x和y
                    list.RemoveAt(len - 1);
                    list.RemoveAt(len - 2);
                }
                else
                {
                    //y=y-x,移除x
                    list[len - 1] = list[len - 1] - list[len - 2];
                    list.RemoveAt(len - 2);
                }

                stones = list.ToArray();
            }

            if (stones.Length == 1)
            {
                return stones[0];
            }

            return 0;
           
        }
    }
}
