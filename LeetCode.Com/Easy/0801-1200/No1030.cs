using System;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Matrix Cells in Distance Order
    /// </summary>
    public class No1030
    {
        /*
            解题思路:遍历计算每个点到中心点的距离，然后按从小到大排序。
         */
        public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
        {
            //计算最长距离。比较中心点到四个角的距离，用最大宽加上最大高。
            int maxDistence = Math.Max(rCenter - 0, rows - rCenter) + Math.Max(cCenter - 0, cols - cCenter);

            //定义字典。用于存放距离0-maxDistence的所有点。
            Dictionary<int, List<int[]>> dicDistance = new Dictionary<int, List<int[]>>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var currentPoint = new int[] { i, j };
                    int dictance = Math.Abs(rCenter - i) + Math.Abs(cCenter - j);
                    if (!dicDistance.ContainsKey(dictance))
                    {
                        dicDistance.Add(dictance, new List<int[]>());
                    }
                    dicDistance[dictance].Add(currentPoint);
                }
            }

            List<int[]> result = new List<int[]>();
            for (int i = 0; i <= maxDistence; i++)
            {
                if (dicDistance.ContainsKey(i))
                {
                    foreach (var point in dicDistance[i])
                    {
                        result.Add(point);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
