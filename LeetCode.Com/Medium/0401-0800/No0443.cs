namespace LeetCode.Com.Medium
{
    /// <summary>
    /// [443] String Compression
    /// </summary>
    public class No0443
    {
        public int Compress(char[] chars)
        {
            int index = 0;
            int newindex = 0;
            while (index < chars.Length)
            {
                char current = chars[index];
                int count = 0;
                while (index < chars.Length && chars[index] == current)
                {
                    count++;
                    index++;
                }
                chars[newindex] = current;
                newindex++;
                if (count > 1)
                {
                    string strcount = count.ToString();
                    for (int i = 0; i < strcount.Length; i++)
                    {
                        chars[newindex] = strcount[i];
                        newindex++;
                    }
                }
            }
            return newindex;
        }
    }
}
