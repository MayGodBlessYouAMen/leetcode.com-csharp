namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Greatest Common Divisor of Strings
    /// </summary>
    public class No1071
    {
        /*
            解题思路：方法1：从最长开始遍历较短字符串的子串，满足子串长度能被两个字符串长度整除，字串分别重复一定次数后和两个字符串相等。
                      方法2：有公约数的字符串，必定满足s1+s2==s2+s1，最大公约数也是一个子串，且长度为两个字符串长度的最大公约数。
         */
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }

            int gcdNum = GCD(str1.Length, str2.Length);

            return str1.Substring(0, gcdNum);
        }

        /// <summary>
        /// 计算两个整数的最大公约数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int GCD(int a, int b)
        {
            /*
             * 使用辗转相除法 ：
             * gcd(a,b) = gcd(b,a%b) 
                
             * 以除数和余数反复做除法运算，当余数为 0 时，取当前算式除数为最大公约数
             */

            while (a % b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return b;
        }
    }
}
