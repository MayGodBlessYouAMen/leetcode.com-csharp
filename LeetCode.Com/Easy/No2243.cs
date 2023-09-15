using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Calculate Digit Sum of a String
    /// </summary>
    public class No2243
    {
        /*
            解题思路：遍历计算即可
         */
        public string DigitSum(string s, int k)
        {
            while (s.Length > k)
            {
                int index = 1;
                int sum = 0;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < s.Length; i++)
                {
                    sum += int.Parse(s[i].ToString());
                    if (index % k == 0 || index == s.Length)
                    {
                        sb.Append(sum);
                        sum = 0;
                    }

                    index++;
                }
                s = sb.ToString();
            }

            return s;
        }
    }
}
