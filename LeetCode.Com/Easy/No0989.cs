using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Add to Array-Form of Integer
    /// </summary>
    internal class No0989
    {

        /*
            解题思路：有点像两个大数相加的题。从低位开始按位相加即可。注意进位。

        1 <= num.length <= 10^4
        0 <= num[i] <= 9
        num does not contain any leading zeros except for the zero itself.
        1 <= k <= 10^4
         */
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            //分解k
            List<int> listK = new List<int>();
            while (k > 0)
            {
                listK.Insert(0, k % 10);
                k = k / 10;
            }

            int maxLength = num.Length > listK.Count ? num.Length : listK.Count;
            List<int> resList = new List<int>();

            int carry = 0;

            //按位相加
            for (int i = 0; i < maxLength; i++)
            {
                var item1 = num.Length - 1 - i >= 0 ? num[num.Length - 1 - i] : 0;
                var item2 = listK.Count - 1 - i >= 0 ? listK[listK.Count - 1 - i] : 0;

                var temp = item1 + item2 + carry;

                //进位
                carry = temp / 10;

                //当前值
                temp = temp % 10;

                resList.Insert(0, temp);
            }

            //最后的进位
            if (carry > 0)
            {
                resList.Insert(0, carry);
            }

            return resList.ToArray();
        }
    }
}
