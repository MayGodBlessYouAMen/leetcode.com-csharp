namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [476]  Number Complement
    /// </summary>
    public class No0476
    {
        public int FindComplement(int num)
        {
            int[] arr1 = ChangeIntToBinary(num);
            int[] arr2 = new int[32];
            bool findhead = false;
            for (int i = 31; i >= 0; i--)
            {
                if (arr1[i] == 1 && !findhead)
                {
                    findhead = true;
                }
                if (findhead)
                {
                    if (arr1[i] == 1)
                    {
                        arr2[i] = 0;
                    }
                    else
                    {
                        arr2[i] = 1;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < 32; i++)
            {
                if (arr2[i] == 1)
                {
                    sum += Pow(2, i);
                }
            }
            return sum;
        }

        private int Pow(int x, int n)
        {
            int p = 1;
            for (int i = 0; i < n; i++)
            {
                p *= x;
            }
            return p;
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
