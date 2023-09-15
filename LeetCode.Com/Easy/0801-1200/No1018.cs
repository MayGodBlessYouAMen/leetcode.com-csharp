using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Binary Prefix Divisible By 5
    /// </summary>
    internal class No1018
    {
        /*
            解题思路：计算每个数字，除以5。
                每个数字计算方法：xi是0-i位二进制数，转换成10进制。 
                每次加入i，相当于之前的数字左移1位，即乘以2，然后加上新加入的数字。
                注意：xi的第i位是最低位

                1 <= nums.length <= 10^5
                nums[i] is either 0 or 1.
         */
        public IList<bool> PrefixesDivBy5(int[] nums)
        {
            //定义返回值
            IList<bool> resList = new List<bool>();

            int num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                num = num * 2 + nums[i];

                //防止sum超过int最大值
                num = num % 5;

                if (num == 0)
                {
                    resList.Add(true);
                }
                else
                {
                    resList.Add(false);
                }
            }

            return resList;
        }
    }
}
