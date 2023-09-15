namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [1137]  N-th Tribonacci Number
    /// </summary>
    public class No1137
    {
        private int[] TribonacciArray = new int[38];
        public int Tribonacci(int n)
        {
            if (TribonacciArray[n] != 0)
            {
                return TribonacciArray[n];
            }

            int answer = 0;
            switch (n)
            {
                case 0:
                    answer = 0;
                    break;
                case 1:
                    answer = 1;
                    break;
                case 2:
                    answer = 1;
                    break;
                default:
                    answer = Tribonacci(n - 3) + Tribonacci(n - 2) + Tribonacci(n - 1);
                    break;
            }
            //保存Tribonacci(n)的值，后续不用重复计算
            TribonacciArray[n] = answer;

            return answer;
        }
    }
}
