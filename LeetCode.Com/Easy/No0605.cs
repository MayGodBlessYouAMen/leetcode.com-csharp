using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Can Place Flowers
    /// </summary>
    internal class No0605
    {
        /*
            只有一点，不能有两个花盆挨着。

            遍历种花，累计种花的数量，和给定的n比较即可
         */
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                //基础要求
                if (flowerbed[i] == 1)
                {
                    continue;
                }

                //第一个要单独处理
                if (i == 0)
                {
                    if (flowerbed.Length > 1 && flowerbed[i + 1] == 1)
                    {
                        continue;
                    }

                    flowerbed[i] = 1;
                    count++;
                    continue;
                }

                //最后一个也要单独处理
                if (i == flowerbed.Length - 1)
                {
                    if (flowerbed.Length > 1 && flowerbed[i - 1] == 1)
                    {
                        continue;
                    }

                    flowerbed[i] = 1;
                    count++;
                    continue;
                }

                //中间处理
                if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    count++;
                }
            }

            return count >= n;
        }
    }
}
