using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Shift 2D Grid
    /// </summary>
    public class No1260
    {
        /*
            解题思路：将每一列移到下一列，最后一列移动到第一列，然后将第一列最后一个元素移动到最开头。按要求移动k次就行了。
                    注意越界情况。

            m == grid.length
            n == grid[i].length
            1 <= m <= 50
            1 <= n <= 50
            -1000 <= grid[i][j] <= 1000
            0 <= k <= 100
         */
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            while (k > 0)
            {
                //临时保存最后一列
                int[] temp = new int[m];
                for (int i = 0; i < m; i++)
                {
                    temp[i] = grid[i][n - 1];
                }

                //倒序移动第i列到第1+1列，除了最后一列
                for (int i = n - 2; i >= 0; i--)
                {
                    for (int j = 0; j < m; j++)
                    {
                        grid[j][i + 1] = grid[j][i];
                    }
                }

                //处理保存的最后一列,将最后一个元素插入最上面，其他元素相应下移
                {
                    int last = temp[m - 1];
                    for (int i = m - 2; i >= 0; i--)
                    {
                        temp[i + 1] = temp[i];
                    }
                    temp[0] = last;
                }

                //将保存的最后一列放到第一列
                for (int i = 0; i < m; i++)
                {
                    grid[i][0] = temp[i];
                }

                k--;
            }

            return grid;
        }
    }
}
