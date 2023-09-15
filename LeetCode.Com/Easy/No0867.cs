namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Transpose Matrix
    /// </summary>
    internal class No0867
    {
        /*
            解题思路：沿着主对角线（左上到右下），翻转矩阵。
                    实际效果是横列纵列交换位置

                    m == matrix.length
                    n == matrix[i].length
                    1 <= m, n <= 1000
                    1 <= m * n <= 105
                    -10^9 <= matrix[i][j] <= 10^9
         */
        public int[][] Transpose(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            //新矩阵
            int[][] newMatrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                newMatrix[i] = new int[m];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newMatrix[j][i] = matrix[i][j];
                }
            }

            return newMatrix;
        }
    }
}
