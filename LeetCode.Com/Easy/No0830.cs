using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Positions of Large Groups
    /// </summary>
    internal class No0830
    {
        /*
            解题思路：
                遍历，找出所有连续字母数量大于等于3的索引范围。

                1 <= s.length <= 1000
                s只包含小写英文字母
         */
        public IList<IList<int>> LargeGroupPositions(string s)
        {
            IList<IList<int>> list = new List<IList<int>>();

            int i = -1;
            int j = -1;

            for (int k = 0; k < s.Length; k++)
            {
                if (k == 0)
                {
                    i = 0;
                    j = 0;

                    continue;
                }

                if (s[k] != s[j])
                {
                    if (j - i + 1 >= 3)
                    {
                        list.Add(new List<int>() { i, j });
                    }

                    i = k;
                    j = k;
                    continue;
                }

                if (s[k] == s[j])
                {
                    j++;
                    continue;
                }
            }

            //末尾边界
            if (j - i + 1 >= 3)
            {
                list.Add(new List<int>() { i, j });
            }

            return list;
        }
    }
}
