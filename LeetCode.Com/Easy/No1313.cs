using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Decompress Run-Length Encoded List
    /// </summary>
    public class No1313
    {
        /*
            解题思路：加密后的数组两个一组，第二个是数字，第一个是第二个数字的个数。遍历输出即可。
         */
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> decodeList = new List<int>();
            for (int i = 0; i < nums.Length / 2; i++)
            {
                int index = i * 2;
                int numCount = nums[index];
                int num = nums[index + 1];
                for (int j = 0; j < numCount; j++)
                {
                    decodeList.Add(num);
                }
            }

            return decodeList.ToArray();
        }
    }
}
