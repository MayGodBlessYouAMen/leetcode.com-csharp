using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [389]  Find the Difference
    /// </summary>
    public class No0389
    {
        public char FindTheDifference(string s, string t)
        {

            /*
             char diff=' ';
             for(int i=0;i<t.Length;i++)
             {
                 if(i==t.Length-1)
                 {
                     diff=t[i];
                     break;
                 }
                 if(s[i]!=t[i])
                 {
                     diff=t[i];
                     break;
                 }
             }
             return diff;

             //上面的解法错误，因为理解错误题意了,没有注意t是乱序
             */

            //t是s的乱序在随机位置插入一个随机字母，而且所有字母都是小写，
            //可以考虑用s和t的字母ascll码的和相减，得到的差就是插入字母的ascll
            int a = Sum(s);
            int b = Sum(t);

            return (char)(b - a);
        }

        public int Sum(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }
            return sum;
        }
    }
}
