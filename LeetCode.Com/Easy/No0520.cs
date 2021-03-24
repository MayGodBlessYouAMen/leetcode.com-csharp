using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [520]  Detect Capital
    /// </summary>
    public class No0520
    {
        public bool DetectCapitalUse(string word)
        {
            if (word.Length <= 1) return true;
            if (IsUpper(word) || Islower(word)) return true;
            if (IsOnlyHeaderUpper(word)) return true;

            return false;
        }

        private bool IsUpper(string word)
        {
            return word == word.ToUpper();
        }

        private bool Islower(string word)
        {
            return word == word.ToLower();
        }

        private bool IsOnlyHeaderUpper(string word)
        {
            if (word[0].ToString() == word[0].ToString().ToUpper() &&
                word.Substring(1) == word.Substring(1).ToLower()) return true;
            return false;
        }
    }
}
