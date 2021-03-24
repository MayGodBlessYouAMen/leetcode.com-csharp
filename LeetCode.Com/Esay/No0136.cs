using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Single Number
    /// </summary>
    public class No0136
    {
        public int SingleNumber(int[] nums)
        {

            //思路:异或运算。
            // a^a=>0
            // 0^a=>a

            int single = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                single = single ^ nums[i];
            }

            return single;
        }
    }
}
