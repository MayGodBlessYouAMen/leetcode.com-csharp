using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [268] Missing Number
    /// </summary>
    public class No0268
    {
        public int MissingNumber(int[] nums)
        {
            //定义一个相同长度+1的数组
            int[] temp = new int[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                //将新数组对应index标为1
                temp[nums[i]] = 1;
            }

            //新数组为0的元素index即是missing number
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == 0) return i;
            }

            return 0; //防止编译报错
        }
    }
}
