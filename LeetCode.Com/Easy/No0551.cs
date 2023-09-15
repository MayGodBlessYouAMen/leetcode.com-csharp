using System.Linq;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Student Attendance Record I
    /// </summary>
    internal class No0551
    {
        /*
           缺勤天数累计少于2天
           不能有连续超过(包括)3天的迟到记录
         */

        public bool CheckRecord(string s)
        {
            if (s.Contains("LLL"))
            {
                return false;
            }

            int aCount = 0;
            foreach (var item in s.ToArray())
            {
                if (item == 'A')
                {
                    aCount++;
                }
            }

            if (aCount >= 2) return false;

            return true;
        }
    }
}
