using System.Linq;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Reverse Words in a String III
    /// </summary>
    public class No0557
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }

            string[] arr = s.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Reverse(arr[i]);
            }

            return string.Join(" ", arr);
        }

        private string Reverse(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }
            char[] arr = s.ToArray();
            int len = arr.Length;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                char temp = s[i];
                arr[i] = arr[len - 1 - i];
                arr[len - 1 - i] = temp;
            }
            return new string(arr);
        }
    }
}
