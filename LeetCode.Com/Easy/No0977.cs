using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [977]  Squares of a Sorted Array
    /// </summary>
    public class No0977
    {
        public int[] SortedSquares(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] *= A[i];
            }

            Array.Sort(A);  //可以换成自己写的排序
            return A;
        }
    }
}
