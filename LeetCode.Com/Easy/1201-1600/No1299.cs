namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Replace Elements with Greatest Element on Right Side
    /// </summary>
    public class No1299
    {
        /*
         *  将每个元素替换为它右侧最大的那个元素,最后一个元素替换为-1.
            解题思路:从右到左记录每一个出现的最大值，然后将左侧的值替换为当前最大值即可。
         */
        public int[] ReplaceElements(int[] arr)
        {
            int n = arr.Length;

            //初始值：最后一个元素
            int max = arr[n - 1];
            arr[n - 1] = -1;

            //从倒数第二个元素开始遍历到第0个元素
            for (int i = n - 2; i >= 0; i--)
            {
                //保留当前位置元素
                int temp = arr[i];

                //当前位置元素替换为右侧最大值
                arr[i] = max;

                //当前位置元素原始值和右侧最大值比较，取较大的值，作为更左侧的右侧最大值
                if (temp > max)
                {
                    max = temp;
                }
            }

            return arr;
        }
    }
}
