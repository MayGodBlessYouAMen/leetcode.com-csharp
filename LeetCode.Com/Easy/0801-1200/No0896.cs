namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Monotonic Array
    /// </summary>
    internal class No0896
    {
        /*
            monotonicArray的定义：数组是单调递增或者单调递减的。
            
            解题思路：遍历数组，发现变大时标记递增，发现变小时标记递减，如果后一次标记和前一次标记相反，那么返回false。
                      未标记递增或者递减前，如果元素相等，则先不标记

            1 <= nums.length <= 105
            -105 <= nums[i] <= 105
         */
        public bool IsMonotonic(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }

            int flag = 0;  //0.无状态；1.递增；2.递减
            for (int i = 1; i < nums.Length; i++)
            {
                //相等时不改变flag
                if (nums[i] == nums[i - 1])
                {
                    continue;
                }

                //增加
                if (nums[i] > nums[i - 1])
                {
                    //第一次标记递增状态
                    if (flag == 0)
                    {
                        flag = 1;
                        continue;
                    }

                    //保持状态
                    if (flag == 1)
                    {
                        continue;
                    }

                    //已经标记过递减，不满足
                    if (flag == 2)
                    {
                        return false;
                    }
                }

                //减少
                if (nums[i] < nums[i - 1])
                {
                    //第一次标记递减状态
                    if (flag == 0)
                    {
                        flag = 2;
                        continue;
                    }

                    //保持状态
                    if (flag == 2)
                    {
                        continue;
                    }

                    //已经标记过递增，不满足
                    if (flag == 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
