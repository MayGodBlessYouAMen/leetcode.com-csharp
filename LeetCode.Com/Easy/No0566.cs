namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Reshape the Matrix
    /// </summary>
    internal class No0566
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int m = mat.Length;
            int n = mat[0].Length;

            //重塑不合法时，输出原来的矩阵
            if (m * n != r * c)
            {
                return mat;
            }

            //定义新矩阵
            int[][] newmat = new int[r][];
            for (int i = 0; i < r; i++)
            {
                newmat[i] = new int[c];
            }

            //重塑
            for (int i = 0; i < m * n; i++)
            {
                newmat[i / c][i % c] = mat[i / n][i % n];
            }

            return newmat;
        }
    }
}
