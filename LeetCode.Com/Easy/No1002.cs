using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [1002]  Find Common Characters
    /// </summary>
    public class No1002
    {
        public IList<string> CommonChars(string[] A)
        {
            IList<string> list = new List<string>();
            for (int i = 'a'; i <= 'z'; i++)
            {
                string temp = ((char)i).ToString();
                int count = A[0].Count(x => x == i);
                for (int j = 0; j < A.Length; j++)
                {
                    //判断是否存在
                    if (!A[j].Contains(temp))
                    {
                        count = 0;
                        break;
                    }

                    //计算个数
                    int countj = A[j].Count(x => x == i);
                    if (countj < count)
                    {
                        count = countj;
                    }
                }
                while (count > 0)
                {
                    list.Add(temp);
                    count--;
                }
            }
            return list;
        }
    }
}
