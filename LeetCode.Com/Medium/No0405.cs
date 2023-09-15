using System;
using System.Collections.Generic;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// Convert a Number to Hexadecimal
    /// 十进制转16进制
    /// </summary>
    public class No0405
    {
        public string ToHex(int num)
        {
            if (num == 0)
            {
                return "0";
            }

            //先转二进制。原码-->反码-->补码
            int[] codeArray = new int[32];
            if (num > 0)
            {
                //正数符号位为0
                codeArray = new int[32] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }
            else
            {
                //负数符号位为1
                codeArray = new int[32] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }

            //取绝对值
            long absnum = num > 0 ? num : (long)num * -1;   //Math.Abs(-2147483648)超出int范围，会溢出

            //计算原码
            List<int> remainderList = new List<int>(); //储存倒序的原码
            //除2
            while (true)
            {
                //余数
                long remainder = absnum % 2;

                //余数给数组赋值
                remainderList.Add((int)remainder);

                //商
                absnum = absnum / 2;
                if (absnum == 0)
                {
                    break;
                }
            }
            //倒序赋值
            for (int i = 0; i < remainderList.Count; i++)
            {
                codeArray[codeArray.Length - 1 - i] = remainderList[i];
            }

            //计算反码和补码。正数原码、反码、补码相同。
            if (num < 0)
            {
                //反码。符号位不动，剩下位数取反
                for (int i = 1; i <= 31; i++)
                {
                    codeArray[i] = (codeArray[i] + 1) % 2;
                }
                //特殊情况：-2147483648符号位实际为数值位，需要取反
                if (num == -1 * Math.Pow(2, 31))
                {
                    codeArray[0] = (codeArray[0] + 1) % 2;
                }

                //补码。反码+1
                int addnum = 1;
                for (int i = 31; i >= 0; i--)
                {
                    if (addnum == 0)
                    {
                        break;
                    }

                    int current = codeArray[i] + addnum;
                    if (current == 2)
                    {
                        //当前位清零，进1位
                        codeArray[i] = 0;
                        addnum = 1;
                    }
                    else
                    {
                        //无进位
                        codeArray[i] = current;
                        addnum = 0;
                    }
                }
            }

            //2进制补码转16进制。每4位合并
            string res = "";
            for (int i = 0; i < 8; i++)
            {
                int temp = codeArray[4 * i] * 8 + codeArray[4 * i + 1] * 4 + codeArray[4 * i + 2] * 2 + codeArray[4 * i + 3] * 1;
                if (temp == 0 && res == "")
                {
                    continue;
                }
                res += ToHexString(temp);
            }

            return res;
        }

        /// <summary>
        /// 1-15对应16进制写法
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        private string ToHexString(int temp)
        {
            if (temp >= 0 && temp <= 9)
            {
                return temp.ToString();
            }

            switch (temp)
            {
                case 10:
                    return "a";
                case 11:
                    return "b";
                case 12:
                    return "c";
                case 13:
                    return "d";
                case 14:
                    return "e";
                case 15:
                    return "f";
                default:
                    throw new Exception("参数错误");
            }
        }
    }
}
