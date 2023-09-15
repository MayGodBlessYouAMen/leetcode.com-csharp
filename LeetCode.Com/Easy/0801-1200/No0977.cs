using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [977]  Squares of a Sorted Array
    /// </summary>
    public class No0977
    {
        /// <summary>
        /// A是升序排序
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] SortedSquares(int[] A)
        {
            #region 使用Array.Sort，提交通过
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] *= A[i];
            //}

            //Array.Sort(A);  //可以换成自己写的排序
            //return A;
            #endregion

            #region 自己写排序  
            //因为是排好序的，所以可以首尾比较，做到o(n)
            int[] squareA = new int[A.Length];
            int left = 0;
            int right = A.Length - 1;
            int currentIndex = A.Length - 1;
            while (left <= right && currentIndex >= 0)
            {
                if (Math.Abs(A[left]) < Math.Abs(A[right]))
                {
                    squareA[currentIndex] = A[right] * A[right];
                    right--;
                }
                else
                {
                    squareA[currentIndex] = A[left] * A[left];
                    left++;
                }
                currentIndex--;
            }

            return squareA;
            #endregion
        }
    }
}
