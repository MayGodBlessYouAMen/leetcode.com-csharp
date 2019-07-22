using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Intersection of Two Arrays
    /// </summary>
    public class No0349
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
                    if (!intersectionList.Contains(nums1[i]))
                    {
                        intersectionList.Add(nums1[i]);
                    }
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
