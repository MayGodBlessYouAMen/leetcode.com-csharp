namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Third Maximum Number
    /// </summary>
    public class No0414
    {
        public int ThirdMax(int[] nums)
        {
            long firstmax = long.MinValue;
            long sencondmax = long.MinValue;
            long thirdmax = long.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == firstmax || nums[i] == sencondmax || nums[i] == thirdmax)
                {
                    continue;
                }

                if (nums[i] > firstmax)
                {
                    thirdmax = sencondmax;
                    sencondmax = firstmax;
                    firstmax = nums[i];
                    continue;
                }

                if (nums[i] > sencondmax)
                {
                    thirdmax = sencondmax;
                    sencondmax = nums[i];
                    continue;
                }

                if (nums[i] > thirdmax)
                {
                    thirdmax = nums[i];
                    continue;
                }
            }

            if (firstmax > sencondmax && sencondmax > thirdmax && thirdmax > long.MinValue)
            {
                return (int)thirdmax;
            }

            return (int)firstmax;
        }
    }
}

