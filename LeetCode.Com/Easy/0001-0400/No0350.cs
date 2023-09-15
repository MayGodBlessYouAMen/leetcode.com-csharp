using System;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [350] Intersection of Two Arrays II
    /// </summary>
    public class No0350
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            //先排序，再逐位比较
            Array.Sort(nums1);
            Array.Sort(nums2);

            List<int> intersectionList = new List<int>();
            int i = 0;
            int j = 0;
            while (i <= nums1.Length - 1 && j <= nums2.Length - 1)
            {
                if (nums1[i] == nums2[j])
                {
                    //此题与No.0349的区别是，返回列表里允许出现值相同元素
                    intersectionList.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return intersectionList.ToArray();
        }
    }
}
