using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [997]  Find the Town Judge
    /// </summary>
    public class No0997
    {
        public int FindJudge(int N, int[][] trust)
        {
            /*统计信任别人的列表，以及人们被信任的次数。不信任任何人，且被信任N-1次的是法官。边界条件:总共只有一人时，这人就是法官 */
            if (N == 1) return 1;

            List<int> trustList = new List<int>();
            int[] countArr = new int[N + 1];

            for (int i = 0; i < trust.Length; i++)
            {
                trustList.Add(trust[i][0]);  //信任别人的人

                countArr[trust[i][1]]++;     //被信任计数
            }

            for (int i = 1; i <= N; i++)
            {
                if (countArr[i] == N - 1 && !trustList.Contains(i))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
