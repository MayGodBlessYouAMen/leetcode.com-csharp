namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Projection Area of 3D Shapes
    /// </summary>
    internal class No0883
    {
        /*
            解题思路：
                grid是n*n的正方形。
                底面z投影最大为1，要注意z投影也可能为0。
                侧面面积根据同一维度上最大的计算。
         */
        public int ProjectionArea(int[][] grid)
        {
            int ylenth = grid.Length;
            int xlenth = grid[0].Length;

            //x投影
            int xArea = 0;
            for (int y = 0; y < ylenth; y++)
            {
                int xMax = 0;
                for (int x = 0; x < xlenth; x++)
                {
                    if (grid[y][x] > xMax)
                    {
                        xMax = grid[y][x];
                    }
                }
                xArea += xMax;
            }

            //y投影
            int yArea = 0;
            for (int x = 0; x < xlenth; x++)
            {
                int yMax = 0;
                for (int y = 0; y < ylenth; y++)
                {
                    if (grid[y][x] > yMax)   //注意数组x和y的顺序
                    {
                        yMax = grid[y][x];
                    }
                }
                yArea += yMax;
            }

            //z投影。要注意z投影可能为0的情况
            int zArea = 0;
            for (int y = 0; y < ylenth; y++)
            {
                for (int x = 0; x < xlenth; x++)
                {
                    if (grid[y][x] > 0)
                    {
                        zArea++;
                    }
                }
            }

            //求和返回
            return xArea + yArea + zArea;
        }
    }
}
