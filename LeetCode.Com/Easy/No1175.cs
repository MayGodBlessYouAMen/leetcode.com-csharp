using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Prime Arrangements
    /// </summary>
    public class No1175
    {
        /*
            解题思路:1~n的数组排序，保证所有质数放在index为质数的位置上。先遍历1-n，求出质数数量x。那么质数排列组合为x!,剩下非质数的排列组合为
            (n-x)!,最后结果为两者相乘。还要和1000000007取模

            注意：要防止int相乘后越界，直接定义返回值为long即可
         */
        public int NumPrimeArrangements(int n)
        {
            //计算质数数量
            int primeCount = 0;
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    primeCount++;
                }
            }

            //剩余数量
            int otherNum = n - primeCount;

            //取模数
            int modNum = (int)Math.Pow(10, 9) + 7;

            //计算最后的值。防止int越界，将此处定义为long
            long res = Factorial(primeCount, modNum) * Factorial(otherNum, modNum) % modNum;

            return (int)res;
        }

        /// <summary>
        /// 判断质数
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private bool IsPrime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 计算阶乘，返回取模后的值
        /// </summary>
        /// <param name="num"></param>
        /// <param name="modNum"></param>
        /// <returns></returns>
        private long Factorial(int num, int modNum)
        { 
            long res = 1;
            for (int i = 2; i <= num; i++)
            {
                res = res * i % modNum;
            }

            return res;
        }
    }
}
