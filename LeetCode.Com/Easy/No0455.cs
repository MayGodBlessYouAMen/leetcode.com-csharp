using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [455]  Assign Cookies
    /// </summary>
    public class No0455
    {
        public int FindContentChildren(int[] g, int[] s)
        {

            /*
            //从小到大排序 => 10000条数据时，冒泡超时了(862ms+)
            Sort(g);
            Sort(s);
            */

            //试试.net自带的sort => 10000条数据时 146ms
            Array.Sort(g);
            Array.Sort(s);

            //排序完毕，让心最大的猴子拿最大的饼干(手动斜眼)
            int i = g.Length - 1;
            int j = s.Length - 1;
            int count = 0;
            while (i >= 0 && j >= 0)
            {
                if (g[i] <= s[j])
                {
                    //愿望实现
                    i--;
                    j--;
                    count++;
                }
                else
                {
                    //匹配不到，换下个孩
                    i--;
                }
            }

            return count;
        }

        /*
        //普通冒泡，正序
        private void Sort(int[] nums)
        {
            for(int i=0;i<nums.Length-1;i++)
            {
                for(int j=0;j<nums.Length-1-i;j++)
                {
                    if(nums[j]>nums[j+1])
                    {
                        int temp=nums[j];
                        nums[j]=nums[j+1];
                        nums[j+1]=temp;
                    }
                }
            }
        }
        */
    }
}
