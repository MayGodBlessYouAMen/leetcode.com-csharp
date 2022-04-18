using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Split a String in Balanced Strings
    /// </summary>
    public class No1221
    {
        /*
            解题思路：用栈。栈空时，将R或者L压栈，碰到L或者R就出栈一个，出栈直到栈空，计数加1

            1 <= s.length <= 1000
            s[i] is either 'L' or 'R'.
            s is a balanced string.
         */
        public int BalancedStringSplit(string s)
        {

            //定义栈
            Stack<char> tempStack = new Stack<char>();

            //记录分割次数
            int splitCount = 0;

            //用于记录栈底元素
            char start = ' ';

            for (int i = 0; i < s.Length; i++)
            {
                //记录栈底元素
                if (tempStack.Count == 0)
                {
                    start = s[i];
                }

                //压栈
                if (s[i] == start)
                {
                    tempStack.Push(s[i]);
                    continue;
                }

                //弹出
                tempStack.Pop();

                //判断空栈
                if (tempStack.Count == 0)
                {
                    splitCount++;
                }
            }

            return splitCount;
        }
    }
}
