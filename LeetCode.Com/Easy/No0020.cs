using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Valid Parentheses
    /// </summary>
    public class No0020
    {
        /*
        {} [] () ()()() {}{}{} [][][] {{{[[]][]}}}
        试试递归
         */

        public bool IsValid(string s)
        {
            string ret = check(s);
            if (ret == "")
            {
                return true;
            }

            return false;
        }

        public string check(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            int count = s.Length;  //原长度

            List<char> charList = s.ToList();
            //倒序遍历，匹配移除
            for (int i = charList.Count - 1; i - 1 >= 0; i--)
            {
                if (charList[i] == '}' && charList[i - 1] == '{')
                {
                    charList.RemoveAt(i);
                    charList.RemoveAt(i - 1);
                    i--;
                    continue;
                }

                if (charList[i] == ']' && charList[i - 1] == '[')
                {
                    charList.RemoveAt(i);
                    charList.RemoveAt(i - 1);
                    i--;
                    continue;
                }

                if (charList[i] == ')' && charList[i - 1] == '(')
                {
                    charList.RemoveAt(i);
                    charList.RemoveAt(i - 1);
                    i--;
                    continue;
                }
            }

            string s2 = new string(charList.ToArray());

            if (count == s2.Length)
            {
                //无匹配判断
                return s2;
            }

            return check(s2);
        }
    }
}
