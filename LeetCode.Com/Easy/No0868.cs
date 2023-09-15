namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Binary Gap
    /// </summary>
    internal class No0868
    {
        /*
            解题思路：n计算2进制，找出相邻的两个1间的最大距离
         */
        public int BinaryGap(int n)
        {
            int i = 0;
            int j = 0;
            int maxGap = 0;

            while (n > 0)
            {
                int temp = n % 2;

                //计数
                if (j > 0)
                {
                    j++;
                }

                if (temp == 1)
                {
                    if (i == 1)
                    {
                        //计算距离
                        if (j - i > maxGap)
                        {
                            maxGap = j - i;
                        }
                    }

                    //碰到1，初始计数
                    i = 1;
                    j = 1;
                }

                n = n / 2;
            }

            return maxGap;
        }
    }
}
