namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Guess Number Higher or Lower
    /// </summary>
    public class No0374
    {
        /// <summary>
        /// 定义pick变量。不用提交
        /// </summary>
        private int pick;

        /// <summary>
        /// 注入pick值。不用提交
        /// </summary>
        /// <param name="pick"></param>
        public No0374(int pick)
        {
            this.pick = pick;
        }

        /// <summary>
        /// 预定义的API。不用提交
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private int guess(int num)
        {
            if (this.pick < num)
            {
                return -1;
            }

            if (this.pick > num)
            {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// 需要提交的方法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GuessNumber(int n)
        {
            //二分查找（1<=pick<=n）
            if (n == 1)
            {
                return 1;
            }

            int left = 1;
            int right = n;

            while (true)
            {
                //int mid = (left + right) / 2;        //这么写会溢出，过不了
                int mid = left + (right - left) / 2;   //这么写不会溢出。
                int res = guess(mid);
                if (res == -1)
                {
                    right = mid - 1;
                }
                else if (res == 1)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
        }
    }
}
