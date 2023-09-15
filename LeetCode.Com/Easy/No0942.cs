namespace LeetCode.Com.Easy
{
    /// <summary>
    /// DI String Match 
    /// </summary>
    internal class No0942
    {
        /*
            解题思路:要输出的数组是[0, n]的重新排列，且满足：
                s[i] == 'I' if perm[i] < perm[i + 1], and
                s[i] == 'D' if perm[i] > perm[i + 1].
                遍历一次，等于D时取最大值，等于I时取最小值，一定能满足条件

                注意:perm数组长度为n+1，s长度只有n
         */
        public int[] DiStringMatch(string s)
        {
            int n = s.Length;
            int min = 0;
            int max = n;

            int[] res = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'D')
                {
                    res[i] = max;
                    max--;
                }
                else
                {
                    res[i] = min;
                    min++;
                }
            }

            //补齐最后一个数
            res[n] = min;  //此时min和max应该相等，取其中一个即可。

            //Console.WriteLine(min == max);

            return res;
        }
    }
}
