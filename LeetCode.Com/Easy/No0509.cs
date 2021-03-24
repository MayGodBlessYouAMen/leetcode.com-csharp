using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [509]  Fibonacci Number
    /// </summary>
    public class No0509
    {
        public int Fib(int N)
        {
            if (N < 0) return 0;
            #region 递归
            //if(N == 0) return 0;
            //if(N == 1) return 1;
            //return Fib(N-1) + Fib(N-2);
            #endregion

            #region 非递归
            int[] arr = new int[31];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i <= N; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[N];
            #endregion
        }
    }
}
