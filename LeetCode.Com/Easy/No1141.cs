using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Build an Array With Stack Operations
    /// </summary>
    public class No1141
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            IList<string> arr = new List<string>();
            int len = target[target.Length - 1];
            for (int i = 1; i <= len; i++)
            {
                if (target.Contains(i))
                {
                    arr.Add("Push");
                }
                else
                {
                    arr.Add("Push");
                    arr.Add("Pop");
                }
            }

            return arr;
        }
    }
}
