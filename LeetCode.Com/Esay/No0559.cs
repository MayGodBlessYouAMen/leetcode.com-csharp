using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Minimum Index Sum of Two Lists
    /// </summary>
    public class No0559
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> dic1 = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                dic1[list1[i]] = i;
            }

            List<string> list = new List<string>();
            int len = -1;
            for (int i = 0; i < list2.Length; i++)
            {
                if (dic1.Keys.Contains(list2[i]))
                {
                    if (len == -1 || len == (i + dic1[list2[i]]))
                    {
                        list.Add(list2[i]);
                        len = i + dic1[list2[i]];
                    }
                    else if (len > (i + dic1[list2[i]]))
                    {
                        list.Clear();
                        list.Add(list2[i]);
                        len = i + dic1[list2[i]];
                    }
                }
            }

            return list.ToArray();
        }
    }
}
