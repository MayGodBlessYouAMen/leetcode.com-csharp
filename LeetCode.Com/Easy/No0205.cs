using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [205] Isomorphic Strings
    /// </summary>
    public class No0205
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (string.IsNullOrWhiteSpace(s) && string.IsNullOrWhiteSpace(t)) return true;  //""\n""
            if (string.IsNullOrWhiteSpace(s) || string.IsNullOrWhiteSpace(t)) return false;
            if (s.Length != t.Length) return false;

            Dictionary<char, char> dicKV = new Dictionary<char, char>();
            for (int i = 0; i < t.Length; i++)
            {
                //注意这句话:No two characters may map to the same character 
                if (!dicKV.Keys.Contains(s[i]))
                {
                    if (dicKV.Values.Contains(t[i])) return false;
                    dicKV.Add(s[i], t[i]);
                }
                else
                {
                    if (dicKV[s[i]] != t[i]) return false;
                }

            }
            return true;
        }

    }
}

