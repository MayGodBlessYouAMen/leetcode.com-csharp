namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Minimum Bit Flips to Convert Number
    /// </summary>
    public class No2220
    {
        /*
            解题思路：计算两个数字的二进制。然后按位比较，不相同的位置就是需要要翻转的。计数即可。
         */
        public int MinBitFlips(int start, int goal)
        {
            int[] startBinary = ConvertIntToBinary(start);
            int[] goalBinary = ConvertIntToBinary(goal);

            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                if (startBinary[i] != goalBinary[i])
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// 数字转32位二进制数组
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static int[] ConvertIntToBinary(int num)
        {
            int[] binary = new int[32]; //32位int

            int index = 31;
            while (num > 0)
            {
                binary[index] = num % 2;
                num /= 2;
                index--;
            }

            return binary;
        }
    }
}
