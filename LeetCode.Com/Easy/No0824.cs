using System;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Goat Latin
    /// </summary>
    internal class No0824
    {
        /*
            解题思路：
                1.如果单词是元音开头（aoeiu），尾部加上ma
                2.如果单词辅音开头，把第一个字母放到该单词尾部，然后在尾部加上ma
                3.1和2操作之后，每个单词末尾加上单词在句子中的index个数的a。index从1开始。
            注：句子单词数量1-150，句子只包含英文大小写和空格，单词用一个空格分开，单词头尾没有空格。
         */
        public string ToGoatLatin(string sentence)
        {
            var words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (!startWithVowel(word))
                {
                    word = word.Substring(1) + word[0];
                }

                word = word + "ma" + CreateLowerA(i + 1);

                words[i] = word;
            }

            return String.Join(" ", words);
        }

        /// <summary>
        /// 判断单词是否元音开头
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private bool startWithVowel(string word)
        {
            char temp = word.ToLower()[0];
            if (temp == 'a' ||
                temp == 'o' ||
                temp == 'e' ||
                temp == 'i' ||
                temp == 'u')
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 生成指定数量的a组成字符串
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private string CreateLowerA(int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                sb.Append('a');
            }
            return sb.ToString();
        }

    }
}
