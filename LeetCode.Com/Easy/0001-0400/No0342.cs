using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [342] Power of Four
    /// </summary>
    public class No0342
    {
        public bool IsPowerOfFour(int num)
        {
            if (num <= 0) return false;

            //一般方法可以参考 [326] Power of Three
            //下面用其他方法

            //2的幂满足 num&(num-1) == 0
            if ((num & (num - 1)) != 0) return false;

            #region 方法一
            /* 和2的幂类似，二进制里只有一个1，但是4的幂所有1都只在奇数位。
             * 用int范围内最大的所有奇数位为1偶数位为0的二进制数和num做与运算
             * 得到的数如果等于num，则满足要求
             */
            int template = Convert.ToInt32("1010101010101010101010101010101", 2);
            if ((num & template) != num) return false;
            #endregion

            #region 方法二
            //4的幂还满足减去1是3的倍数
            if ((num - 1) % 3 != 0) return false;
            #endregion  

            return true;
        }
    }
}
