using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Maximum Number of Words Found in Sentences
    /// </summary>
    public class No2114
    {
        /*
            解题思路：水题，略
         */
        public int MostWordsFound(string[] sentences)
        {
            int max = 0;
            foreach (var sentence in sentences)
            {
                int len = sentence.Split(' ').Length;
                if (len > max)
                {
                    max = len;
                }
            }
            return max;
        }
    }
}
