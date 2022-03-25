using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Sort Array By Parity II
    /// </summary>
    internal class No0922
    {
        /*
            odd:奇数 even：偶数

            解题思路：奇偶数各占一半。遍历一遍即可
         */
        public int[] SortArrayByParityII(int[] nums)
        {

            //定义新数组
            int[] newNums = new int[nums.Length];

            //辅助栈
            Stack<int> oddStack = new Stack<int>();
            Stack<int> evenStack = new Stack<int>();

            //遍历
            int index = 0;
            foreach (var num in nums)
            {
                if (IsEven(index))
                {
                    if (IsEven(num))
                    {
                        newNums[index] = num;
                        index++;
                    }
                    else
                    {
                        //入栈
                        oddStack.Push(num);
                    }
                    continue;
                }

                if (IsOdd(index))
                {
                    if (IsOdd(num))
                    {
                        newNums[index] = num;
                        index++;
                    }
                    else
                    {
                        //入栈
                        evenStack.Push(num);
                    }
                    continue;
                }
            }

            //oddStack和evenStack数量必定相同
            for (int i = index; i < nums.Length; i++)
            {
                if (IsEven(index))
                {
                    newNums[index] = evenStack.Pop();
                }
                else
                {
                    newNums[index] = oddStack.Pop();
                }
                index++;
            }

            return newNums;
        }

        private bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        private bool IsEven(int num)
        {
            return num % 2 == 0;
        }

    }
}
