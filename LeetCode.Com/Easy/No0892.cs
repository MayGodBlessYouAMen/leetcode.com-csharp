using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Surface Area of 3D Shapes
    /// </summary>
    internal class No0892
    {
        /*
            题意：求形状的表面积。底面也要包括进去。
            解题思路：上下的面积可以直接计算，1或者0。四周的面积根据和相邻柱子高度差计算。

            n == grid.length == grid[i].length
            1 <= n <= 50
            0 <= grid[i][j] <= 50
         */
        public int SurfaceArea(int[][] grid)
        {

            //长和宽
            int n = grid.Length;

            //面积
            int surfaceArea = 0;

            //遍历每个点
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //点为0时面积为0
                    if (grid[i][j] == 0)
                    {
                        continue;
                    }

                    //z轴上下
                    {
                        surfaceArea += 2;
                    }

                    //x轴-左
                    {
                        //计算比左边柱子高出来的面积

                        if (j == 0)
                        {
                            //自己是最左边的柱子
                            surfaceArea += grid[i][j];
                        }
                        else
                        {
                            if (grid[i][j] > grid[i][j - 1])
                            {
                                surfaceArea += grid[i][j] - grid[i][j - 1];
                            }
                        }
                    }

                    //x轴-右
                    {
                        //计算比右边柱子高出来的面积

                        if (j == n - 1)
                        {
                            //自己是最右边的柱子
                            surfaceArea += grid[i][j];
                        }
                        else
                        {
                            if (grid[i][j] > grid[i][j + 1])
                            {
                                surfaceArea += grid[i][j] - grid[i][j + 1];
                            }
                        }
                    }

                    //y轴-上
                    {
                        //计算比上边柱子高出来的面积
                        if (i == 0)
                        {
                            //自己是最上边的柱子
                            surfaceArea += grid[i][j];
                        }
                        else
                        {
                            if (grid[i][j] > grid[i - 1][j])
                            {
                                surfaceArea += grid[i][j] - grid[i - 1][j];
                            }
                        }
                    }

                    //y轴-下
                    {
                        //计算比下边柱子高出来的面积

                        if (i == n - 1)
                        {
                            //自己是最下边的柱子
                            surfaceArea += grid[i][j];
                        }
                        else
                        {
                            if (grid[i][j] > grid[i + 1][j])
                            {
                                surfaceArea += grid[i][j] - grid[i + 1][j];
                            }
                        }
                    }

                }
            }

            return surfaceArea;
        }
    }
}
