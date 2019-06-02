using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Nim Game
    /// </summary>
    public class No0292
    {
        public bool CanWinNim(int n)
        {
            //n=4的时候，先拿的人必输;推理可知n为4的倍数时也是必输;
            //n!=4时，保证自己每次拿了之后剩余的为4的倍数即可胜利
            if (n % 4 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
