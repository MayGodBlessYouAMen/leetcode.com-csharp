using System.Collections.Generic;
using System.Text;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// 12. Integer to Roman
    /// </summary>
    public class No0012
    {
        public string IntToRoman(int num)
        {
            /*
             * 1 <= num <= 3999
             * 
             * 解题思路：
             * 列出所有的常规数字：
                1000,  M
                900,   CM
                500,   D
                400,   CD
                100,   C
                90,    XC
                50,    L
                40,    XL
                10,    X
                9,     IX
                5,     V
                4,     IV
                1      I

                遍历求商，直到余数为0

                普通数字可以通过组合和重复来表示。比如：
                2      II
                20     XX

            */

            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1000,"M"},
                {900,"CM"},
                {500,"D"},
                {400,"CD"},
                {100,"C"},
                {90,"XC"},
                {50,"L"},
                {40,"XL"},
                {10,"X"},
                {9,"IX"},
                {5,"V"},
                {4,"IV"},
                {1,"I"}
            };

            StringBuilder sb = new StringBuilder();

            foreach (var key in dic.Keys)
            {
                //计算商
                int temp = num / key;

                if (temp > 0)
                {
                    //重复temp次对应值
                    for (int i = 0; i < temp; i++)
                    {
                        sb.Append(dic[key]);
                    }
                }

                //计算余数
                num %= key;

                //余数为0则计算结束，跳出
                if (num == 0)
                {
                    break;
                }
            }


            return sb.ToString();
        }
    }
}
