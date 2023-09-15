using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Uncommon Words from Two Sentences
    /// </summary>
    internal class No0884
    {

        /*
          解题思路：
              Uncommon的定义：一个单词在其中一个句子中只出现了1次，但是没有在另外一个句子中出现。
              简单理解：统计两个句子中所有的单词，找出所有只出现了1次的单词

              注：所有单词用空格分隔，且只包含小写字母
       */

        public string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            SplitString(s1, ref wordDic);
            SplitString(s2, ref wordDic);

            List<string> uncomminWordList = new List<string>();
            foreach (var key in wordDic.Keys)
            {
                if (wordDic[key] == 1)
                {
                    uncomminWordList.Add(key);
                }
            }

            return uncomminWordList.ToArray();
        }

        /// <summary>
        /// 句子分割，单词放入字典并计数
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="wordDic"></param>
        private void SplitString(string sentence, ref Dictionary<string, int> wordDic)
        {
            var words = sentence.Split(' ');
            foreach (var word in words)
            {
                if (wordDic.ContainsKey(word))
                {
                    wordDic[word] += 1;
                }
                else
                {
                    wordDic.Add(word, 1);
                }
            }
        }
    }
}
