using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Two Sum II - Input array is sorted
    /// </summary>
    public class No0167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    break;
                }
                else if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return new int[] { left + 1, right + 1 };
        }
    }
}
