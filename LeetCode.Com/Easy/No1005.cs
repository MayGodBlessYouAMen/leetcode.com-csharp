using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [1005]  Maximize Sum Of Array After K Negations
    /// </summary>
    public class No1005
    {
        public int LargestSumAfterKNegations(int[] A, int K)
        {
            /*
                思路:按绝对值从大到小排序。
                从大到小遍历，遇到负数就变为正数（次数不超过k）,如果到末尾了k还没用完，则剩下的次数都用于操作末尾数。
             */

            //冒泡，绝对值从小到大排序
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - 1 - i; j++)
                {
                    if (System.Math.Abs(A[j]) > System.Math.Abs(A[j + 1]))
                    {
                        int a = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = a;
                    }
                }
            }

            //从大到小遍历
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (K <= 0) break;

                if (A[i] < 0)
                {
                    A[i] = A[i] * -1;
                    K--;
                }
            }

            while (K > 0)
            {
                A[0] = A[0] * -1;
                K--;
            }

            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }

            return sum;
        }
    }
}
