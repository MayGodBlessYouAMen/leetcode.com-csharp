using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    public class No0482
    {
        public string LicenseKeyFormatting(string s, int k)
        {
            //用string拼接会超时，改为StringBuilder拼接
            StringBuilder sb = new StringBuilder();
            int count = 0;
            //倒序遍历
            for (int i = s.Length - 1; i >= 0; i--)
            {
                //跳过-
                if (s[i] == '-')
                {
                    continue;
                }

                count++;
                if (count == k + 1)
                {
                    //最前端插入-
                    sb.Insert(0, '-');
                    count = 1;
                }

                //最前端插入字符
                sb.Insert(0, s[i]);
            }

            return sb.ToString().ToUpper();
        }
    }
}
