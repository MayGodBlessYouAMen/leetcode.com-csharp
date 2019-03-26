using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Roman to Integer
    /// </summary>
    public class No0013
    {
        public int RomanToInt(string s)
        {
            /*
                M
                D 
                CD CM C 
                L
                XL XC X
                V
                IV IX I
            */

            char[] chars = s.ToCharArray();
            int sum = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'M':
                        sum += 1000;
                        break;
                    case 'D':
                        sum += 500;
                        break;
                    case 'C':
                        if (i + 1 < chars.Length)
                        {
                            if (chars[i + 1] == 'M')
                            {
                                sum += 900;
                                i++;
                                break;
                            }
                            if (chars[i + 1] == 'D')
                            {
                                sum += 400;
                                i++;
                                break;
                            }
                        }
                        sum += 100;
                        break;
                    case 'L':
                        sum += 50;
                        break;
                    case 'X':
                        if (i + 1 < chars.Length)
                        {
                            if (chars[i + 1] == 'C')
                            {
                                sum += 90;
                                i++;
                                break;
                            }
                            if (chars[i + 1] == 'L')
                            {
                                sum += 40;
                                i++;
                                break;
                            }
                        }
                        sum += 10;
                        break;
                    case 'V':
                        sum += 5;
                        break;
                    case 'I':
                        if (i + 1 < chars.Length)
                        {
                            if (chars[i + 1] == 'X')
                            {
                                sum += 9;
                                i++;
                                break;
                            }
                            if (chars[i + 1] == 'V')
                            {
                                sum += 4;
                                i++;
                                break;
                            }
                        }
                        sum += 1;
                        break;
                    default:
                        break;
                }
            }
            return sum;
        }
    }
}
