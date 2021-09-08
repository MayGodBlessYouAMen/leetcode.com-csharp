using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Summary Ranges
    /// </summary>
    public class No0228
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> list = new List<string>();

            if (nums == null || nums.Length <= 0)
            {
                return list;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                string start = nums[i].ToString();
                string end = "";
                while ((i + 1 < nums.Length) && 
                       (nums[i] + 1 == nums[i + 1]))
                {
                    i++;
                    end = nums[i].ToString();
                }

                if (end == "")
                {
                    list.Add(start);
                }
                else
                {
                    list.Add($"{start}->{end}");
                }

            }

            return list;
        }
    }
}
