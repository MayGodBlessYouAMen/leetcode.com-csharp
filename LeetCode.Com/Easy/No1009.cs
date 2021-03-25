using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [1009]  Complement of Base 10 Integer
    /// </summary>
    public class No1009
    {
        public int BitwiseComplement(int N)
        {
            //转为二进制
            string binaryString = Convert.ToString(N, 2);

            //求补码
            binaryString = binaryString.Replace("0", "T");
            binaryString = binaryString.Replace("1", "0");
            binaryString = binaryString.Replace("T", "1");

            //转为十进制
            int n = Convert.ToInt32(binaryString, 2);

            return n;
        }
    }
}
