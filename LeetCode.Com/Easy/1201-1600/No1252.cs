namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Cells with Odd Values in a Matrix
    /// </summary>
    public class No1252
    {
        /*
            题意：给定一个矩阵，初始所有值为0。再给一个索引列表，索引中所有点对应的矩阵的行和列都要值+1
            解体思路：暴力法
         */
        public int OddCells(int m, int n, int[][] indices)
        {
            //初始化矩阵
            int[][] matrix = new int[m][];
            for (int i = 0; i < m; i++)
            {
                matrix[i] = new int[n];
            }

            //遍历索引
            foreach (var index in indices)
            {
                //行值+1
                int rowIndex = index[0];
                for (int i = 0; i < n; i++)
                {
                    matrix[rowIndex][i]++;
                }

                //列值+1
                int cellIndex = index[1];
                for (int i = 0; i < m; i++)
                {
                    matrix[i][cellIndex]++;
                }
            }

            //寻找奇数个数
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
