namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Matrix Diagonal Sum
    /// </summary>
    public class No1572
    {
        /*
            解题思路:给的是正方形的矩阵，求两条对角线上所有元素之和。如果为奇数时，要减去一次正中心的那个值，因为会加两次。

            n == mat.length == mat[i].length
            1 <= n <= 100
            1 <= mat[i][j] <= 100
         */
        public int DiagonalSum(int[][] mat)
        {
            int m = mat.Length;

            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += mat[i][i];

                sum += mat[m - 1 - i][i];
            }

            //奇数时，减去正中心点
            if (m % 2 != 0)
            {
                sum -= mat[m / 2][m / 2];
            }

            return sum;

        }
    }
}
