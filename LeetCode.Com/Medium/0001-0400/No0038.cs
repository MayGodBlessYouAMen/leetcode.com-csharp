using System.Text;

namespace LeetCode.Com.Medium
{
    /// <summary>
    /// [38]Count and Say
    /// </summary>
    public class No0038
    {
        public string CountAndSay(int n)
        {
            if (n <= 0) return "1";  //提交测试结果就是1，不用在意
            if (n == 1) return "1";

            string s = CountAndSay(n - 1);
            StringBuilder sb = new StringBuilder();
            int i = 0;
            int count = 0;
            string key = s[0].ToString();
            while (i <= s.Length - 1)
            {
                if (s[i].ToString() == key)
                {
                    count++;
                }
                else
                {
                    sb.Append(count.ToString());
                    sb.Append(key);
                    key = s[i].ToString();
                    count = 1;
                }
                i++;
            }
            sb.Append(count.ToString());
            sb.Append(key);
            return sb.ToString();

        }
    }
}
