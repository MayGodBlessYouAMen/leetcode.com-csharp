using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Decrypt String from Alphabet to Integer Mapping
    /// </summary>
    public class No1309
    {
        /*
            解题思路:从左到右遍历。
                    每次截取3位字符。
                        如果第三位是#，那么这三位一体必定在j-z之间找。
                        如果第三位不是#，那么第一位一定在a-i之间找，后两位要下次判断。
                        如果不够3位了，那么一定在a-i之间找

            Characters ('a' to 'i') are represented by ('1' to '9') respectively.
            Characters ('j' to 'z') are represented by ('10#' to '26#') respectively.

            1 <= s.length <= 1000
            s consists of digits and the '#' letter.
            s will be a valid string such that mapping is always possible.
         */
        public string FreqAlphabets(string s)
        {
            StringBuilder sb = new StringBuilder();

            int index = 0;
            while (index < s.Length)
            {
                int len = s.Length - index > 3 ? 3 : s.Length - index;
                string sub = s.Substring(index, len);
                
                if (sub.Length < 3)
                {
                    for (int i = 0; i < sub.Length; i++)
                    {
                        //获取单个数字
                        int num = int.Parse(sub.Substring(i, 1));

                        //转换为对应的字母
                        sb.Append((char)(num + 97 - 1));
                    }

                    index += len;
                    continue;
                }

                if (sub[2] != '#')
                {
                    //虽然有三位，但是只能判断第一位，后面两位要结合后面判断

                    //获取单个数字
                    int num = int.Parse(sub.Substring(0, 1));

                    //转换为对应的字母
                    sb.Append((char)(num + 97 - 1));

                    index += 1;
                    continue;
                }

                //else
                {
                    //获取2位数字
                    int num = int.Parse(sub.Substring(0, 2));

                    //转换为对应的字母
                    sb.Append((char)(num + 97 - 1));

                    index += 3;
                }
            }

            return sb.ToString();
        }
    }
}
