namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [506]  Relative Ranks
    /// </summary>
    public class No0506
    {
        public string[] FindRelativeRanks(int[] nums)
        {
            //新建nums的副本a
            //新建一个长度和nums一样的数组b，b的值为0~n-1
            //对a进行排序，移位的过程中同时移动b对应的index
            //a排序完之后，顺序遍历b，用b[i]作为index，i=0~2时，输出前三的字符，之后输出index+1

            int[] a = new int[nums.Length];
            int[] b = new int[nums.Length];
            nums.CopyTo(a, 0);
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = i;
            }

            //冒泡逆序排序
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;

                        int index = b[j];
                        b[j] = b[j + 1];
                        b[j + 1] = index;
                    }
                }
            }

            string[] outputArray = new string[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    outputArray[b[i]] = "Gold Medal";
                    continue;
                }
                if (i == 1)
                {
                    outputArray[b[i]] = "Silver Medal";
                    continue;
                }
                if (i == 2)
                {
                    outputArray[b[i]] = "Bronze Medal";
                    continue;
                }
                outputArray[b[i]] = (i + 1).ToString();
            }

            return outputArray;
        }
    }
}
