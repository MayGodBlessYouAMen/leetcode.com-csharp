namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Longest Common Prefix
    /// </summary>
    public class No0014
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            if (strs.Length == 1) return strs[0];

            return Compare(strs, strs[strs.Length - 1], strs.Length - 2);
        }

        public string Compare(string[] strs, string str, int n)
        {
            if (n < 0) return "";

            if (n == 0)
            {
                return Compare(str, strs[0]);
            }

            string temp = Compare(str, strs[n]);
            if (temp == "")
            {
                return "";
            }
            return Compare(strs, temp, n - 1);
        }

        public string Compare(string str1, string str2)
        {
            int minlength = str1.Length > str2.Length ? str2.Length : str1.Length;
            string temp = "";
            for (int i = 0; i < minlength; i++)
            {
                if (str1[i] != str2[i])
                {
                    break;
                }

                temp += str1[i];
            }
            return temp;
        }
    }
}
