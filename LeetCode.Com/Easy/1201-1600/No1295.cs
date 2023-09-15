namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Find Numbers with Even Number of Digits
    /// </summary>
    public class No1295
    {
        /*
            解题思路：找出所有数字个数为偶数的数字，累计这些数字的数量。
                
            1 <= nums.length <= 500
            1 <= nums[i] <= 10^5
         */
        public int FindNumbers(int[] nums)
        {
            int count = 0;

            foreach (var num in nums)
            {
                if (IsEvenNumber(num)) count++;
            }

            return count;
        }

        private bool IsEvenNumber(int num)
        {
            if (num / 100000 > 0)
            {
                return true;
            }

            if (num / 10000 > 0)
            {
                return false;
            }

            if (num / 1000 > 0)
            {
                return true;
            }

            if (num / 100 > 0)
            {
                return false;
            }

            if (num / 10 > 0)
            {
                return true;
            }

            return false;
        }
    }
}
