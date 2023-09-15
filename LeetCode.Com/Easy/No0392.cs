namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Is Subsequence
    /// </summary>
    public class No0392
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0)
            {
                return true;
            }
            if (t.Length == 0)
            {
                return false;
            }
            if (s.Length > t.Length)
            {
                return false;
            }
            int i = 0;
            int j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            if (i > s.Length - 1)
            {
                return true;
            }
            return false;
        }
    }
}
