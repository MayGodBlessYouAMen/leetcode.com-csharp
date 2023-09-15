using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Number of Equivalent Domino Pairs
    /// </summary>
    public class No1128
    {
        /*
            解题思路：将每个数组按从小到大排序后作为key放入字典，并计数。
            最后遍历字典找出计数大于1的，排列组合相加即可。

            1 <= dominoes.length <= 4 * 104
            dominoes[i].length == 2
            1 <= dominoes[i][j] <= 9
         */
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < dominoes.Length; i++)
            {
                var pair = dominoes[i];
                if (pair[0] > pair[1])
                {
                    int temp = pair[0];
                    pair[0] = pair[1];
                    pair[1] = temp;
                }

                int key = pair[0] * 10 + pair[1];
                if (dic.ContainsKey(key))
                {
                    dic[key]++;
                }
                else
                {
                    dic.Add(key, 1);
                }
            }

            int sum = 0;
            foreach (int count in dic.Values)
            {
                if (count > 1)
                {
                    sum += count * (count - 1) / 2;   //Cn^2
                }
            }

            return sum;
        }
    }
}
