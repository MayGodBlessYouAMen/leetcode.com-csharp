using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [933]  Number of Recent Calls
    /// </summary>
    public class No0933
    {
        public No0933()
        {

        }

        private Queue<int> _pingQueue = new Queue<int>();
        public int Ping(int t)
        {
            _pingQueue.Enqueue(t);
            while (t - _pingQueue.Peek() > 3000)
            {
                _pingQueue.Dequeue();
            }
            return _pingQueue.Count;
        }
    }
}
