using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Count Primes
    /// </summary>
    public class No0204
    {
        public int CountPrimes(int n)
        {
            //ps:1不是质数(素数)也不是和数

            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }

            return count;
        }

        private bool IsPrime(int n)
        {
            //若不能被2~根号n之间所有的数整除，则为素数
            //for (int i = 2; i * i <= n; i++)
            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                {
                    return false; //和数
                }
            }
            return true;  //质数
        }
    }
}
