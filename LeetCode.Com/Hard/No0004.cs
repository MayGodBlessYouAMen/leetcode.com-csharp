using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Hard
{
    /// <summary>
    /// 4. Median of Two Sorted Arrays
    /// </summary>
    public class No0004
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            double middle = 0;
            int length1 = nums1.Length;
            int length2 = nums2.Length;
            int midIndex = (length1 + length2) / 2;

            //null check
            if (length1 == 0 && length2 == 0)
            {
                return middle;
            }
            else if (length1 == 0)
            {
                middle = GetMidNumFromArray(nums2);
                return middle;
            }
            else if (length2 == 0)
            {
                middle = GetMidNumFromArray(nums1);
                return middle;
            }

            int[] arr = new int[length1 + length2];
            arr[0] = 0;
            int i = 0;
            int j = 0;
            while (i + j <= midIndex)
            {
                int k = i + j;
                if (i <= length1 - 1 && j <= length2 - 1)
                {
                    if (nums1[i] <= nums2[j])
                    {
                        arr[k] = nums1[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = nums2[j];
                        j++;
                    }
                }
                else
                {
                    if (i <= length1 - 1)
                    {
                        arr[k] = nums1[i];
                        i++;
                    }
                    else if (j <= length2 - 1)
                    {
                        arr[k] = nums2[j];
                        j++;
                    }
                }
            }
            middle = GetMidNumFromArray(arr);

            return middle;
        }

        private double GetMidNumFromArray(int[] arr)
        {
            double middle = 0;
            int length = arr.Length;
            int midIndex = length / 2;
            if (length % 2 == 0)
            {
                middle = (arr[midIndex - 1] + arr[midIndex]) / 2.0;
            }
            else
            {
                middle = arr[midIndex] * 1.0;
            }
            middle = Math.Round(middle, 1);
            return middle;
        }
    }
}