using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [448]  Find All Numbers Disappeared in an Array
    /// </summary>
    public class No0448
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> disappearedNum = new List<int>();

            //遍历，不包含的就是,但是超时了
            /*
            for(int i=1;i<=nums.Length;i++)
            {
                if(!nums.Contains(i))
                {
                    disappearedNum.Add(i);
                }
            }
            */

            //正负标记法，使用变量i从1到n遍历数组a，假设a[i]值是m，则标记a[m]为负数。
            //遍历完成之后，剩下的正数位置的index就是所缺的数
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                int m = Math.Abs(nums[i]);  //由于计算后可能为负数，此处为了取index用，加上绝对值
                nums[m - 1] = -1 * Math.Abs(nums[m - 1]);  //值变为负数,标记用
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    disappearedNum.Add(i + 1);
                }
            }

            return disappearedNum;
        }
    }
}
