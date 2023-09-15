using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Baseball Game
    /// </summary>
    internal class No0682
    {
        /*
            解题思路：看懂规则即可

                输入数字：数字末尾增加这个数字
                输入C：移除数字最后一个数字
                输入D：将数组最后一个数字乘以2，到的结果插入数组末尾
                输入+：将数组最后两个数字相加，得到的结果插入数组末尾
                
            最后输出数组所以元素之和
         */
        public int CalPoints(string[] ops)
        {
            List<int> points = new List<int>();
            foreach (var item in ops)
            {
                if (item == "C")
                {
                    points.RemoveAt(points.Count - 1);
                    continue;
                }

                if (item == "D")
                {
                    points.Add(2 * points[points.Count - 1]);
                    continue;
                }

                if (item == "+")
                {
                    points.Add(points[points.Count - 2] + points[points.Count - 1]);
                    continue;
                }

                points.Add(int.Parse(item));
            }

            int sum = 0;
            foreach (var point in points)
            {
                sum += point;
            }

            return sum;
        }
    }
}
