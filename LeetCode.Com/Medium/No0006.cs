using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// 6. Zigzag Conversion
    /// </summary>
    public class No0006
    {
        public string Convert(string s, int nRows)
        {
            /*
               1. 1 <= s.length <= 1000
               2. s consists of English letters (lower-case and upper-case), ',' and '.'.
               3. 1 <= numRows <= 1000
             */

            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }

            char[] arr = s.ToCharArray();
            int length = arr.Length;
            if (length == 1 || nRows == 1)
            {
                return s;
            }

            //重复部分为竖着的nRows和斜向上的nRows-2 

            //计算最大列数
            int maxCellNum = (length % (nRows + nRows - 2) == 0) ? 
                            (length / (nRows + nRows - 2)) * (nRows - 1) : 
                            (length / (nRows + nRows - 2) + 1) * (nRows - 1);

            //定义一个nRows行 * maxCellNum列的空数组
            char[,] grid = new char[nRows, maxCellNum];

            int cell = -1;
            int n = 0;

            while (n < length)
            {
                //竖着的nRows
                cell++;
                for (int i = 0; i <= nRows - 1; i++)
                {
                    if (n >= length) break; 

                    grid[i, cell] = arr[n];
                    n++;
                }

                //斜向上的nRows-2 
                for (int i = nRows - 2; i >= 1; i--)
                {
                    if (n >= length) break;

                    cell++;
                    grid[i, cell] = arr[n];
                    n++;
                }

                if (n >= length) break;
            }

            char def = default;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < maxCellNum; j++)
                {
                    if (grid[i, j] != def)
                    {
                        sb.Append(grid[i, j]);
                    }
                }
            }
            return sb.ToString();
        }
    }
}
