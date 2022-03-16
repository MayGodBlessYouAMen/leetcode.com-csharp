using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Toeplitz Matrix
    /// </summary>
    internal class No0766
    {
        /*
            解题思路:
                给定m * n的矩阵
                Toeplitz矩阵的定义: 从矩阵左上到右下,每条对角线上元素各自相等。
                对角线的画法：第一行和第一列每个元素从左上往右下画对角线即可。
                对角线下个元素坐标：x和y各自+1即可
                另外：第一行和第一列最后一个元素不用判断，因为对角线上只有一个元素。
         */
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            //高度
            int m = matrix.Length;

            //宽度
            int n = matrix[0].Length;

            //纵向
            for (int i = 0; i < m - 1; i++)
            {
                if (!IsToeplitz(matrix, i, 0))
                {
                    return false;
                }
            }

            //横向
            for (int i = 1; i < n - 1; i++)
            {
                if (!IsToeplitz(matrix, 0, i))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsToeplitz(int[][] matrix, int y, int x)
        {
            //高度
            int m = matrix.Length;

            //宽度
            int n = matrix[0].Length;

            //目标值
            int target = matrix[y][x];

            while (y < m && x < n)
            {
                if (matrix[y][x] != target)
                {
                    return false;
                }

                //计算对角线下个坐标
                x++;
                y++;
            }

            return true;

        }
    }
}
