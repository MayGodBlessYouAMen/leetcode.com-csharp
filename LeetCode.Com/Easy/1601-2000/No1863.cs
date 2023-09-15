namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Sum of All Subset XOR Totals
    /// </summary>
    public class No1863
    {
        /*
            解题思路：对于子数组，一个元素只有两种情况，取或者不取。
                    那么用递归可以解决。注意记录便利的index和当前xor的值

         */
        public int SubsetXORSum(int[] nums)
        {
            int sum = 0;

            Count(ref sum, 0, 0, nums);

            return sum;
        }

        /// <summary>
        /// 递归计算
        /// </summary>
        /// <param name="sum">和</param>
        /// <param name="xorVal">当前异或的值</param>
        /// <param name="index">当前遍历到nums数组的下标</param>
        /// <param name="nums">nums数组</param>
        private void Count(ref int sum, int xorVal, int index, int[] nums)
        {
            //递归终结条件
            if (index == nums.Length)
            {
                sum += xorVal;
                return;
            }

            //子数组包含当前index元素
            Count(ref sum, xorVal ^ nums[index], index + 1, nums);

            //子数组包不含当前index元素
            Count(ref sum, xorVal, index + 1, nums);
        }
    }
}
