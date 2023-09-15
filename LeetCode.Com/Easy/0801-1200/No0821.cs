using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Shortest Distance to a Character
    /// </summary>
    internal class No0821
    {
        /*
            解题思路：
                遍历字符串s，记录所有等于c的字符的位置
                再遍历字符串s，根据记录的位置数组计算所有点的距离。

                题目保证s和c都只包含小写字母，c至少在s中出现一次。
         */
        public int[] ShortestToChar(string s, char c)
        {

            //保存所有c的位置
            List<int> searchedIndexList = new List<int>();

            //记录所有等于c的字符的位置
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    searchedIndexList.Add(i);
                }
            }

            //用于保存所有字符的距离
            int[] indexArray = new int[s.Length];

            //计算距离
            for (int i = 0; i < s.Length; i++)
            {
                //左侧
                if (i <= searchedIndexList[0])
                {
                    indexArray[i] = searchedIndexList[0] - i;
                    continue;
                }

                //右侧
                if (i > searchedIndexList[searchedIndexList.Count - 1])
                {
                    indexArray[i] = i - searchedIndexList[searchedIndexList.Count - 1];
                    continue;
                }

                //中间(程序能进到这里，searchedIndexList里必然至少有两个元素，所以不用担心越界)
                if (i > searchedIndexList[0] && i < searchedIndexList[1])
                {
                    indexArray[i] = i - searchedIndexList[0] > searchedIndexList[1] - i ? searchedIndexList[1] - i : i - searchedIndexList[0];
                    continue;
                }

                //searchedIndexList里必然至少有两个元素走到第二个元素，移除第一个元素
                if (i == searchedIndexList[1])
                {
                    searchedIndexList.RemoveAt(0);
                }
            }

            return indexArray;
        }
    }
}
