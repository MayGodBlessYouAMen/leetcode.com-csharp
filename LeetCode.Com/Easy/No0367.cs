using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [367] Valid Perfect Square
    /// </summary>
    public class No0367
    {
        public bool IsPerfectSquare(int num)
        {
            if (num < 1) return false;
            if (num == 1) return true;

            for (long i = 2; i * i <= num; i++)  //i++之后的i*i可能会超过int.MaxValue,所以i定义为int会有case报错，改为long即可。
            {
                if (i * i == num) return true;
            }

            return false;
        }
    }
}
