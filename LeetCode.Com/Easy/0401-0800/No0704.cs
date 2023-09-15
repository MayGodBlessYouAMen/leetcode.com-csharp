namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Binary Search
    /// </summary>
    public class No0704
    {
        public int Search(int[] nums, int target)
        {
            //有序数组，二分查找
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                    continue;
                }
                if (nums[mid] > target)
                {
                    right = mid > 1 ? mid - 1 : mid;
                    continue;
                }

                return mid;
            }

            if (nums[left] == target)
            {
                return left;
            }

            if (nums[right] == target)
            {
                return right;
            }

            return -1;
        }
    }
}
