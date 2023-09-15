namespace LeetCode.Com.Medium
{
    /// <summary>
    /// Partitioning Into Minimum Number Of Deci-Binary Numbers
    /// </summary>
    public class No1689
    {
        /*
         *  题意：将n分解为多个数字之和，这些数字满足每位只能是0或者1。
            解题思路：用贪心，将n从高位到地位遍历，如果大于等于1的位上减去1，等于0的位不动。直到n所有位数都为0为止。遍历的次数就是题目要的结果
                    
            1 <= n.length <= 10^5
            n consists of only digits.
            n does not contain any leading zeros and represents a positive integer.
         */
        public int MinPartitions(string n)
        {
            //标记不为0的最高位位置
            int index = 0;

            //n长度
            int len = n.Length;

            //将n转为int数组
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(n[i].ToString());
            }

            //用于记录可以分解的次数
            int count = 0;

            while (index <= len - 1)
            {
                //标记index是否能移到下一位
                bool canIndexMoveNext = true;
                for (int i = index; i < len; i++)
                {
                    //每个大于0的位减1
                    if (arr[i] > 0)
                    {
                        arr[i]--;
                    }

                    //如果当前位为0，则index指向下一位，作为下次遍历的开始
                    if (arr[i] == 0 && canIndexMoveNext)
                    {
                        index = i + 1;
                    }
                    else
                    {
                        canIndexMoveNext = false;
                    }
                }

                count++;
            }

            return count;
        }
    }
}
