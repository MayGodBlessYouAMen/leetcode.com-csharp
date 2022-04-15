using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Distribute Candies to People
    /// </summary>
    public class No1103
    {
        /*
            解题思路：从1开始发糖自增，注意index要对人数取模
         */
        public int[] DistributeCandies(int candies, int num_people)
        {
            int[] haveCandies = new int[num_people];

            //计数器
            int count = 0;
            while (candies > 0)
            {  
                //计算发糖人index
                int index = count % num_people;

                //自增
                count++;

                //自增，发糖
                haveCandies[index] += (candies > count ? count : candies);

                //减库存
                candies -= count;
            }

            return haveCandies;
        }
    }
}
