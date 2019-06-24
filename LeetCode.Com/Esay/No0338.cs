using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// [338] Counting Bits
    /// </summary>
    public class No0338
    {
        public int[] CountBits(int num)
        {

            int[] arr = new int[num + 1];
            for (int i = 0; i <= num; i++)
            {
                arr[i] = CountOneNum(i);
            }

            return arr;
        }

        public int CountOneNum(int num)
        {
            int n = num;
            int count = 0;
            while (true)
            {
                if (n % 2 == 1)
                {
                    count++;
                }
                n = n / 2;
                if (n == 0)
                {
                    break;
                }
            }
            return count;
        }
    }
}
