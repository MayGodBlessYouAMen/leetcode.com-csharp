namespace LeetCode.Com.Easy
{
    /// <summary>
    /// A Number After a Double Reversal
    /// </summary>
    public class No2119
    {
        /*
            解题思路：数字两次翻转后，如果和原数字相等，只要保证原数字个位数不等于0即可。
                      注意0要单独判断

            0 <= num <= 10^6
         */
        public bool IsSameAfterReversals(int num)
        {
            if (num == 0) return true;

            return num % 10 != 0;
        }
    }
}
