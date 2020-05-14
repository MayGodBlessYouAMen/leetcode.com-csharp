using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Reverse Bits
    /// </summary>
    public class No0190
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;
            //位运算。从右向左每位取出来，添加到新整数的最低位
            for (int i = 0; i < 32; i++)
            {
                result = result << 1;  //左移1位
                if ((n & 1) == 1)
                {
                    result += 1;        //进位
                }
                n = n >> 1;             //右移
            }
            return result;
        }
    }
}
