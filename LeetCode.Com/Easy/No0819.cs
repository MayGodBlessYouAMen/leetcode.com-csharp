using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Most Common Word
    /// </summary>
    internal class No0819
    {
        /*
            解题思路：将给定字符串分割成一个个单词，统计单词频率，剔除被禁的单词。
            
            给定的字符串至少包含一个单词。字符串单词忽略大小写。
            banned中单词只包含a-z
            题目保证有唯一解。
            最后输出结果用小写。
         */
        public string MostCommonWord(string paragraph, string[] banned)
        {
            //缓存字符
            List<char> charList = new List<char>();

            //单词字典
            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            //遍历保存单词
            for (int i = 0; i < paragraph.Length; i++)
            {
                char temp = paragraph[i];
                if (IsEnglishAlphabet(temp))
                {
                    charList.Add(temp);

                    //遍历到末尾时，要参加后面的计算，不能退出
                    if (i != paragraph.Length - 1)
                    {
                        continue;
                    }
                }

                if (charList.Count > 0)
                {
                    string word = new string(charList.ToArray()).ToLower();

                    //排除禁用单词列表
                    if (banned.Contains(word))
                    {
                        //清空缓存
                        charList.Clear();

                        continue;
                    }

                    if (!wordDic.ContainsKey(word))
                    {
                        //加入字典
                        wordDic.Add(word, 1);
                    }
                    else
                    {
                        //计数+1
                        wordDic[word] += 1;
                    }

                    //清空缓存
                    charList.Clear();
                }
            }

            //遍历单词字典
            string mostCommondWord = "";
            int count = 0;
            foreach (var item in wordDic)
            {
                //初始值
                if (string.IsNullOrWhiteSpace(mostCommondWord))
                {
                    mostCommondWord = item.Key;
                    count = item.Value;
                    continue;
                }

                if (item.Value > count)
                {
                    mostCommondWord = item.Key;
                    count = item.Value;
                }
            }

            return mostCommondWord;

        }

        private bool IsEnglishAlphabet(char temp)
        {

            if (temp >= 'A' && temp <= 'Z')
            {
                return true;
            }

            if (temp >= 'a' && temp <= 'z')
            {
                return true;
            }

            return false;
        }
    }
}
