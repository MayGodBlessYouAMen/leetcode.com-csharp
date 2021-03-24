using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Excel Sheet Column Title
    /// </summary>
    public class No0168
    {
        /*A-Z一共26个字母。可以转化为一个26进制的问题,但是满26并不进1。 
         利用ascll编码A-Z对应65-90
         */
        public string ConvertToTitle(int n)
        {
            string title = "";

            if (n <= 26) return ((char)(n + 64)).ToString();

            while (n > 26)
            {

                int a = n / 26;
                int b = n % 26;
                if (b == 0)
                {
                    a = a - 1;
                    b = 26;
                }

                title = title.PadLeft(title.Length + 1, (char)(b + 64));
                if (a <= 26) title = title.PadLeft(title.Length + 1, (char)(a + 64));

                n = a;
            }

            return title;
        }
    }
}
