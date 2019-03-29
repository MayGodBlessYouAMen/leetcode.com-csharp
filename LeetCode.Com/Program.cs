using LeetCode.Com.Com;
using LeetCode.Com.Esay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com
{
    class Program
    {
        /// <summary>
        /// 测试类
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world");

            #region No0001
            //No0001 no0001 = new No0001();
            //int[] a = {2, 7, 11, 15};
            //int[] b = no0001.TwoSum(a, 9);
            #endregion

            #region No0007
            //No0007 no0007 = new No0007();
            //Console.WriteLine(no0007.Reverse(123));
            //Console.WriteLine(no0007.Reverse(-123));
            //Console.WriteLine(no0007.Reverse(120));
            #endregion

            #region No0009
            //No0009 no0009 = new No0009();
            //Console.WriteLine(no0009.IsPalindrome(121));
            //Console.WriteLine(no0009.IsPalindrome(-121));
            //Console.WriteLine(no0009.IsPalindrome(10));
            #endregion

            #region No0013
            //No0013 no0013 = new No0013();
            //Console.WriteLine(no0013.RomanToInt("III"));
            //Console.WriteLine(no0013.RomanToInt("IV"));
            //Console.WriteLine(no0013.RomanToInt("IX"));
            //Console.WriteLine(no0013.RomanToInt("LVIII"));
            //Console.WriteLine(no0013.RomanToInt("MCMXCIV"));
            #endregion

            #region No0014
            //No0014 no0014 = new No0014();
            //Console.WriteLine(no0014.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
            //Console.WriteLine(no0014.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
            #endregion

            #region No0020
            //No0020 no0020 = new No0020();
            //Console.WriteLine(no0020.IsValid("()"));
            //Console.WriteLine(no0020.IsValid("()[]{}"));
            //Console.WriteLine(no0020.IsValid("(]"));
            //Console.WriteLine(no0020.IsValid("([)]"));
            //Console.WriteLine(no0020.IsValid("{[]}"));
            #endregion

            #region No0021
            No0021 no0021 = new No0021();
            ListNode l1 = new ListNode(1);
            l1.AddNode(2);
            l1.AddNode(4);
            ListNode l2 = new ListNode(1);
            l2.AddNode(3);
            l2.AddNode(4);
            ListNode l3 = no0021.MergeTwoLists(l1, l2);
            #endregion

            Console.ReadKey();
        }
    }
}
