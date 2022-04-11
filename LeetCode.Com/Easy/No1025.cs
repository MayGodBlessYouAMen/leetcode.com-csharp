using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Divisor Game
    /// </summary>
    public class No1025
    {
        /*
            解题思路：当n=1的时候，轮到的那个人必输。
                如果n为偶数，先拿的人每次选1，剩下的数为奇数，
                    因为奇数分解因数得到的也是奇数，那么后拿的人必定只能拿到奇数，
                    从而剩下给先拿的人的数又为偶数。不断重复，最后后拿的人只能拿到1，必输。
                如果n为奇数，那先拿的人就面临了上面的后拿的那个人的情况，必输。
         */
        public bool DivisorGame(int n)
        {
            return n % 2 == 0;
        }
    }
}
