using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [541]  Reverse String II
    /// </summary>
    public class No0541
    {
        public string ReverseStr(string s, int k)
        {
            StringBuilder sb = new StringBuilder();
            while (s.Length > 0)
            {
                string rStr = "";
                string oStr = "";

                if (s.Length >= 2 * k)
                {
                    rStr = s.Substring(0, k);
                    oStr = s.Substring(k, k);
                    if (s.Length == 2 * k)
                    {
                        s = "";
                    }
                    else
                    {
                        s = s.Substring(2 * k);
                    }
                }
                else if (s.Length > k)
                {
                    rStr = s.Substring(0, k);
                    oStr = s.Substring(k);
                    s = "";
                }
                else
                {
                    rStr = s.Substring(0, s.Length);
                    oStr = "";
                    s = "";
                }

                sb.Append(ReverseStr(rStr));
                sb.Append(oStr);
            }
            return sb.ToString();
        }

        private string ReverseStr(string rStr)
        {
            return new string(rStr.Reverse().ToArray());
        }
    }
}
