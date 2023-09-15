namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [507]  Perfect Number
    /// </summary>
    public class No0507
    {
        public bool CheckPerfectNumber(int num)
        {
            if (num == 1) return false;   //all its positive divisors except itself

            #region  Input data:100000000   348ms 判定超时
            //int sum = 0;
            ////完全遍历
            //for (int i = 1; i < num; i++)
            //{
            //    if (num % i == 0) sum += i;
            //}
            //return sum == num;
            #endregion

            #region  Input data:100000000   44ms
            int sum = 1;
            int i = 2;
            //只遍历到根号值，sum除数和商
            for (i = 2; i * i < num; i++)
            {
                if (num % i == 0) sum += i + num / i;
            }
            if (i * i == num) sum += i;
            return sum == num;
            #endregion
        }
    }
}
