using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [172] Factorial Trailing Zeroes
    /// </summary>
    public class No0172
    {
        /*
          * 求n的阶乘结果中尾部0的个数。例如 10!=3628800，返回2。
          * 测试发现int.MaxValue：2147483647的阶乘返回尾部有536870902个0，所以计算n阶乘的方法应该行不通。
          * 尝试分析末尾0的来源，2*5 *10 ...
          * 转为计算因数中2和5的个数
          * 由于每两个数就有1个2的倍数，每5个才有5的倍数，可知因数2的数量远多于5，故计算5的个数就可以。 
          * 
         */

        #region 超时
        ////* 先找到1-n中是5倍数数字位置，再计算各个5倍数位置的数字有多少个5的因子，加起来即可
        //public int TrailingZeroes(int n)
        //{
        //    int count = 0;
        //    for (int i = 5; i <= n; )
        //    {
        //        count += FactorNumber(i, 5);
        //        if (i > int.MaxValue - 5)
        //        {
        //            //防止炸裂
        //            break;
        //        }
        //        i = i + 5;
        //    }

        //    return count;
        //}

        ///// <summary>
        ///// 计算n的因数k的个数
        ///// </summary>
        ///// <param name="n"></param>
        ///// <param name="k"></param>
        ///// <returns></returns>
        //private int FactorNumber(int n, int k)
        //{
        //    int count = 0;
        //    while (n >= k)
        //    {
        //        if (n % k != 0) break;
        //        count++;
        //        n = n / k;
        //    }
        //    return count;
        //}
        #endregion

        #region 优化
        //5有1个因子5，25有2个因子5，125有3个因子5... 
        //计算5的倍数个数，计算25的倍数个数，计算125倍数个数，...计算5^i倍数个数，求和
        //f(5) + f(25) + f(125) + ... + f(5^i)
        public int TrailingZeroes(int n)
        {
            int count = 0;
            while (n >= 5)
            {
                count += n / 5;
                n = n / 5;
            }

            return count;
        }
        #endregion

    }
}
