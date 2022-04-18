using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Minimum Cost to Move Chips to The Same Position
    /// </summary>
    public class No1217
    {
        /*
            解题思路：先统计初始每个位置上的筹码个数。
                        按照题意，可以根据将所有位置的筹码按奇偶移动到1和0位置上，并且cost为0。
                        然后比较0和1位置上筹码的大小，将小的移动到大的上面。cost为1乘以较小的筹码数量

            1 <= position.length <= 100
            1 <= position[i] <= 10^9
         */
        public int MinCostToMoveChips(int[] position)
        {
            if (position.Length == 1)
            {
                return 0;
            }

            //统计初始每个位置上的筹码个数
            Dictionary<int,int> chipDic = new Dictionary<int, int>();
            foreach (var item in position)
            {
                if (chipDic.ContainsKey(item))
                {
                    chipDic[item]++;
                }
                else
                {
                    chipDic.Add(item, 1);
                }
            }

            //将所有筹码移动到0和1上
            int count0 = 0;
            int count1 = 0;
            foreach (var item in chipDic)
            {
                if (item.Key % 2 == 0)
                {
                    count0 += item.Value;
                }
                else
                {
                    count1 += item.Value;
                }
            }

            return count0 < count1 ? count0 : count1;
        }
    }
}
