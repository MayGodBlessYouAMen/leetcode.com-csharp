using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// 49. Group Anagrams
    /// </summary>
    public class No0049
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            //字符串排序后作为字典的key
            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                string key = strs[i];
                char[] keyarr = key.ToArray();
                Array.Sort(keyarr);
                string sortedkey = new string(keyarr);
                if (dic.Keys.Contains(sortedkey))
                {
                    dic[sortedkey].Add(key);
                }
                else
                {
                    dic.Add(sortedkey, new List<string>() { key });
                }
            }

            //字典转list
            IList<IList<string>> list = new List<IList<string>>();
            foreach (var value in dic.Values)
            {
                list.Add(value);
            }

            return list;
        }
    }
}
