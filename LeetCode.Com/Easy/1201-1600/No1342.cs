namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Number of Steps to Reduce a Number to Zero
    /// </summary>
    public class No1342
    {
        /*
            解题思路：如果是偶数，就除以2；否则，减1。知道数字变成0。记录使用的步骤数
         */
        public int NumberOfSteps(int num)
        {
            int step = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num--;
                }

                step++;
            }

            return step;
        }
    }
}
