using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [492]  Construct the Rectangle
    /// </summary>
    public class No0492
    {
        public int[] ConstructRectangle(int area)
        {
            /*根据题目可知:
             1. area = L*W
             2. L>=W
             3. L-W尽量小
             故从令int i从sqrt(area)开始遍历，i>0;i--；
             若area%i==0，则W=i,L=area/i,break;
            */
            int[] sides = new int[2];
            for (int i = (int)Math.Sqrt(area); i > 0; i--)
            {
                if (area % i == 0)
                {
                    sides[0] = area / i;
                    sides[1] = i;
                    break;
                }
            }

            return sides;
        }
    }
}
