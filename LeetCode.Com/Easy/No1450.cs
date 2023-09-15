namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Number of Students Doing Homework at a Given Time
    /// </summary>
    public class No1450
    {
        /*
            解题思路：遍历一遍，判断查询时间在开始和结束之间即可

            startTime.length == endTime.length
            1 <= startTime.length <= 100
            1 <= startTime[i] <= endTime[i] <= 1000
            1 <= queryTime <= 1000         
         */
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int count = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if (startTime[i] <= queryTime &&
                    queryTime <= endTime[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
