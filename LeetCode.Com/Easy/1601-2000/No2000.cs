namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Reverse Prefix of Word
    /// </summary>
    public class No2000
    {
        /*
            解题思路：遍历word找到第一个ch，然后把之前的翻转
         */
        public string ReversePrefix(string word, char ch)
        {
            int index = -1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                return word;
            }

            var charArray = word.ToCharArray();
            //倒转
            for (int i = 0; i < (index + 1) / 2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[index - i];
                charArray[index - i] = temp;
            }

            return new string(charArray);
        }
    }
}
