using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Unique Number of Occurrences
    /// </summary>
    public class No1207
    {
        /*
         *  题意：统计数组中所有数字出现的次数，如果所有次数没有重复，则返回true，否则false
            解题思路：先用字典保存所有数字出现的次数，再用字典统计所有次数是否有重复

            1 <= arr.length <= 1000
            -1000 <= arr[i] <= 1000
         */
        public bool UniqueOccurrences(int[] arr)
        {
            //计算每个数字出现次数
            Dictionary<int, int> numDic = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (numDic.ContainsKey(item))
                {
                    numDic[item]++;
                }
                else
                {
                    numDic.Add(item, 1);
                }
            }

            //统计次数的频率
            Dictionary<int,int> countDic = new Dictionary<int,int>();
            foreach (var item in numDic.Values)
            {
                if (countDic.ContainsKey(item))
                {
                    countDic[item]++;
                }
                else
                {
                    countDic.Add(item, 1);
                }
            }

            //频率大于1说明有重复
            bool unique = true;
            foreach (var item in countDic.Values)
            {
                if (item > 1)
                {
                    unique = false; 
                    break;
                }
            }

            return unique;
        }
    }
}
