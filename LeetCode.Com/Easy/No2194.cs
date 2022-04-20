using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Cells in a Range on an Excel Sheet
    /// </summary>
    public class No2194
    {
        /*
            解题思路：按照从上到下，从左到右的顺序，输出excel单元格的坐标。
                        利用char和int可以自由转换，可以遍历char。

            s.length == 5
            'A' <= s[0] <= s[3] <= 'Z'
            '1' <= s[1] <= s[4] <= '9'
            s consists of uppercase English letters, digits and ':'.
         */
        public IList<string> CellsInRange(string s)
        {
            char colStart = s[0];
            char colEnd = s[3];
            int rowStart = int.Parse(s[1].ToString());
            int rowEnd = int.Parse(s[4].ToString());

            List<string> list = new List<string>();
            for (int i = colStart; i <= colEnd; i++)
            {
                for (int j = rowStart; j <= rowEnd; j++)
                {
                    list.Add($"{(char)i}{j}");
                }
            }

            return list.ToArray();
        }
    }
}
