using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Happy Number
    /// </summary>
    public class No0202
    {
        public bool IsHappy(int n)
        {
            if (n == 1) return true;
            List<int> list = new List<int>();
            while (n > 1)
            {
                int temp = 0;
                while (n > 0)
                {
                    temp += (n % 10) * (n % 10);  //各位平方和
                    n = n / 10;
                }
                n = temp;
                if (list.Contains(n)) break;
                list.Add(n);
            }
            return n == 1;
        }
    }
}
