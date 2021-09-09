using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Repeated Substring Pattern
    /// </summary>
    public class No0459
    {
        public bool RepeatedSubstringPattern(string s)
        {
            if (s.Length == 1)
            {
                return false;
            }

            //子串长度从1到遍历1/2总长
            for (int subLenth = 1; subLenth <= s.Length / 2; subLenth++)
            {
                //如果不能分成整数份，则不合适，跳过
                if (s.Length % subLenth != 0)
                {
                    continue;
                }

                //计算字串个数
                int subCount = s.Length / subLenth;
                bool isMatch = true;
                for (int i = 1; isMatch && i < subCount; i++)
                {
                    for (int j = 0; isMatch && j < subLenth; j++)
                    {
                        if (s[j] != s[i * subLenth + j])
                        {
                            isMatch = false; 
                        }
                    }
                }

                if (isMatch)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
