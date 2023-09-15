using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Merge Strings Alternately
    /// </summary>
    public class No1768
    {
        /*
            解题思路：从word1开始，交替取两个字符串中的字符。
         */
        public string MergeAlternately(string word1, string word2)
        {
            int index1 = 0;
            int index2 = 0;
            StringBuilder sb = new StringBuilder();

            bool isFirst = true;
            while (index1 < word1.Length || index2 < word2.Length)
            {
                if (isFirst)
                {
                    sb.Append(word1[index1]);
                    index1++;
                }
                else
                {
                    sb.Append(word2[index2]);
                    index2++;
                }

                if (isFirst && index2 < word2.Length)
                {
                    isFirst = false;
                    continue;
                }

                if (!isFirst && index1 < word1.Length)
                {
                    isFirst = true;
                    continue;
                }
            }

            return sb.ToString();
        }
    }
}
