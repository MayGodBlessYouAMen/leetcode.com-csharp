namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Count Negative Numbers in a Sorted Matrix
    /// </summary>
    public class No1351
    {
        /*
            解题思路：非递增的矩阵，计算其中负数的数量。倒序遍历即可，其中每行或者每列找到非负数则停止寻找。

            m == grid.length
            n == grid[i].length
            1 <= m, n <= 100
            -100 <= grid[i][j] <= 100
         */
        public int CountNegatives(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            int count = 0;
            for (int i = m - 1; i >= 0; i--)
            {
                if (grid[i][n - 1] >= 0)
                {
                    break;
                }

                for (int j = n - 1; j >= 0; j--)
                {
                    if (grid[i][j] >= 0)
                    {
                        break;
                    }

                    count++;
                }
            }

            return count;
        }
    }
}
