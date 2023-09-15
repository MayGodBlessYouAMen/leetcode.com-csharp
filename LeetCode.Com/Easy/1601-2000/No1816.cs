using System;
using System.Linq;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Truncate Sentence
    /// </summary>
    public class No1816
    {
        /*
            解题思路：分隔，截取，拼接

            1 <= s.length <= 500
            k is in the range [1, the number of words in s].
            s consist of only lowercase and uppercase English letters and spaces.
            The words in s are separated by a single space.
            There are no leading or trailing spaces.
         */
        public string TruncateSentence(string s, int k)
        {
            var arr = s.Split(' ').Take(k);
            return String.Join(" ", arr);
        }
    }
}
