namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Count of Matches in Tournament
    /// </summary>
    public class No1688
    {
        /*
            解题思路：n除以2直到为1

            1 <= n <= 200
         */
        public int NumberOfMatches(int n)
        {
            int matches = 0;
            while (n > 1)
            {
                matches += n / 2;

                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = n / 2 + 1;
                }
            }

            return matches;
        }
    }
}
