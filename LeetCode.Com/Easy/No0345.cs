using System.Linq;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [345] Reverse Vowels of a String
    /// </summary>
    public class No0345
    {
        public string ReverseVowels(string s)
        {
            char[] arrS = s.ToCharArray();
            int i = 0;
            int j = arrS.Length - 1;

            while (i < j && i < arrS.Length - 1 && j > 0)
            {
                if (IsVowel(arrS[i]) && IsVowel(arrS[j]))
                {
                    char c = arrS[i];
                    arrS[i] = arrS[j];
                    arrS[j] = c;
                    i++;
                    j--;
                }

                if (!IsVowel(arrS[i]))
                {
                    i++;
                }

                if (!IsVowel(arrS[j]))
                {
                    j--;
                }
            }

            return new string(arrS);
        }

        private char[] AllVowelArray = new char[] { 'a', 'o', 'e', 'i', 'u', 'A', 'O', 'E', 'I', 'U' };
        public bool IsVowel(char c)
        {
            if (this.AllVowelArray.Contains(c)) return true;
            return false;
        }
    }
}
