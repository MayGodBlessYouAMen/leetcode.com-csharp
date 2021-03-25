using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [961]  N-Repeated Element in Size 2N Array
    /// </summary>
    public class No0961
    {
        public int RepeatedNTimes(int[] A)
        {
            Array.Sort(A);
            if (A[A.Length / 2 - 1] == A[A.Length / 2 - 2]) return A[A.Length / 2 - 1];
            return A[A.Length / 2];
        }
    }
}
