using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [171] Excel Sheet Column Number
    /// </summary>
    public class No0171
    {
        public int TitleToNumber(string s)
        {
            /*
             * 简单的进制问题
             * A->1  Z->26   
             * AB -> A* 26^1 + B * 26^0 ->  1*26^1 + 2*26^0 -> 28
             * 
             * ascll:  A->65 Z->90
             */

            if (string.IsNullOrWhiteSpace(s)) return 0;

            s = s.ToUpper();
            double n = 0;   //位数
            double sum = 0; //求和
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int a = s[i] - 65 + 1;
                sum += a * Math.Pow(26, n);
                n++;
            }

            return (int)sum;
        }
    }
}
