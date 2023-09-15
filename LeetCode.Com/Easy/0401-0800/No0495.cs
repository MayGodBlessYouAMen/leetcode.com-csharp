namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Teemo Attacking
    /// </summary>
    public class No0495
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            //计算不重叠时的持续时间
            int totalTime = timeSeries.Length * duration;

            //减去重叠部分时间
            for (int i = 1; i < timeSeries.Length; i++)
            {
                if (timeSeries[i - 1] + duration <= timeSeries[i])
                {
                    //不重叠，跳过
                    continue;
                }

                totalTime -= timeSeries[i - 1] + duration - timeSeries[i];
            }

            return totalTime;
        }
    }
}
