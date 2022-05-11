using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Determine Color of a Chessboard Square
    /// </summary>
    public class No1812
    {
        /*
            解题思路：以a1为起点。计算和a1的距离（用x轴距离加上y轴距离），如果为奇数，则颜色和a1相反，否则颜色和a1相同。
                a1颜色为black

            Return true if the square is white, and false if the square is black.
            coordinates.length == 2
            'a' <= coordinates[0] <= 'h'
            '1' <= coordinates[1] <= '8'
         */
        public bool SquareIsWhite(string coordinates)
        {
            int xLen = (int)coordinates[0] - (int)'a';
            int yLen = (int)coordinates[1] - 1;
            if ((xLen + yLen) % 2 == 0)
            {
                return false;
            }

            return true;
        }
    }
}
