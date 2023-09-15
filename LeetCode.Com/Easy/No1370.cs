using System.Collections.Generic;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Increasing Decreasing String
    /// </summary>
    public class No1370
    {
        /*
            解题思路：将s中字符存入字典，并计算每个字符数量。
            每次遍历26个字母，如果有则出一个，同时计数减1，减到0时移除key。直到字典为空结束

            1 <= s.length <= 500
            s consists of only lowercase English letters.
         */
        public string SortString(string s)
        {
            //将s所有字符存入字典
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                }
                else
                {
                    dic[item]++;
                }
            }

            //定义返回字符串
            StringBuilder sb = new StringBuilder();

            //按题目算法遍历
            while (dic.Keys.Count > 0)
            {
                //从小到大
                for (char key = 'a'; key <= 'z'; key++)
                {
                    if (dic.ContainsKey(key))
                    {
                        //添加
                        sb.Append(key);

                        //计数-1
                        dic[key]--;

                        //如果数量为0，移除key
                        if (dic[key] == 0)
                        {
                            dic.Remove(key);
                        }
                    }
                }

                if (dic.Keys.Count == 0)
                {
                    break;
                }

                //从大到小
                for (char key = 'z'; key >= 'a'; key--)
                {
                    if (dic.ContainsKey(key))
                    {
                        //添加
                        sb.Append(key);

                        //计数-1
                        dic[key]--;

                        //如果数量为0，移除key
                        if (dic[key] == 0)
                        {
                            dic.Remove(key);
                        }
                    }
                }
            }

            return sb.ToString();
        }
    }
}
