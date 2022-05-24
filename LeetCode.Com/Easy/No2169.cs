using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Count Operations to Obtain Zero
    /// </summary>
    public class No2169
    {
        /*
            解题思路：按要求减即可，直到两个数至少其中一个为0
         */
        public int CountOperations(int num1, int num2)
        {
            int step = 0;
            while (num1 != 0 && num2 != 0)
            {
                step++;

                if (num1 >= num2)
                {
                    num1 -= num2;
                    continue;
                }

                num2 -= num1;
            }

            return step;
        }
    }
}
