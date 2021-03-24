using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [832]  Flipping an Image
    /// </summary>
    public class No0832
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    //1.0->1,1->0
                    if (A[i][j] == 0)
                    {
                        A[i][j] = 1;
                    }
                    else
                    {
                        A[i][j] = 0;
                    }
                }

                //2.左右倒序
                Array.Reverse(A[i]);
            }

            return A;
        }
    }
}
