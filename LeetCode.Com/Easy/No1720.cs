using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Decode XORed Array
    /// </summary>
    public class No1720
    {
        /*
            解题思路：decode数组第一个元素就是fitst。后面的元素用encoded中的元素两两求xor
         */
        public int[] Decode(int[] encoded, int first)
        {
            int[] decoded = new int[encoded.Length + 1];

            decoded[0] = first;

            for (int i = 1; i < decoded.Length; i++)
            {
                decoded[i] = decoded[i - 1] ^ encoded[i - 1];
            }

            return decoded;
        }
    }
}
