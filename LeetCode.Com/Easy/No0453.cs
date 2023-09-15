namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [453]  Minimum Moves to Equal Array Elements
    /// </summary>
    public class No0453
    {
        public int MinMoves(int[] nums)
        {
            //假设移动前所有数字和为sum，数组长度n,移动m次之后所有数字变为x
            //1. sum + m*(n-1) == x * n;
            //又因为最小的数字必定每次都会移动
            //2. minNum + m == x;
            //1,2可得:
            //3. m == sum- minNum*n

            //find minNum
            //sum
            int minNum = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    minNum = nums[0];
                }
                else
                {
                    if (nums[i] < minNum)
                    {
                        minNum = nums[i];
                    }
                }

                sum += nums[i];
            }

            return sum - minNum * nums.Length;
        }
    }
}
