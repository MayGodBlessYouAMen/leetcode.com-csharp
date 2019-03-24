using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Reverse Integer
    /// </summary>
    public class No0007
    {
        public int Reverse(int x)
        {
            char[] inputArr = x.ToString().ToCharArray();
            int start = 0;
            if (inputArr[0].Equals('-'))
            {
                start = 1;
            }

            for (int i = start; i <= (inputArr.Count() - 1 + start) / 2; i++)
            {
                char temp = inputArr[i];
                inputArr[i] = inputArr[inputArr.Count() - 1 + start - i];
                inputArr[inputArr.Count() - 1 + start - i] = temp;
            }

            int output = 0;
            try
            {
                output = Int32.Parse(new string(inputArr));
            }
            catch
            {
                output = 0;
            }

            return output;
        }
    }
}
