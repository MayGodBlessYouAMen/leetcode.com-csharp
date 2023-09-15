namespace LeetCode.Com
{
    /// <summary>
    /// [191] Number of 1 Bits
    /// </summary>
    public class No0191
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                if (n == 0) break;
                count += ((int)n & 1);
                n = n >> 1;  //右移位运算
            }
            return count;
        }
    }
}
