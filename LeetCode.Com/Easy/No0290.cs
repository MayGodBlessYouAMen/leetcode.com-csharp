using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Word Pattern
    /// </summary>
    public class No0290
    {
        public bool WordPattern(string pattern, string str)
        {
            Dictionary<char, string> dic = new Dictionary<char, string>();
            string[] strarr = str.Split(' ');
            if (pattern.Length != strarr.Length)
            {
                return false;
            }
            for (int i = 0; i < pattern.Length; i++)
            {
                char key = pattern[i];
                if (!dic.ContainsKey(key))
                {
                    //如果不同的key对应相同的值，说明不匹配
                    if (dic.Values.Contains(strarr[i]))
                    {
                        return false;
                    }
                    dic.Add(key, strarr[i]);
                }
                else
                {
                    //如果相同的key对应不同的值，说明不匹配
                    if (dic[key] != strarr[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
