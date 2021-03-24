using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [504]  Base 7
    /// </summary>
    public class No0504
    {
        public string ConvertToBase7(int num)
        {
            //进制转换:10进制转7进制

            string sign = "";
            if (num < 0)
            {
                sign = "-";
                num *= -1;
            }

            List<int> remainderList = new List<int>();
            do
            {
                int remainder = num % 7;
                num = num / 7;
                remainderList.Add(remainder);
            }
            while (num > 0);

            StringBuilder sb = new StringBuilder();
            for (int i = remainderList.Count - 1; i >= 0; i--)
            {
                sb.Append(remainderList[i].ToString());
            }

            return sign + sb.ToString();
        }
    }
}
