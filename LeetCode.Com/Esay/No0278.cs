using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [278] First Bad Version
    /// </summary>
    public class No0278
    {
        public int first = 823161944;

        public bool IsBadVersion(int n)
        {
            if (n >= first)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int FirstBadVersion(int n)
        {
            #region 以为很简单，结果超时了
            //while (n > 0 && IsBadVersion(n)) n--;
            //return n + 1;
            #endregion

            #region 试试二分法
            if (IsBadVersion(1)) return 1;  //极端情况

            long i = 1;
            long j = n;      //此处ij如果用int类型，会导致后面i+j超出范围，case通不过
            while (i < j)
            {
                if (i + 1 == j) break; //ij相邻时跳出循环
                long a = (i + j) / 2;
                if (IsBadVersion((int)a))
                {
                    j = a;
                }
                else
                {
                    i = a;
                }
            }
            #endregion
            return (int)j;
        }
    }
}
