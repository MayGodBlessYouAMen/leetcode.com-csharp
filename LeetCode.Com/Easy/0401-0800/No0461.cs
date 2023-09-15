namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [461]  Hamming Distance
    /// </summary>
    public class No0461
    {
        public int HammingDistance(int x, int y)
        {
            int[] arr1 = ChangeIntToBinary(x);
            int[] arr2 = ChangeIntToBinary(y);

            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    count++;
                }
            }
            return count;
        }

        private int[] ChangeIntToBinary(int num)
        {
            int n = num;
            int[] arr = new int[32];
            int maxindex = 0;
            while (true)
            {
                arr[maxindex] = n % 2;
                n = n / 2;
                if (n == 0)
                {
                    break;
                }
                maxindex++;
            }
            return arr;
        }
    }
}
