using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [1021]  Remove Outermost Parentheses
    /// </summary>
    public class No1021
    {
        public string RemoveOuterParentheses(string S)
        {
            if (string.IsNullOrWhiteSpace(S)) return "";

            S = S.Remove(S.Length - 1, 1);  //移除左右边的‘)’
            int right = 0;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '(' && right == 0)
                {
                    S = S.Remove(i, 1);  //移除匹配的‘(’
                    i--;
                    if (i >= 0) S = S.Remove(i, 1);//移除下一对的的‘)’
                    continue;
                }
                if (S[i] == ')') right++;
                if (S[i] == '(') right--;
            }

            return S;
        }
    }
}
