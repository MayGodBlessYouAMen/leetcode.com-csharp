using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Remove All Adjacent Duplicates In String
    /// </summary>
    public class No1047
    {
        /*
            解题思路：遍历字符串，移除相邻两个相等的字母。
                      重复遍历，直到没有为止。
                       
                      效率解法：将字符遍历压入栈，每个字符压入前和栈顶比较，如果相等则不压入，并且移除栈顶
                       
                1 <= s.length <= 105
                s consists of lowercase English letters.
         */
        public string RemoveDuplicates(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                //空栈直接压入
                if (stack.Count == 0)
                {
                    stack.Push(s[i]);
                    continue;
                }

                //获取栈顶
                char top = stack.Peek();
                if (s[i] == top)
                {
                    //弹出栈顶
                    stack.Pop();
                    continue;
                }

                //压栈
                stack.Push(s[i]);
            }

            return new string(stack.ToArray());
        }
    }
}
