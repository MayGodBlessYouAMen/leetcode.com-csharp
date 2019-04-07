using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Climbing Stairs
    /// </summary>
    public class No0070
    {
        public int ClimbStairs(int n)
        {
            /*
                一次只能走1-2步
                n=1,走1步 f(1) = 1
                n=2,走1+1步或者走2步，f(2)=2
                ...
                f(n)可以看成f(n-1)+1步，或者f(n-2)+2步，故f(n)=f(n-1)+f(n-2)
            
                就变成了斐波那契数列问题
             */

            if (n == 1 || n == 2)
            {
                return n;
            }

            //return ClimbStairs(n-1) + ClimbStairs(n-2);  //递归超时

            //试试数组
            int[] arr = new int[n + 1];
            arr[1] = 1;
            arr[2] = 2;
            for (int i = 3; i < n + 1; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];

        }
    }
}
