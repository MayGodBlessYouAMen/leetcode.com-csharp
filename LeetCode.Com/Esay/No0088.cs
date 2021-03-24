
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Merge Sorted Array
    /// </summary>
    public class No0088
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] nums3 = new int[m + n];
            int j = 0; //标记nums1用
            int k = 0; //标记nums2用
            for (int i = 0; i < m + n; i++)
            {
                if (j < m && k < n)
                {
                    if (nums1[j] <= nums2[k])
                    {
                        nums3[i] = nums1[j];
                        j++;
                    }
                    else
                    {
                        nums3[i] = nums2[k];
                        k++;
                    }
                    continue;
                }

                if (j < m)
                {
                    nums3[i] = nums1[j];
                    j++;
                    continue;
                }

                if (k < n)
                {
                    nums3[i] = nums2[k];
                    k++;
                    continue;
                }
            }

            for (int i = 0; i < m + n; i++)
            {
                nums1[i] = nums3[i];
            }
        }
    }
}
