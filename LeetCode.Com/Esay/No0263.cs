using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// [263] Ugly Number
    /// </summary>
    public class No0263
    {
        public bool IsUgly(int num)
        {
            if (num < 1) return false;

            //能被2或3或5分解，用除法初到最后剩1即可。
            //注：1被定义为Ugly Number
            while (num % 2 == 0) num = num / 2;
            while (num % 3 == 0) num = num / 3;
            while (num % 5 == 0) num = num / 5;

            return num == 1;
        }
    }
}
