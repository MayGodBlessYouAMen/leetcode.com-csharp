using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Maximum Nesting Depth of the Parentheses
    /// </summary>
    public class No1614
    {
        /*
            解题思路：计算连续左括号的数量，返回最大值
         */
        public int MaxDepth(string s)
        {
            int maxCount = 0;
            int count = 0;
            foreach (var item in s)
            {
                if (item == '(')
                {
                    count++;
                }

                if (item == ')')
                {
                    count--;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                }
            }

            return maxCount;
        }
    }
}
