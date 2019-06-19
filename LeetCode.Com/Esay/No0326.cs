using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Power of Three
    /// </summary>
    public class No0326
    {
        public bool IsPowerOfThree(int n)
        {
            #region 首先想到的方法就是循环,提交能通过
            //if (n <= 0) return false;
            //while (n % 3 == 0)
            //{
            //    n = n / 3;
            //}
            //return n == 1;
            #endregion

            #region 其他思路
            /*题目中说是否可以不用循环或者递归?
             * 可以把int范围内3的幂都枚举出来，判断n是否在里面
            */
            List<int> powerOfThreeList = new List<int>();
            powerOfThreeList.Add(1);  //3^0
            long m = 1;
            while (m * 3 <= int.MaxValue)  //这个好像也是循环嘛。。orZ
            {
                m = m * 3;
                powerOfThreeList.Add((int)m);
            }
            if (powerOfThreeList.Contains(n)) return true;
            return false;
            #endregion
        }

    }
}
