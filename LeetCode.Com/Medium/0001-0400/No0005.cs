namespace LeetCode.Com.Medium
{
    /// <summary>
    /// Longest Palindromic Substring
    /// </summary>
    public class No0005
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return s;
            }

            string res = "";

            for (int i = 0; i < s.Length; i++)
            {
                //奇数回文
                {
                    int j = i;
                    int k = i;
                    while (CheckIndex(s, j) && CheckIndex(s, k) && s[j] == s[k])
                    {
                        string temp = s.Substring(j, k - j + 1);
                        res = res.Length < temp.Length ? temp : res;
                        j--;
                        k++;
                    }
                }


                //偶数回文
                if (CheckIndex(s, i + 1) && s[i] == s[i + 1])
                {
                    int j = i;
                    int k = i + 1;
                    while (CheckIndex(s, j) && CheckIndex(s, k) && s[j] == s[k])
                    {
                        string temp = s.Substring(j, k - j + 1);
                        res = res.Length < temp.Length ? temp : res;
                        j--;
                        k++;
                    }
                }
            }

            return res;
        }

        public bool CheckIndex(string s, int i)
        {
            if (i >= 0 && i < s.Length)
            {
                return true;
            }
            return false;
        }
    }
}
