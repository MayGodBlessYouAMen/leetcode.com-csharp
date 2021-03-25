using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [852]  Peak Index in a Mountain Array
    /// </summary>
    public class No0852
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            //二分查找
            int i = 1;
            int j = A.Length - 2;
            while (i < j)
            {
                int k = (i + j) / 2;
                if (A[k] > A[k - 1])
                {
                    i = k;
                }
                else
                {
                    j = k - 1;
                }
                if (A[k] < A[k + 1])
                {
                    i = k + 1;
                }
                else
                {
                    j = k;
                }
            }
            return i;
        }
        /*
        测试用例
        [0,1,0]
        [0,1,2,3,4,5,0]
        [0,5,4,3,2,1,0]
        [0,1,2,3,4,5,4,3,2,1,0]
        */
    }
}
