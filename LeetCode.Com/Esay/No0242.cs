using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [242] Valid Anagram
    /// </summary>
    public class No0242
    {
        public bool IsAnagram(string s, string t)
        {
            //过滤空字符串，以及长度不相等的情况
            //if (string.IsNullOrWhiteSpace(s) || string.IsNullOrWhiteSpace(t)) return false; 
            if (s.Length != t.Length) return false;

            int len = s.Length; 
            int[] arr1 = new int[len];
            int[] arr2 = new int[len]; 

            //转为int数组
            for (int i = 0; i < len; i++)
            {
                arr1[i] = s[i];
                arr2[i] = t[i];
            }

            //排序后比较
            Array.Sort(arr1);
            Array.Sort(arr2);
            for (int i = 0; i < len; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }

            return true;

            //题目有点坑，两个空字符要返回true,那就按要求做吧。
            /*
              × Wrong Answer
              × 33/34 cases passed (N/A)
              × testcase: '""\n""'
              × answer: false
              × expected_answer: true
              × stdout:
             */
        }
    }
}
