using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Contains Duplicate II
    /// </summary>
    public class No0219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums == null || nums.Length <= 1)
            {
                return false;
            }

            if (k <= 0)
            {
                return false;
            }

            #region Dictionary 超时
            ////定义一个的字典，逻辑上保持最大长度为k
            //Dictionary<int, int> dic = new Dictionary<int, int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    /*
            //     0-k
            //     1-k+1
            //     2-k+2
            //     ...
            //     */
            //    //移除头部范围外的值
            //    if (i > k )
            //    {
            //        dic.Remove(i - k - 1);
            //    }

            //    //用当前i位置的元素，去字典里找相同元素
            //    if (dic.Values.Contains(nums[i]))
            //    {
            //        return true;
            //    }

            //    dic.Add(i, nums[i]);
            //}
            #endregion

            #region List 超时
            ////定义一个列表，逻辑上保持最大长度为k
            //List<int> subList = new List<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    /*
            //     0-k
            //     1-k+1
            //     2-k+2
            //     ...
            //     */
            //    //移除头部范围外的值
            //    if (i > k)
            //    {
            //        subList.RemoveAt(i - k - 1);
            //    }

            //    //用当前i位置的元素，去字典里找相同元素
            //    if (subList.Contains(nums[i]))
            //    {
            //        return true;
            //    }

            //    subList.Add(nums[i]);
            //}
            #endregion

            #region HashSet AC
            //定义一个hashset，逻辑上保持最大长度为k
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                /*
                 0-k
                 1-k+1
                 2-k+2
                 ...
                 */
                //移除头部范围外的值
                if (i > k)
                {
                    hashSet.Remove(nums[i - k - 1]);
                }

                //用当前i位置的元素，去字典里找相同元素
                if (hashSet.Contains(nums[i]))
                {
                    return true;
                }

                hashSet.Add(nums[i]);
            }
            #endregion

            return false;
        }
    }
}
