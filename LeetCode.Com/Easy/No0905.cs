using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [905]  Sort Array By Parity
    /// </summary>
    public class No0905
    {
        public int[] SortArrayByParity(int[] A)
        {
            //偶数插入头部，奇数插入尾部
            List<int> temp = new List<int>();
            foreach (int a in A)
            {
                if (a % 2 == 0)
                {
                    temp.Insert(0, a);
                    continue;
                }
                temp.Add(a);
            }
            return temp.ToArray();
        }
    }
}
