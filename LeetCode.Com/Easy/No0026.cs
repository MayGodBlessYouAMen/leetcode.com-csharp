namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Remove Duplicates from Sorted Array
    /// </summary>
    public class No0026
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int temp = nums[0];
            int len = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != temp)
                {
                    temp = nums[i];
                    len++;
                    nums[len - 1] = nums[i];  //不重复元素位移到合适位置
                }
            }
            return len;  //新数组只会遍历 len长度内的元素
        }
    }
}
