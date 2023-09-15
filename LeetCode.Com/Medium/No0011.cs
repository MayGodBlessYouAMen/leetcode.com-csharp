using System;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// Container With Most Water
    /// </summary>
    public class No0011
    {
        public int MaxArea(int[] height)
        {
            // Max((j-i) * Min(ai,aj));
            int left = 0;
            int right = height.Length - 1;
            int area = 0;
            while (left < right)
            {
                int h = Math.Min(height[left], height[right]);
                int len = right - left;
                area = Math.Max(area, h * len);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return area;
        }
    }
}
