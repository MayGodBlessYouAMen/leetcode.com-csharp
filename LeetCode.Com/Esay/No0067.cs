using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Add Binary
    /// </summary>
    public class No0067
    {
        public string AddBinary(string a, string b)
        {
            //从低位到高位，按位加。2进制
            int maxLen = a.Length > b.Length ? a.Length : b.Length;
            string sum = ""; //总和
            int enterone = 0; //进位

            //注意数字低位到高位对应的字符数组index是高到低
            for (int i = 0; i < maxLen; i++)
            {
                int m = 0;
                int n = 0;

                if (i < a.Length)
                {
                    m = int.Parse(a[a.Length - 1 - i].ToString());
                }
                if (i < b.Length)
                {
                    n = int.Parse(b[b.Length - 1 - i].ToString());
                }

                int temp = m + n + enterone;
                switch (temp)
                {
                    case 3:
                        sum = "1" + sum;
                        enterone = 1;
                        break;
                    case 2:
                        sum = "0" + sum;
                        enterone = 1;
                        break;
                    default:
                        sum = temp.ToString() + sum;
                        enterone = 0;
                        break;
                }
            }

            if (enterone == 1) sum = "1" + sum;

            return sum;
        }
    }
}
