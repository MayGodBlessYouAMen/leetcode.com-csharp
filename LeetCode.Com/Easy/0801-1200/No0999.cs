namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Available Captures for Rook
    /// </summary>
    internal class No0999
    {
        /*
         *  8*8的棋盘。车R可以在东南西北四个方向上移动。如果碰到主教B，会被阻挡。如果碰到兵p，可以捕获一个。返回R可以捕获的数量。
            解题思路：先找到车R的坐标。然后四个方向遍历。同一个方向最多只能捕获一个p

            .代表空格

            board.length == 8
            board[i].length == 8
            board[i][j] is either 'R', '.', 'B', or 'p'
            There is exactly one cell with board[i][j] == 'R'
         */
        public int NumRookCaptures(char[][] board)
        {
            int ri = 0;
            int rj = 0;
            //寻找R坐标
            FindR(board, ref ri, ref rj);

            //计数
            int count = 0;

            //左
            for (int i = ri; i >= 0; i--)
            {
                if (board[i][rj] == 'B')
                {
                    break;
                }

                if (board[i][rj] == 'p')
                {
                    count++;
                    break;
                }
            }

            //右
            for (int i = ri; i < 8; i++)
            {
                if (board[i][rj] == 'B')
                {
                    break;
                }

                if (board[i][rj] == 'p')
                {
                    count++;
                    break;
                }
            }

            //上
            for (int j = rj; j >= 0; j--)
            {
                if (board[ri][j] == 'B')
                {
                    break;
                }

                if (board[ri][j] == 'p')
                {
                    count++;
                    break;
                }
            }

            //下
            for (int j = rj; j < 8; j++)
            {
                if (board[ri][j] == 'B')
                {
                    break;
                }

                if (board[ri][j] == 'p')
                {
                    count++;
                    break;
                }
            }

            return count;
        }

        private static void FindR(char[][] board, ref int ri, ref int rj)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        ri = i;
                        rj = j;
                        return;
                    }
                }
            }
        }
    }
}
