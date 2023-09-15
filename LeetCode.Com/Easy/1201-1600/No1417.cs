using System;
using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Reformat The String
    /// </summary>
    public class No1417
    {
        public string Reformat(string s)
        {
            Queue<Char> letterqueue = new Queue<Char>();
            Queue<Char> digitqueue = new Queue<Char>();

            //字母和数字分开放入队列
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    letterqueue.Enqueue(s[i]);
                }
                else if (char.IsNumber(s[i]))
                {
                    digitqueue.Enqueue(s[i]);
                }
            }

            //如果队列长度差超过1，无法满足格式化要求。
            if (Math.Abs(letterqueue.Count - digitqueue.Count) > 1)
            {
                return "";
            }

            //满足要求情况下，第一个字符要用长的串
            var longer = letterqueue.Count >= digitqueue.Count ? letterqueue : digitqueue;
            var shorter = letterqueue.Count >= digitqueue.Count ? digitqueue : letterqueue;

            List<char> res = new List<char>();
            while (longer.Count > 0)
            {
                res.Add(longer.Dequeue());

                if (shorter.Count > 0)
                {
                    res.Add(shorter.Dequeue());
                }
            }

            return new string(res.ToArray());
        }
    }
}
