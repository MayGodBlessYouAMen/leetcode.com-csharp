using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Rotate String
    /// </summary>
    public class No0796
    {
        public bool RotateString(string A, string B)
        {
            //如果新的字符串(A+A)中包含B的话，说明A一定能通过偏移得到B
            return A.Length == B.Length && (A + A).Contains(B);
        }
    }
}
