using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Flood Fill
    /// </summary>
    internal class No0733
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {

            //要填充点的值
            int fillVal = image[sr][sc];

            //定义新数组记录点的填充状态
            int[][] fillFlag = new int[image.Length][];
            for (int i = 0; i < fillFlag.Length; i++)
            {
                fillFlag[i] = new int[image[0].Length];
            }

            //递归填充
            FloodFill(image, sr, sc, newColor, fillVal, ref fillFlag);

            return image;
        }

        private void FloodFill(int[][] image, int sr, int sc, int newColor, int fillVal, ref int[][] fillFlag)
        {
            //范围判断
            if (sr < 0 || sr >= image.Length)
            {
                return;
            }

            //范围判断
            if (sc < 0 || sc >= image[0].Length)
            {
                return;
            }

            //判断当前点是否已经填充过
            if (fillFlag[sr][sc] == 1)
            {
                return;
            }

            //判断当前点是否可以填充
            if (image[sr][sc] != fillVal)
            {
                return;
            }

            //填充当前点
            image[sr][sc] = newColor;

            //修改填充状态
            fillFlag[sr][sc] = 1; 

            //左
            FloodFill(image, sr, sc - 1, newColor, fillVal, ref fillFlag);

            //右 
            FloodFill(image, sr, sc + 1, newColor, fillVal, ref fillFlag);

            //上
            FloodFill(image, sr - 1, sc, newColor, fillVal, ref fillFlag);

            //下
            FloodFill(image, sr + 1, sc, newColor, fillVal, ref fillFlag);

        }
    }
}
