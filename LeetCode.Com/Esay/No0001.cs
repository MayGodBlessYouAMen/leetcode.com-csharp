using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Two Sum
    /// </summary>
    public class No0001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //sort
            int[] nums1 = Sort(nums);
            //find
            int start = 0;
            int end = nums.Length - 1;
            while (start < end)
            {
                if (nums1[start] + nums1[end] == target)
                {
                    break;
                }
                else if (nums1[start] + nums1[end] < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return new int[] { GetStartIndex(nums, nums1[start]), GetEndIndex(nums, nums1[end]) };
        }

        public int[] Sort(int[] nums)
        {
            int[] numsCopy = new int[nums.Length];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                numsCopy[i] = nums[i];
            }
            for (int i = 0; i < numsCopy.Length - 1; i++)
            {
                for (int j = 0; j < numsCopy.Length - 1 - i; j++)
                {
                    if (numsCopy[j] > numsCopy[j + 1])
                    {
                        int temp = numsCopy[j];
                        numsCopy[j] = numsCopy[j + 1];
                        numsCopy[j + 1] = temp;
                    }
                }
            }
            return numsCopy;
        }

        public int GetStartIndex(int[] nums, int num)
        {
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int GetEndIndex(int[] nums, int num)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
