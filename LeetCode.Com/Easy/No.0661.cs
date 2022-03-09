using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Image Smoother
    /// </summary>
    internal class No0661
    {
        /*
            解题思路: 每个点的值等于它自己和周围所有相邻的值相加求平均值。注意边界条件。
         */
        public int[][] ImageSmoother(int[][] img)
        {
            int height = img.Length;
            int width = img[0].Length;

            //定义新矩阵
            int[][] newImg = new int[height][];
            for (int i = 0; i < height; i++)
            {
                newImg[i] = new int[width];
            }

            for (int i = 0; i <= height - 1; i++)
            {
                for (int j = 0; j <= width - 1; j++)
                {
                    //Console.WriteLine($"{i}-{j}");
                    newImg[i][j] = Smoother(img, i, j, height, width);
                }
            }

            return newImg;
        }

        private int Smoother(int[][] img, int i, int j, int height, int width)
        {
            int count = 0;
            int sum = 0;
            for (int h = -1; h <= 1; h++)
            {
                for (int w = -1; w <= 1; w++)
                {
                    int currentH = i + h;
                    int currentW = j + w;
                    if (currentH >= 0 && currentH <= height - 1 &&
                        currentW >= 0 && currentW <= width - 1)
                    {
                        count++;
                        sum += img[currentH][currentW];
                        //Console.WriteLine(img[currentH][currentW]);
                    }
                }
            }

            return sum / count;
        }
    }
}
