using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [728]  Self Dividing Numbers
    /// </summary>
    public class No0728
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> numlist = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (IsSelfDivingNumber(i)) numlist.Add(i);
            }

            return numlist;
        }

        private bool IsSelfDivingNumber(int n)
        {
            int m = n;
            while (m > 0)
            {
                int a = m % 10;
                if (a != 0 && n % a == 0)
                {
                    m = m / 10;
                    continue;
                }
                return false;
            }

            return true;
        }
    }
}
