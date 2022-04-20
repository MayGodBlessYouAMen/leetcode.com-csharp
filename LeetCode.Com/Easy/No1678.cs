using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Goal Parser Interpretation
    /// </summary>
    public class No1678
    {
        /*
            解题思路：一共就三个映射 G->G  ()->o (al)->al
                      遍历处理即可

            1 <= command.length <= 100
            command consists of "G", "()", and/or "(al)" in some order.
         */
        public string Interpret(string command)
        {
            StringBuilder sb = new StringBuilder(); 
            int index = 0;
            while (index < command.Length)
            {
                if (command.Substring(index, 1) == "G")
                {
                    sb.Append("G");
                    index++;
                    continue;
                }

                if (command.Substring(index, 2) == "()")
                {
                    sb.Append("o");
                    index+=2;
                    continue;
                }
                if (command.Substring(index, 4) == "(al)")
                {
                    sb.Append("al");
                    index += 4;
                    continue;
                }
            }
            return sb.ToString();
        }
    }
}
