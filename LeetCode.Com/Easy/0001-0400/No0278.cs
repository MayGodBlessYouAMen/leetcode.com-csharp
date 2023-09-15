namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [278] First Bad Version
    /// </summary>
    public class No0278
    {
        private int bad;

        public No0278(int bad)
        {
            this.bad = bad;
        }

        public bool IsBadVersion(int n)
        {
            if (n >= bad)
            {
                return true;
            }

            return false;
        }

        public int FirstBadVersion(int n)
        {
            #region 以为很简单，结果超时了
            //while (n > 0 && IsBadVersion(n)) n--;
            //return n + 1;
            #endregion

            #region 试试二分法
            if (IsBadVersion(1)) return 1;  //极端情况

            int left = 1;
            int rigth = n;
            while (left < rigth)
            {
                int mid = left / 2 + rigth / 2;  //(left + rigth) / 2;  //防止溢出
                if (IsBadVersion(mid))
                {
                    rigth = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            if (IsBadVersion(left))
            {
                return left;
            }
            if (IsBadVersion(rigth))
            {
                return rigth;
            }
            return rigth + 1;
            #endregion
        }
    }
}
