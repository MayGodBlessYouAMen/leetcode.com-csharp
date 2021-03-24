using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Pascal's Triangle II  
    /// </summary>
    public class No0119
    {
        public IList<int> GetRow(int rowIndex)
        {
            /*杨辉三角 第n行*/
            IList<int> listi = new List<int>();

            for (int i = 0; i <= rowIndex; i++)  //注意此题rowIndex是从0开始的
            {
                listi.Add(1);  //末尾添加1

                for (int j = i; j >= 0; j--)   //倒序，a(n) = a(n) + a(n-1)
                {
                    //去头去尾
                    if (j == i || j == 0)
                    {
                        continue;
                    }

                    //中间
                    listi[j] = listi[j] + listi[j - 1];
                }
            }

            return listi;
        }
    }
}
