using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [401]  Binary Watch
    /// </summary>
    public class No0401
    {
        public IList<string> ReadBinaryWatch(int num)
        {
            IList<string> timeList = new List<string>();
            if (num <= 0 && num > 10)
            {
                return timeList;
            }

            /*
                ---------时---------- 0-3
                1 1 1 1
                --------------------- 
                8 4 2 1
                --------------------- 
                * 
                ---------分---------- 0-5
                1 1 1 1 1 1
                --------------------- 
                32 16 8 4 2 1
                --------------------- 
            */

            //遍历时h（0-11）和分m（0-59），如果h和m转换为二进制包含的1个数之和等于num，则符合。
            for (int h = 0; h < 12; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    if (BitCount(h) + BitCount(m) == num)
                    {
                        timeList.Add(string.Format("{0}:{1}", h, m.ToString("00")));
                    }
                }
            }

            return timeList;
        }

        /// <summary>
        /// 转换为二进制后包含的1个数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int BitCount(int n)
        {
            int t = n;
            int count = 0;
            while (t != 0)
            {
                count++;
                t = t & (t - 1);
            };
            return count;
        }
    }
}
