using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [657]  Robot Return to Origin
    /// </summary>
    public class No0657
    {
        public bool JudgeCircle(string moves)
        {
            int[] point = new int[2] { 0, 0 };
            for (int i = 0; i < moves.Length; i++)
            {
                Move(point, moves[i]);
            }
            if (point[0] == 0 && point[1] == 0) return true;
            return false;
        }

        private void Move(int[] point, char step)
        {
            switch (step)
            {
                case 'U':
                    point[0] += 1;
                    break;
                case 'D':
                    point[0] -= 1;
                    break;
                case 'L':
                    point[1] -= 1;
                    break;
                case 'R':
                    point[1] += 1;
                    break;
                default:
                    break;
            }
        }
    }
}
