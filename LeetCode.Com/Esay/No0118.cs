using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Pascal's Triangle    
    /// </summary>
    public class No0118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            /*杨辉三角*/
            IList<IList<int>> list = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                IList<int> listi = new List<int>();
                int a = 0;
                for (int j = 0; j < i + 1; j++)
                {
                    //去头去尾
                    if (j == 0 || j == i + 1 - 1)
                    {
                        a = 1;
                        listi.Add(a);
                        continue;
                    }

                    //中间
                    a = list[i - 1][j - 1] + list[i - 1][j];
                    listi.Add(a);
                }
                list.Add(listi);
            }

            return list;
        }
    }
}
