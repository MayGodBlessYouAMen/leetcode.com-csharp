using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Plus One
    /// </summary>
    public class No0066
    {
        public int[] PlusOne(int[] digits)
        {
            //数组表示整数的各位。结果返回这个整数+1对应的数组
            if (digits == null || digits.Length == 0)
            {
                return digits;
            }

            //末位 0-8
            if (digits[digits.Length - 1] < 9)
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }

            //末位9
            digits[digits.Length - 1] = 0;  //个位直接计算
            int enterone = 1; //进位
            for (int i = 1; i < digits.Length; i++)
            {
                if (enterone == 0) break;
                int temp = digits[digits.Length - 1 - i] + enterone;
                if (temp == 10)
                {
                    //进位
                    digits[digits.Length - 1 - i] = 0;
                    enterone = 1;
                }
                else
                {
                    digits[digits.Length - 1 - i] = temp;
                    enterone = 0;
                }
            }

            if (enterone == 0) return digits;

            //多出一位，要新建数组
            int[] newdigits = new int[digits.Length + 1];
            newdigits[0] = 1;
            for (int i = 1; i < newdigits.Length; i++)
            {
                newdigits[i] = digits[i - 1];
            }
            return newdigits;
        }
    }
}
