namespace LeetCode.Com.Easy
{
    public class No0806
    {
        public int[] NumberOfLines(int[] widths, string S)
        {
            int rowcount = 1;
            int lineWidth = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (lineWidth + widths[S[i] - 97] <= 100)
                {
                    lineWidth += widths[S[i] - 97];
                    continue;
                }

                rowcount++;
                lineWidth = widths[S[i] - 97];
            }

            return new int[] { rowcount, lineWidth };
        }
    }
}
