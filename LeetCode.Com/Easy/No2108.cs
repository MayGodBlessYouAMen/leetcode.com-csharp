namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Find First Palindromic String in the Array
    /// </summary>
    public class No2108
    {
        /*
            解题思路：返回数组中的第一个回文字符串。遍历即可

            1 <= words.length <= 100
            1 <= words[i].length <= 100
            words[i] consists only of lowercase English letters.
         */
        public string FirstPalindrome(string[] words)
        {
            string goal = "";
            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    goal = word;
                    break;
                }
            }
            return goal;
        }

        private bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
