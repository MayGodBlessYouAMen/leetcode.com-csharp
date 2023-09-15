namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [463]  Island Perimeter
    /// </summary>
    public class No0463
    {
        public int IslandPerimeter(int[,] grid)
        {
            int xLength = grid.GetLength(0);
            int yLength = grid.GetLength(1);

            int sides = 0;
            for (int i = 0; i < xLength; i++)
            {
                for (int j = 0; j < yLength; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        sides += GetSide(grid[i, j], i, j, grid);
                    }
                }
            }

            return sides;
        }

        /*
         ---->y
         -
         -
         -
         x

         思路:值为1的点，上下左右四个方向与0连接的部分算作边长1
        */
        private int GetSide(int n, int xIndex, int yIndex, int[,] grid)
        {
            int xLength = grid.GetLength(0);
            int yLength = grid.GetLength(1);

            int side = 0;

            //up
            if (xIndex == 0 || grid[xIndex - 1, yIndex] == 0)
            {
                side++;
            }

            //down
            if (xIndex == xLength - 1 || grid[xIndex + 1, yIndex] == 0)
            {
                side++;
            }

            //left
            if (yIndex == 0 || grid[xIndex, yIndex - 1] == 0)
            {
                side++;
            }

            //right
            if (yIndex == yLength - 1 || grid[xIndex, yIndex + 1] == 0)
            {
                side++;
            }

            return side;
        }
    }
}
