using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [917]  Reverse Only Letters
    /// </summary>
    public class No0917
    {
        public string ReverseOnlyLetters(string S)
        {
            //翻转所有字母位置。非字母位置保留不变。

            char[] charArray = S.ToCharArray();
            int i = 0;
            int j = S.Length - 1;
            while (i <= S.Length - 1 && j >= 0)
            {
                if (!IsLetter(S[i]))
                {
                    i++;
                    continue;

                }

                if (j < 0) break;
                while (!IsLetter(S[j]))
                {
                    j--;
                }

                charArray[j] = S[i];
                i++;
                j--;
            }

            return new string(charArray);
        }

        private bool IsLetter(char c)
        {
            if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
            {
                return true;
            }

            return false;
        }
    }
}
