using System.Collections.Generic;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [804]  Unique Morse Code Words
    /// </summary>
    public class No0804
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            List<string> morselist = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                string morse = MorseOf(words[i]);
                if (!morselist.Contains(morse))
                {
                    morselist.Add(morse);
                }
            }

            return morselist.Count;
        }

        private static string[] MorseConstArray = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        private string MorseOf(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(MorseConstArray[str[i] - 97]);
            }
            return sb.ToString();
        }
    }
}
