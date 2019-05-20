using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Add Digits
    /// </summary>
    public class No0258
    {
        public int AddDigits(int num)
        {
            /*
                  0 => 0
              01~10 => 1~9,1
              11~20 => 2~9,1,2
              21~30 => 3~9,1,2,3
              31~40 => 4~9,1,2,3,4
              41~50 => 5~9,1,2,3,4,5
              统计发现了数字规律:所求的数字为n%9所得的数字。但注意n为9的倍数且n>0时，所得结果应该是9
            */
            int digit = 0;
            if (num % 9 == 0 && num > 0)
            {
                digit = 9;
            }
            else
            {
                digit = num % 9;
            }

            return digit;
        }
    }
}
