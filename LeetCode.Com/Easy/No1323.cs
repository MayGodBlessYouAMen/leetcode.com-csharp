using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Maximum 69 Number
    /// </summary>
    public class No1323
    {
        /*
            解题思路：从高位到低位，找到第一个6，改成9即可。如果没有6，则不用改动

            1 <= num <= 10^4
            num consists of only 6 and 9 digits.
         */
        public int Maximum69Number(int num)
        {
            int res = num;
            int[] digits = new int[4];
            for (int i = 3; i >= 0; i--)
            {
                //判断最高位是否为6
                if (num/(int)Math.Pow(10,i) == 6)
                {
                    res += 3 * (int)Math.Pow(10, i);
                    break;
                }

                //去除最高位
                num = num % (int)Math.Pow(10, i);
            }

            return res;
        }
    }
}
